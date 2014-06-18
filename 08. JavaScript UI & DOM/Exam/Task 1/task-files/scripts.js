function createImagesPreviewer(selector, items) {
    var container = document.querySelector(selector);
    var image = document.createElement('img');
    var imageTitle = document.createElement('div');
    var aside = document.createElement('aside');
    var filter = document.createElement('input');
    var filterTitle = document.createElement('div');
    var imageTags = document.querySelectorAll('img');
    var asideImages = document.getElementsByClassName('.asideImages');
    var leftContainer = document.createElement('h1');

    image.src = items[0].url
    imageTitle.innerHTML = items[0].title;

    container.style.height = '600px';
    container.style.width = '750px';

    leftContainer.style.width = '500px';
    leftContainer.style.display = 'inline-block';
    leftContainer.style.paddingLeft = '20px';
    leftContainer.style.paddingTop = '120px';

    imageTitle.style.textAlign = 'center';

    aside.style.float = 'right';
    aside.style.width = '200px';
    aside.style.height = '600px';
    aside.style.overflow = 'auto';

    image.style.width = '500px';
    image.style.borderRadius = '20px';

    filter.style.width = '175px';

    filterTitle.style.textAlign = 'center';
    filterTitle.innerHTML = 'Filter';

    aside.appendChild(filterTitle);
    aside.appendChild(filter);

    for (var i = 0; i < items.length; i++) {
        var images = document.createElement('img');
        var titles = document.createElement('span');
        var currentDiv = document.createElement('div');

        images.src = items[i].url;
        titles.innerHTML = items[i].title;

        images.style.width = '183px';
        images.style.borderRadius = '10px';
        images.className = 'asideImages';
        titles.style.textAlign = 'center';
        titles.style.display = 'inline-block';
        titles.style.width = '100%';
        titles.style.fontWeight = 'bold';

        currentDiv.className = 'asideImages';

        images.addEventListener('click', function() {
            var clicked = document.querySelector('.clicked');
            this.parentNode.className = 'clicked';
            imageTitle.innerHTML = this.previousSibling.innerHTML;
            image.src = this.src;
            clicked.className = 'asideImages';
        });

        images.addEventListener('mouseover', function() {
            this.parentNode.style.background = '#ddd';
        })

        images.addEventListener('mouseout', function() {
            this.parentNode.style.background = '';
        })

        currentDiv.appendChild(titles);
        currentDiv.appendChild(images);
        aside.appendChild(currentDiv);
    };

    leftContainer.appendChild(imageTitle);
    leftContainer.appendChild(image);
    container.appendChild(leftContainer);
    container.appendChild(aside);

    //sorry for the ultimate low quality of my code T.T
}