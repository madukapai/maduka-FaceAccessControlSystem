function AddRectangle(img, x, y, w, h) {
    // 先取得圖片原本的寬度
    var nImageWidth = img.naturalWidth;
    var ImageWidth = img.width;

    // 算出縮小的比例
    var percent = img.width / img.naturalWidth;
    x = x * percent;
    y = y * percent;
    w = w * percent;
    h = h * percent;

    var c = document.getElementById("myCanvas");
    c.width = img.width;
    c.height = img.height;
    var ctx = c.getContext("2d").drawImage(img, 0, 0);

    var canvas = document.getElementById('myCanvas');
    var context = canvas.getContext('2d');

    canvas.width = img.width;
    canvas.height = img.height;
    canvas.style.top = img.offsetTop;
    canvas.style.left = img.offsetLeft;

    context.beginPath();
    context.rect(x, y, w, h);
    context.fillStyle = 'rgba(255, 255, 255, 0)';
    context.fill();
    context.lineWidth = 2;
    context.strokeStyle = 'blue';
    context.stroke();
}