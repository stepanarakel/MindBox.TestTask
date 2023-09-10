select p.name as 'Имя продукта', c.name as 'Имя категории'
from mind_box.products p
         left join mind_box.products_categories pc
                   on pc.product_id = p.id
         left join mind_box.categories c
                   on c.id = pc.category_id