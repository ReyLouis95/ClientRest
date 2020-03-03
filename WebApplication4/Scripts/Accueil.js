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
                console.log(data);
                rempliTexte(data);
            }
        });
    });
    function rempliTexte(data) {
        videInfos();
        $(data).each(function (index) {
            $('#table tr:last').after(afficheVelo(data[index]));
            console.log(data[index].Id);
        });
    }

    function afficheVelo(data) {
        return "<tr> <td>" + data.Id + " </td><td>" + data.Nom + " </td><td>" + data.Categorie + " </td><td>" + data.Prix + "€";
    }

    function videInfos() {
        $("#table").remove();
    }
});