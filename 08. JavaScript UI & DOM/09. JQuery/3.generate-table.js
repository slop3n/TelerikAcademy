function createTable(data) {
    $('<table/>').attr('id', 'grades').appendTo('#container')
    $.each(data, function(i, item) {
        var $tr = $('<tr>').append(
            $('<td>').text(item.firstName),
            $('<td>').text(item.lastName),
            $('<td>').text(item.grade)
        ).appendTo('#grades');
    });
    $('td').css('border', '1px solid black');
    $('#grades').css('border-collapse', 'collapse')
}