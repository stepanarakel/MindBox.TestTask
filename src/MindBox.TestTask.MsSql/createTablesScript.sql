create schema mind_box;
create table mind_box.products
(
    id   INT NOT NULL,
    name NVARCHAR(100) NOT NULL,
    CONSTRAINT PK_products PRIMARY KEY NONCLUSTERED (id)
);
create table mind_box.categories
(
    id   INT NOT NULL,
    name NVARCHAR(100) NOT NULL,
    CONSTRAINT PK_categories PRIMARY KEY NONCLUSTERED (id)
);
create table mind_box.products_categories
(
    id          INT NOT NULL,
    product_id  INT NOT NULL,
    category_id INT NOT NULL,
    CONSTRAINT PK_products_categories PRIMARY KEY NONCLUSTERED (id),
    CONSTRAINT FK_pc_procduct FOREIGN KEY (product_id)
        REFERENCES mind_box.products (id)
        ON DELETE CASCADE,
    CONSTRAINT FK_pc_category FOREIGN KEY (category_id)
        REFERENCES mind_box.categories (id)
        ON DELETE CASCADE
);

insert into mind_box.products
    (id, name)
values (1, N'кола'),
       (2, N'вода'),
       (3, N'лимонад'),
       (4, N'сухарики');

insert into mind_box.categories
    (id, name)
values (1, N'напиток'),
       (2, N'газировка');

insert into mind_box.products_categories
    (id, product_id, category_id)
values (1, 1, 1),
       (2, 1, 2),
       (3, 2, 1),
       (4, 3, 1),
       (5, 3, 2);