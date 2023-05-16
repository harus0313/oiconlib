function svg2png() {
    var svg = document.querySelector("svg");
    var xml = new XMLSerializer().serializeToString(svg);
    var img = new Image();

    img.onload = function () {
        var canvas = document.createElement("canvas");
        canvas.width = img.width;
        canvas.height = img.height;
        var ctx = canvas.getContext("2d");
        ctx.drawImage(img, 0, 0);
        var dataURL = canvas.toDataURL("image/png");
        console.log(dataURL);
        window.open(dataURL);
    };

    img.src = "data:image/svg+xml;base64," + btoa(unescape(encodeURIComponent("🎃")));;
    console.log(img.src);
}


function svg2png2() {
    const emojiElement = document.getElementById("emoji");
    const canvas = document.createElement("canvas");
    canvas.width = emojiElement.width;
    canvas.height = emojiElement.height;

    var img = new Image();

    const ctx = canvas.getContext("2d");
    ctx.drawImage(img, 0, 0);
    const pngDataUrl = canvas.toDataURL("image/png");
    console.log(pngDataUrl);
}