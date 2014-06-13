﻿window.onload = function () {
    var stage = new Kinetic.Stage({
        container: "container",
        width: 600,
        height: 600
    });

    var marioLayer = new Kinetic.Layer({
        opacity: 1
    });

    var marioAnimations = {
        run: [
            // x, y, width, height
            0, 0, 105, 148,
            150, 0, 110, 148,
            0, 0, 105, 148,
            300, 0, 150, 148
        ]
    };

    var marioImage = new Image();
    marioImage.onload = function () {
        var mario = new Kinetic.Sprite({
            x: 220,
            y: 310,
            image: marioImage,
            animation: 'run',
            animations: marioAnimations,
            frameRate: 4,
            frameIndex: 0
        });

        marioLayer.add(mario);
        stage.add(marioLayer);
        mario.start();
    };
    marioImage.src = 'images/mario.png';
};