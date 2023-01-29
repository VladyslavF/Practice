document.querySelector('aside>.main__title').addEventListener('click', (event) => {
    let elem = document.querySelector('aside');
    let list =  elem.parentNode.querySelector('.main__links');
    let check = elem.parentNode.querySelector('.main__title>span')
    console.log(elem);
    list.classList.toggle('opened');
    check.classList.toggle('opened');
});

document.querySelector('.main__filter-title').addEventListener('click', (event) => {
    //let elem = event.target;
    let elem = document.querySelector('main');
    let title = document.querySelector('.main__filter-title');
    let list =  elem.parentNode.querySelector('.main__filters');
    let check = elem.parentNode.querySelector('.main__filter-title>img:last-child')
    console.log(elem);
    title.classList.toggle('opened');
    list.classList.toggle('opened');
    check.classList.toggle('rotated');
});

document.querySelectorAll('.main__filter-subtitle').forEach(function (item) {
    item.addEventListener('click', (event) => {
        let elem = event.target;
        if (elem === document.querySelector('.main__filter-subtitle>span')) {
            return 0;
        }
        let parent = elem.parentNode;

        parent.querySelector('.main__filter-subtitle>span').classList.toggle('rotated');
        parent.classList.toggle('opened');
        parent.querySelector('.main__subfilters').classList.toggle('opened');
    });
});
