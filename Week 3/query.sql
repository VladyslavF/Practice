use Shop

SET IDENTITY_INSERT dbo.Shop ON

Drop Database Shop
Drop table Products

delete from Sizes
delete  from Colors
delete from Categories
delete from Products

insert into Sizes values ('XXS', 40)
insert into Sizes values ('XS', 42)
insert into Sizes values ('S', 44)
insert into Sizes values ('M', 46)
insert into Sizes values ('L', 48)

insert into Colors values ('Beige', '#F1DDAA', N'Кофе с молоком меланж')
insert into Colors values ('Navy', '#6F83A4', N'Синий')
insert into Colors values ('White', '#FFFFFF', N'Белый')

insert into Categories values (N'Верхняя одежда')
insert into Categories values (N'Шубы')
insert into Categories values (N'Тренчи')
insert into Categories values (N'Пальто')
insert into Categories values (N'Пуховики и жилеты')
insert into Categories values (N'Костюмы')
insert into Categories values (N'Жакеты')
insert into Categories values (N'Платья')
insert into Categories values (N'Рубашки и блузы')
insert into Categories values (N'Юбки')
insert into Categories values (N'Футболки и топы')
insert into Categories values (N'Аксессуары')

select * from Categories
select * from Sizes
select * from Colors
select * from Products
select * from Product_Sizes

insert into Products values (N'Белая куртка', 2900, 'img-c-1.png', 1, 3, 'Lorem Ipsum', 'Lorem Ipsum', 'new')
insert into Product_Sizes values (1, 1)
insert into Product_Sizes values (1, 2)
insert into Product_Sizes values (1, 3)
insert into Product_Sizes values (1, 4)
insert into Product_Sizes values (1, 5)

insert into Products values (N'Синее пальто', 3150, 'img-c-2.png', 4, 2, 'Lorem Ipsum', 'Lorem Ipsum', null)
insert into Product_Sizes values (2, 2)
insert into Product_Sizes values (2, 4)
insert into Product_Sizes values (2, 5)

insert into Products values (N'Бежевая шуба', 4200, 'img-c-3.png', 2, 1, 'Lorem Ipsum', 'Lorem Ipsum', null)
insert into Product_Sizes values (3, 2)
insert into Product_Sizes values (3, 3)
insert into Product_Sizes values (3, 5)

insert into Products values (N'Синяя парка', 2900, 'img-c-4.png', 1, 2, 'Lorem Ipsum', 'Lorem Ipsum', 'new')
insert into Product_Sizes values (4, 1)
insert into Product_Sizes values (4, 2)
insert into Product_Sizes values (4, 3)
insert into Product_Sizes values (4, 4)
insert into Product_Sizes values (4, 5)

insert into Products values (N'Белая куртка', 2900, 'img-c-1.png', 1, 3, 'Lorem Ipsum', 'Lorem Ipsum', 'new')
insert into Product_Sizes values (5, 1)
insert into Product_Sizes values (5, 2)
insert into Product_Sizes values (5, 3)
insert into Product_Sizes values (5, 4)
insert into Product_Sizes values (5, 5)

insert into Products values (N'Синее пальто', 3150, 'img-c-2.png', 4, 2, 'Lorem Ipsum', 'Lorem Ipsum', null)
insert into Product_Sizes values (6, 2)
insert into Product_Sizes values (6, 4)
insert into Product_Sizes values (6, 5)

insert into Products values (N'Белая куртка', 2900, 'img-c-1.png', 1, 3, 'Lorem Ipsum', 'Lorem Ipsum', 'new')
insert into Product_Sizes values (7, 1)
insert into Product_Sizes values (7, 2)
insert into Product_Sizes values (7, 3)
insert into Product_Sizes values (7, 4)
insert into Product_Sizes values (7, 5)

insert into Products values (N'Синее пальто', 3150, 'img-c-2.png', 4, 2, 'Lorem Ipsum', 'Lorem Ipsum', null)
insert into Product_Sizes values (8, 2)
insert into Product_Sizes values (8, 4)
insert into Product_Sizes values (8, 5)

insert into Products values (N'Бежевая шуба', 4200, 'img-c-3.png', 2, 1, 'Lorem Ipsum', 'Lorem Ipsum', null)
insert into Product_Sizes values (9, 2)
insert into Product_Sizes values (9, 3)
insert into Product_Sizes values (9, 5)

insert into Products values (N'Синяя парка', 2900, 'img-c-4.png', 1, 2, 'Lorem Ipsum', 'Lorem Ipsum', 'new')
insert into Product_Sizes values (10, 1)
insert into Product_Sizes values (10, 2)
insert into Product_Sizes values (10, 3)
insert into Product_Sizes values (10, 4)
insert into Product_Sizes values (10, 5)

