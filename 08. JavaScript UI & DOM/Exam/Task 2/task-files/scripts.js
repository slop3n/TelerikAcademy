$.fn.gallery = function(columns) {
    var $this = this;
    var defaultColumns = columns || 4;
    $this.addClass('gallery');
    $('.gallery').css('width', defaultColumns * 260);
    $('.selected').hide();

    $this.find('.image-container').on('click', function() {
        var $this = $(this);
        $('.selected').show();
        var $currentSrc = $this.find('img').attr('src');
        var $nextSrc = $this.next().find('img').attr('src');
        var $prevSrc = $this.prev().find('img').attr('src');
        $('.current-image').find('img').attr('src', $currentSrc);
        $('.next-image').find('img').attr('src', $nextSrc);
        $('.previous-image').find('img').attr('src', $prevSrc);
    })

    $('.next-image').on('click', function() {
        var $this = $(this);
        var $next = $this.find('img').attr('src');
        $('.current-image').find('img').attr('src', $next)

    })

    $('.previous-image').on('click', function() {
        var $this = $(this);
        var $previous = $this.find('img').attr('src');
        $('.current-image').find('img').attr('src', $previous)
    })
};