document.querySelectorAll('.order__sizes>.order__dropdown>.sizes__item').forEach(function (item) {
    item.addEventListener('click', (event) => {
        let elem = event.target;
        let parent = elem.parentNode.parentNode;
        console.log(elem);
        let temp = parent.querySelector('.order__size').innerText;
        console.log(temp);
        parent.querySelector('.order__size').innerText = elem.innerText;
        elem.innerText = temp;
    });
});
document.querySelectorAll('.order__sizes').forEach(function (item) {
    item.addEventListener('click', (event) => {
        let elem = event.target;
        if (elem === document.querySelectorAll('.sizes__item')) {
            return 0;
        }
        let parent = elem.parentNode;
        console.log(elem);
        parent.querySelector('img').classList.toggle('rotated');
        parent.querySelector('.order__dropdown').classList.toggle('opened');
    });
});
document.querySelectorAll('.order__remove>img').forEach(function (item) {
    item.addEventListener('click', (event) => {
        let elem = event.target;
        let parent = elem.parentNode;
        parent.parentNode.parentNode.removeChild(parent.parentNode);
    });
});
document.querySelectorAll('.order__count>.order__button-minus').forEach(function (item) {
    item.addEventListener('click', (event) => {
        let elem = event.target.parentNode;
        let count = elem.querySelector('.order__number').innerText;
        if (count - 1 >= 0) {
            elem.querySelector('.order__number').innerText = count - 1;
        }
    });
});
document.querySelectorAll('.order__count>.order__plus').forEach(function (item) {
    item.addEventListener('click', (event) => {
        let elem = event.target.parentNode;
        let count = elem.querySelector('.order__number').innerText;
        elem.querySelector('.order__number').innerText = (count - 1) + 2;
    });
});