insert into Products values (N'Белая куртка', 2900, 'img-c-1.png', 1, 3, 'Lorem Ipsum', 'Lorem Ipsum', 'new')
insert into Product_Sizes values (11, 1)
insert into Product_Sizes values (11, 2)
insert into Product_Sizes values (11, 3)
insert into Product_Sizes values (11, 4)
insert into Product_Sizes values (11, 5)

insert into Products values (N'Синее пальто', 3150, 'img-c-2.png', 4, 2, 'Lorem Ipsum', 'Lorem Ipsum', null)
insert into Product_Sizes values (12, 2)
insert into Product_Sizes values (12, 4)
insert into Product_Sizes values (12, 5)


insert into Menu values (N'Компания')
insert into Menu values (N'Полезное')
insert into Menu values (N'Покупателю')
insert into Menu values (N'Контакты')

select * from Item
select * from Links

insert into Links values (1, N'О нас', 'URL')
insert into Links values (1, N'Контакты', 'URL')

insert into Links values (2, N'Оплата и доставка', 'URL')
insert into Links values (2, N'Условия возврата', 'URL')
insert into Links values (2, N'Бонусная система', 'URL')

insert into Links values (3, N'Избранное', 'URL')
insert into Links values (3, N'Публичная оферта', 'URL')
insert into Links values (3, N'Политика конфиденциальности', 'URL')

insert into Links values (4, N'ICONS', 'URL')
insert into Links values (4, N'+38(073) 096 36 44', 'URL')
insert into Links values (4, N'info@yanki.com', 'URL')

insert into Users values ('Administrator', 'admin@local', 'password', 1)

select * from users





insert into Products values (N'Белая куртка', 2900, 'img-c-1.png', 1, 3, 'Lorem Ipsum', 'Lorem Ipsum', 'new')
insert into Products values (N'Синее пальто', 3150, 'img-c-2.png', 4, 2, 'Lorem Ipsum', 'Lorem Ipsum', null)
insert into Products values (N'Бежевая шуба', 4200, 'img-c-3.png', 2, 1, 'Lorem Ipsum', 'Lorem Ipsum', null)
insert into Products values (N'Синяя парка', 2900, 'img-c-4.png', 1, 2, 'Lorem Ipsum', 'Lorem Ipsum', 'new')

insert into Products values (N'Белая куртка', 2900, 1, 'img-c-1.png', 1, 3, 'Lorem Ipsum', 'Lorem Ipsum', 'new')
insert into Products values (N'Синее пальто', 3150, 4, 'img-c-2.png', 4, 2, 'Lorem Ipsum', 'Lorem Ipsum', null)
insert into Products values (N'Бежевая шуба', 4200, 5, 'img-c-3.png', 2, 1, 'Lorem Ipsum', 'Lorem Ipsum', null)
insert into Products values (N'Синяя парка', 2900, 2, 'img-c-4.png', 1, 2, 'Lorem Ipsum', 'Lorem Ipsum', 'new')

insert into Products values (N'Белая куртка', 2900, 1, 'img-c-1.png', 1, 3, 'Lorem Ipsum', 'Lorem Ipsum', 'new')
insert into Products values (N'Синее пальто', 3150, 4, 'img-c-2.png', 4, 2, 'Lorem Ipsum', 'Lorem Ipsum', null)
insert into Products values (N'Белая куртка', 2900, 1, 'img-c-1.png', 1, 3, 'Lorem Ipsum', 'Lorem Ipsum', 'new')
insert into Products values (N'Синее пальто', 3150, 4, 'img-c-2.png', 4, 2, 'Lorem Ipsum', 'Lorem Ipsum', null)
insert into Products values (N'Бежевая шуба', 4200, 5, 'img-c-3.png', 2, 1, 'Lorem Ipsum', 'Lorem Ipsum', null)
insert into Products values (N'Синяя парка', 2900, 2, 'img-c-4.png', 1, 2, 'Lorem Ipsum', 'Lorem Ipsum', 'new')
insert into Products values (N'Белая куртка', 2900, 1, 'img-c-1.png', 1, 3, 'Lorem Ipsum', 'Lorem Ipsum', 'new')
insert into Products values (N'Синее пальто', 3150, 4, 'img-c-2.png', 4, 2, 'Lorem Ipsum', 'Lorem Ipsum', null)

insert into Sizes values (1, 'XXS', 40)
insert into Sizes values (2, 'XS', 42)
insert into Sizes values (3, 'S', 44)
insert into Sizes values (4, 'M', 46)
insert into Sizes values (5, 'L', 48)

insert into Colors values (1, 'Beige', '#F1DDAA', N'Кофе с молоком меланж')
insert into Colors values (2, 'Navy', '#6F83A4', N'Синий')
insert into Colors values (3, 'White', '#FFFFFF', N'Белый')

