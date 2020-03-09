$(document).ready(function () {
    var id = $("#categorie").data("id");
    var categorie = $("#categorie").text();
    var nom = $("#nom").text();
    var description = $("#description").text();
    var prix = $("#prix").text();
    var quantiteStock = $('#select').val();
    $("#commande").on("click", function () {
        var obj = {
            Id: id,
            Nom: nom,
            Categorie: categorie,
            Prix: prix,
            Description: description,
            QuantiteStock: quantiteStock
        }
        $.ajax({
            type: "POST",
            url: $("#url").data("url"),
            data: JSON.stringify(obj),
            contentType: "application/json; charset=utf-8",
            //dataType: "json",
            success: function (data) {
                console.log(data);
                alert();
            },
            error: function (data) {
                alert("erreur");
                console.log(data);
            }
        });
    });
});