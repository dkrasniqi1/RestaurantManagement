ALTER TABLE products
ADD quantity_sold INT DEFAULT 0;
GO

SELECT prod_id, prod_name, prod_stock, quantity_sold, prod_status
FROM products;
GO