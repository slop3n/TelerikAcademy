$.fn.dropdown = function () {
    var $this = $(this);
    $this.css('display', 'none'); // hide the original dropdown

    var $container = $('<div />');
    $container.addClass('dropdown-list-container');
    $container.css('width', '100px');
    $container.css('border', '1px solid black');
    $container.css('cursor', 'context-menu');

    var $selectedItem = $('<div />');
    $selectedItem.css('padding-left', '5px');
    $selectedItem.css('background', '#43609C');
    $selectedItem.text('Select country');
    $container.append($selectedItem);

    var $ul = $('<ul />');
    $ul.css('list-style-type', 'none');
    $ul.css('padding', 0);
    $ul.css('margin', 0);
    $ul.css('display', 'none');
    $ul.css('background', 'yellow');

    var $li = $('<li />');
    $li.addClass('drop-down-list-option');
    $li.css('padding-left', '5px');

    var $options = $('option', $this);
    $options.each(function (index, value) {
        $li.text($(value).text());
        $ul.append($li);
        $li = $li.clone();
    });

    $container.append($ul);
    $(document.body).append($container);

    $selectedItem.on('click', function () {
        $selectedItem.css('border-bottom', '1px solid black');
        $ul.css('display', 'block');
    });

    $ul.on('click', 'li.drop-down-list-option', function () {
        $selectedItem.text($(this).text());
        $ul.css('display', 'none');
        $selectedItem.css('border-bottom', 'none');
    })
    $ul.on('mouseover', 'li.drop-down-list-option', function () {
        $(this).css('background', 'green');
    })
    $ul.on('mouseout', 'li.drop-down-list-option', function () {
        $(this).css('background', 'yellow');
    })
}

$('#dropdown').dropdown();