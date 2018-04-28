﻿function funCaptureCamera(x) {
    navigator.camera.getPicture(
        function (data) { onSuccess(data, x); },
        onFail,
        {
            quality: 80, destinationType: Camera.DestinationType.DATA_URL, PictureSourceType: 1, EncodingType: 1
        }
    );
}

function onSuccess(imageData, func) {
    var imageContent = "data:image/png;base64," + imageData;
    document.getElementById('img').src = imageContent;
    document.getElementById('img').style.display = "block";
    document.getElementById('myCanvas').style.display = "none";

    // 判斷是人臉辨識或是影像辨識
    // convert to binary
    var data = makeBlob(imageContent);

    if (func == "f") {
        GetIdentity(data);
    }
    else if (func == "c") {
        GetComputerVision(data)
    }
}

function onFail(message) {
    alert('Failed because: ' + message);
}

function makeBlob(dataURL) {
    var BASE64_MARKER = ';base64,';
    if (dataURL.indexOf(BASE64_MARKER) == -1) {
        var parts = dataURL.split(',');
        var contentType = parts[0].split(':')[1];
        var raw = decodeURIComponent(parts[1]);
        return new Blob([raw], { type: contentType });
    }
    var parts = dataURL.split(BASE64_MARKER);
    var contentType = parts[0].split(':')[1];
    var raw = window.atob(parts[1]);
    var rawLength = raw.length;

    var uInt8Array = new Uint8Array(rawLength);

    for (var i = 0; i < rawLength; ++i) {
        uInt8Array[i] = raw.charCodeAt(i);
    }

    return new Blob([uInt8Array], { type: contentType });
}

function GetIdentity(imageData) {
    var params = {
        // Request parameters
        "returnFaceId": "true",
        "returnFaceLandmarks": "true",
        "returnFaceAttributes":"age,gender,smile,facialHair,glasses,emotion,hair"
    };

    $.ajax({
        url: FaceApiRootUrl + "detect?" + $.param(params),
        beforeSend: function (xhrObj) {
            // Request headers
            xhrObj.setRequestHeader("Content-Type", "application/octet-stream");
            xhrObj.setRequestHeader("Ocp-Apim-Subscription-Key", FaceApiKey);
        },
        processData: false,
        type: "POST",
        data: imageData,
        success: onIdentityDone,
        error: onIdentityDone
    })
}

function GetComputerVision(imageData)
{
    var params = {
        // Request parameters
        "visualFeatures": "Tags,Description,Faces,Color,Adult",
        "details": "Celebrities",
        "language": "en"
    };

    $.ajax({
        url: CompoterVisionApiRootUrl + "analyze?" + $.param(params),
        beforeSend: function (xhrObj) {
            // Request headers
            xhrObj.setRequestHeader("Content-Type", "application/octet-stream");
            xhrObj.setRequestHeader("Ocp-Apim-Subscription-Key", CompoterVisionApiKey);
        },
        processData: false,
        type: "POST",
        data: imageData,
        success: onComputerVisionDone,
        error: onComputerVisionDone
    })
}

function GetTranslater(data, source, target) {
    var params = {
        // Request parameters
        "to": target,
        "text": source
    };

    var strUrl = TranslaterUrl + "?" + $.param(params);
    $.ajax({
        url: strUrl,
        beforeSend: function (xhrObj) {
            // Request headers
            xhrObj.setRequestHeader("Ocp-Apim-Subscription-Key", TranslaterApiKey);
        },
        type: "GET",
        success: function (res) { onTranslaterDone(data, res); },
        error: function (res) { onTranslaterDone(data, res); }
    })
}

function onIdentityDone(data) {
    document.getElementById("txtResult").value = JSON.stringify(data);
    AddRectangle(document.getElementById('img'), data, "f");
}

function onComputerVisionDone(data)
{
    GetTranslater(data, data.description.captions[0].text, "zh-Hant");
}

function onTranslaterDone(data, caption)
{
    document.getElementById("txtResult").value = JSON.stringify(data);
    var str = caption.getElementsByTagName("string")[0].textContent;
    AddRectangle(document.getElementById('img'), data.faces, str);

}
