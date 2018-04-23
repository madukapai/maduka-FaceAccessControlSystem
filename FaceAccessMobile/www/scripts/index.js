function funCaptureCamera() {
    navigator.camera.getPicture(onSuccess, onFail, {
        quality: 50, destinationType: Camera.DestinationType.DATA_URL, PictureSourceType: 1, EncodingType: 1
    });
}

function onSuccess(imageData) {
    var imageContent = "data:image/png;base64," + imageData;
    document.getElementById('img').src = imageContent;

    // convert to binary
    var data = makeBlob(imageContent);
    GetIdentity(data);
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
        success: onIdentitySuccess,
        error: onIdentityFail
    })
}

function onIdentitySuccess(data)
{
    alert("success");
    console.log(data);
    document.getElementById("txtResult").value = JSON.stringify(data);

    /*
    var i = 0;
    for (i= 0; i < data.length; i++)
    {
        AddRectangle(document.getElementById('img'), data[i].faceRectangle.left, data[i].faceRectangle.top, data[i].faceRectangle.width, data[i].faceRectangle.height)
    }
    AddRectangle(document.getElementById('img'), 110, 110, 60, 60);
    */
}

function onIdentityDone(data)
{
    alert("done");
    console.log(data);
}


function onIdentityFail(err)
{
    alert("error");
    console.log(err);
}
