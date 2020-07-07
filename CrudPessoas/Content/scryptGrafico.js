function drawChart() {
    var url = '@Url.Action("GraficoPessoa","Dashboard")'
    var datas;
    $.get(url, null, function (data) {
        debugger;
        for (var i = 0; i < data.lenght; i++) {
            datas += google.visualization.arrayToDataTable(data[i].Nome, data[i].Valor);
        }


        var options = {
            title: 'Compras por pessoa'
        };

        var chart = new google.visualization.PieChart(document.getElementById('piechart'));

        chart.draw(datas, options);
    })

}

