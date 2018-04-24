function AddRectangle(img, data) {
    if (img.style.display == "none")
        img.style.display = "block";

    // 先取得圖片原本的寬度
    var nImageWidth = img.naturalWidth;
    var ImageWidth = img.offsetWidth;

    // 將圖片畫到Canvas上
    var canvas = document.getElementById("myCanvas");
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

            context.rect(x, y, w, h);
            context.fillStyle = 'rgba(255, 255, 255, 0)';
            context.fill();
            context.lineWidth = 2;
            context.strokeStyle = 'yellow';
        }
    }

    context.stroke();
    img.style.display = "none";
}