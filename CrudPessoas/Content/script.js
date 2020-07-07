function Filtro() {
    $("#tabelaPessoas input").keyup(function () {
        var index = $(this).parent().index();
        var nth = "#tabelaPessoas td:nth-child(" + (index + 1).toString() + ")";
        var valor = $(this).val().toUpperCase();
        $("#tabelaPessoas tbody tr").show();
        $(nth).each(function () {
            if ($(this).text().toUpperCase().indexOf(valor) < 0) {
                $(this).parent().hide();
            }
        });
    });

    $("#tabelaPessoas input").blur(function () {
        $(this).val("");
    });
};

