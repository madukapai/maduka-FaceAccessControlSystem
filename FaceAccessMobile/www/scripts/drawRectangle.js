function AddRectangle(img, data) {
    // 先取得圖片原本的寬度
    var nImageWidth = img.naturalWidth;
    var ImageWidth = img.offsetWidth;

    // 將圖片畫到Canvas上
    var canvas = document.getElementById("myCanvas");
    canvas.style.display = "block";

    var context = canvas.getContext("2d");
    canvas.width = img.width;
    canvas.height = img.height;
    context.drawImage(img, 0, 0, img.width, img.height);

    // 畫出框線
    context.beginPath();
    if (data != undefined) {
        var i = 0;
        for (i = 0; i < data.length; i++) {
            // 算出縮小的比例
            var percent = img.width / img.naturalWidth;
            x = data[i].faceRectangle.left * percent;
            y = data[i].faceRectangle.top * percent;
            w = data[i].faceRectangle.width * percent;
            h = data[i].faceRectangle.height * percent;

            context.lineWidth = 2;
            context.strokeStyle = 'yellow';
            context.strokeRect(x, y, w, h);
            // 顯示年齡與情緒
            var intAge = data[i].faceAttributes.age;
            var emotion = GetEmotion(data[i].faceAttributes.emotion)
            var gender = data[i].faceAttributes.gender;
            context.fillStyle = 'yellow';            context.font = (w / 10) + "px Arial";
            context.fillText(gender + " age:" + intAge + " " + emotion, x, y + h + (w / 10));
            // context.fillText(emotion, x, y + h + (w / 5));

            context.fill();
        }
    }

    context.stroke();
    img.style.display = "none";
}

function GetEmotion(emotion) {
    var emotionString = "anger";
    if (emotion.contempt > emotion.anger) { emotionString = "contempt" }
    if (emotion.disgust > emotion.contempt) { emotionString = "disgust" }
    if (emotion.fear > emotion.disgust) { emotionString = "fear" }
    if (emotion.happiness > emotion.fear) { emotionString = "happiness" }
    if (emotion.neutral > emotion.happiness) { emotionString = "neutral" }
    if (emotion.sadness > emotion.neutral) { emotionString = "sadness" }
    if (emotion.surprise > emotion.sadness) { emotionString = "surprise" }

    return emotionString;
}