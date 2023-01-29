document.querySelector('.burger__lines').addEventListener('click', (event) =>{
    let elem = event.target;
    elem.parentNode.querySelector('.burger__line1').classList.toggle('rotated');
    elem.parentNode.querySelector('.burger__line2').classList.toggle('rotated');
    elem.parentNode.querySelector('.burger__line3').classList.toggle('rotated');

    let main_menuElem = document.querySelector('.header');
    let secondary_menuElem = document.querySelector('.header__submenu');
    let mobile_main_menuElem = document.querySelector('.mobile-menu');
    let vw = Math.max(document.documentElement.clientWidth || 0, window.innerWidth || 0);
    console.log(vw);
    setTimeout((e) => {}, 500);
    if (vw <= 700) {
        //main_menuElem.classList.toggle('active');
        secondary_menuElem.classList.toggle('active');
        mobile_main_menuElem.classList.toggle('active');
    }
    else if (vw > 700) {
        main_menuElem.classList.toggle('active');
        secondary_menuElem.classList.toggle('active');
    }

});
document.querySelector('.lang__title').addEventListener('click', (event) => {
    let elem = event.target;
    let list = document.querySelector('.lang__dropdown');
    let icon = document.querySelector('.lang__title');
    console.log(elem);
    icon.classList.toggle('opened');
    list.classList.toggle('opened');
});

document.querySelectorAll('.lang__item').forEach(function (item) {
   item.addEventListener('click', (event) => {
       let elem = event.target;
       let parent = elem.parentNode.parentNode;
       let span = '<span class="icon-arrow-black"></span>'
       console.log(elem);
       let temp = parent.querySelector('.lang__title').innerHTML;
       console.log(temp);
       parent.querySelector('.lang__title').innerHTML = elem.innerHTML + span;
       elem.innerHTML = temp - span;
   });
});

document.querySelector('.currency__title').addEventListener('click', (event) => {
    let elem = event.target;
    let list = document.querySelector('.currency__dropdown');
    let icon = document.querySelector('.currency__title');
    console.log(elem);
    icon.classList.toggle('opened');
    list.classList.toggle('opened');
});
document.querySelector('.mobile-menu__currency>.currency__title').addEventListener('click', (event) => {
    let elem = event.target;
    let list = document.querySelector('.mobile-menu__currency>.currency__dropdown');
    let icon = document.querySelector('.mobile-menu__currency>.currency__title');
    console.log(elem);
    icon.classList.toggle('opened');
    list.classList.toggle('opened');
});
