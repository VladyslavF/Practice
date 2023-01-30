document.querySelector('.main__small').addEventListener('click', (event) => {
    let elem = event.target;
    let big = document.querySelector('.main__big>.main__photo>img');
    console.log(elem);
    let temp = big.src;
    big.src = elem.src;
    elem.src = temp;
});

document.querySelector('.main__size-selection').addEventListener('click', (event) => {
    let elem = event.target;
    if (elem === document.querySelector('.main__size-selection')) {
        return 0;
    }
    //let big = document.querySelector('.main__big>.main__photo>img');
    let check = elem.parentNode.querySelector('.size-selection__title>span')
    let dropdown = elem.parentNode.querySelector('.size-selection__dropdown');
    let title = elem.parentNode.querySelector('.size-selection__title')
    console.log(elem);
    title.classList.toggle('opened');
    check.classList.toggle('rotated');
    dropdown.classList.toggle('opened');
    elem.parentNode.classList.toggle('opened');
    //let temp = big.src;
    //big.src = elem.src;
    //elem.src = temp;
});
document.querySelector('.main__ingredients-name').addEventListener('click', (event) =>{
   let elem = event.target;
   let parent = elem.parentNode;
   parent.querySelector('.main__ingredient-detail').classList.toggle('opened');
   parent.querySelector('.main__ingredients-name>span').classList.toggle('rotated');
});
document.querySelector('.size-and-description__title').addEventListener('click', (event) =>{
    let elem = event.target;
    let parent = elem.parentNode;
    parent.querySelector('.size-and-description__dropdown').classList.toggle('opened');
    parent.querySelector('.size-and-description__title>span').classList.toggle('rotated');
});