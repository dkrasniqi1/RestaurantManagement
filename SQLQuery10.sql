ALTER TABLE Products DROP COLUMN prod_unit;


ALTER TABLE Products
ADD prod_unit NVARCHAR(50);

SELECT * FROM products;