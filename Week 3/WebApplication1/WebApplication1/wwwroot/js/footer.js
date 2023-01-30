document.querySelector('.footer__columns').addEventListener('click', (event) => {
    let elem = event.target;
    let list =  elem.parentNode.querySelector('.footer__list');
    let check = elem.parentNode.querySelector('span')
    console.log(elem);
    list.classList.toggle('opened');
    check.classList.toggle('rotate');
});