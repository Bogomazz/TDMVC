$(function () {
    // Ссылка на автоматически-сгенерированный прокси хаба
    var hub = $.connection.myHub;

    hub.server.connect("Name", "attack");

    hub.client.vait = function(){
        $(".game").val("VAIT");
    }

    hub.client.oponentName() = function (opName) {
        $(".game").val("Yours oonnent name is " + opName);
    }
})