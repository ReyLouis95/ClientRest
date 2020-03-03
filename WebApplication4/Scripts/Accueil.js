$(document).ready(function () {
    $(".categorie").on('click', function () {
        var id = $(this).data('id');
        var obj = { id: id };
        $.ajax({
            type: "POST",
            url: "../Accueil/getVelosByCateg",
            data: JSON.stringify(obj),
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (data) {
                console.log(data[0].nom);
                rempliTexte(data);
            }
        });
    });
    function rempliTexte(data) {
        $("#detailCategorie").text(data);
    }
});