$(function () {
    // Ссылка на автоматически-сгенерированный прокси хаба
    var hub = $.connection.myHub;

    hub.server.connect("NameDef", "defence");

    hub.client.vait = function () {
        $(".game").val("VAIT");
    }

    hub.client.oponentName() = function (opName) {
        $(".game").val("Yours oonnent name is " + opName);
    }
})