insert into Categories values (1, N'Верхняя одежда')
insert into Categories values (2, N'Шубы')
insert into Categories values (3, N'Тренчи')
insert into Categories values (4, N'Пальто')
insert into Categories values (5, N'Пуховики и жилеты')
insert into Categories values (6, N'Костюмы')
insert into Categories values (7, N'Жакеты')
insert into Categories values (8, N'Платья')
insert into Categories values (9, N'Рубашки и блузы')
insert into Categories values (10, N'Юбки')
insert into Categories values (11, N'Футболки и топы')
insert into Categories values (12, N'Аксессуары')



insert into Products values (N'Белая куртка', 2900, 1, 'img-c-1.png', 1, 3, 'Lorem Ipsum', 'Lorem Ipsum', 'New')
insert into Products values (N'Синее пальто', 3150, 4, 'img-c-2.png', 4, 2, 'Lorem Ipsum', 'Lorem Ipsum')
insert into Products values (N'Бежевая шуба', 4200, 5, 'img-c-3.png', 2, 1, 'Lorem Ipsum', 'Lorem Ipsum')
insert into Products values (N'Синяя парка', 2900, 2, 'img-c-4.png', 1, 2, 'Lorem Ipsum', 'Lorem Ipsum', 'New')

insert into Products values (N'Белая куртка', 2900, 1, 'img-c-1.png', 1, 3, 'Lorem Ipsum', 'Lorem Ipsum', 'New')
insert into Products values (N'Синее пальто', 3150, 4, 'img-c-2.png', 4, 2, 'Lorem Ipsum', 'Lorem Ipsum')
insert into Products values (N'Белая куртка', 2900, 1, 'img-c-1.png', 1, 3, 'Lorem Ipsum', 'Lorem Ipsum', 'New')
insert into Products values (N'Синее пальто', 3150, 4, 'img-c-2.png', 4, 2, 'Lorem Ipsum', 'Lorem Ipsum')
insert into Products values (N'Бежевая шуба', 4200, 5, 'img-c-3.png', 2, 1, 'Lorem Ipsum', 'Lorem Ipsum')
insert into Products values (N'Синяя парка', 2900, 2, 'img-c-4.png', 1, 2, 'Lorem Ipsum', 'Lorem Ipsum', 'New')
insert into Products values (N'Белая куртка', 2900, 1, 'img-c-1.png', 1, 3, 'Lorem Ipsum', 'Lorem Ipsum', 'New')
insert into Products values (N'Синее пальто', 3150, 4, 'img-c-2.png', 4, 2, 'Lorem Ipsum', 'Lorem Ipsum')



insert into Products values (N'Белая куртка', 2900, 1, '~/images/img-c-1.png', 1, 3, 'Lorem Ipsum', 'Lorem Ipsum')
insert into Products values (N'Синее пальто', 3150, 4, '~/images/img-c-2.png', 4, 2, 'Lorem Ipsum', 'Lorem Ipsum')
insert into Products values (N'Бежевая шуба', 4200, 5, '~/images/img-c-3.png', 2, 1, 'Lorem Ipsum', 'Lorem Ipsum')
insert into Products values (N'Синяя парка', 2900, 2, '~/images/img-c-4.png', 1, 2, 'Lorem Ipsum', 'Lorem Ipsum')

insert into Products values (N'Белая куртка', 2900, 1, '~/images/img-c-1.png', 1, 3, 'Lorem Ipsum', 'Lorem Ipsum')
insert into Products values (N'Синее пальто', 3150, 4, '~/images/img-c-2.png', 4, 2, 'Lorem Ipsum', 'Lorem Ipsum')
insert into Products values (N'Белая куртка', 2900, 1, '~/images/img-c-1.png', 1, 3, 'Lorem Ipsum', 'Lorem Ipsum')
insert into Products values (N'Синее пальто', 3150, 4, '~/images/img-c-2.png', 4, 2, 'Lorem Ipsum', 'Lorem Ipsum')
insert into Products values (N'Бежевая шуба', 4200, 5, '~/images/img-c-3.png', 2, 1, 'Lorem Ipsum', 'Lorem Ipsum')
insert into Products values (N'Синяя парка', 2900, 2, '~/images/img-c-4.png', 1, 2, 'Lorem Ipsum', 'Lorem Ipsum')
insert into Products values (N'Белая куртка', 2900, 1, '~/images/img-c-1.png', 1, 3, 'Lorem Ipsum', 'Lorem Ipsum')
insert into Products values (N'Синее пальто', 3150, 4, '~/images/img-c-2.png', 4, 2, 'Lorem Ipsum', 'Lorem Ipsum')
