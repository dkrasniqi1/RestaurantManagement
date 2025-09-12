INSERT INTO products (prod_id, prod_name, prod_type, prod_stock, prod_price, prod_status, prod_image, date_insert, date_delete)
VALUES (@prodID, @prodName, @prodType, @prodStock, @prodPrice, @prodStatus, @prodImage, @dateInsert, NULL)


SELECT * FROM products

CREATE TABLE orders
(
	id INT PRIMARY KEY IDENTITY(1,1),
	customer_id INT NULL,
	prod_id VARCHAR(MAX) NULL,
	prod_name VARCHAR(MAX) NULL,
	prod_type VARCHAR(MAX) NULL,
	prod_price FLOAT NULL,
	order_date DATE NULL,
	delete_order DATE NULL

)
SELECT * FROM orders

ALTER TABLE orders
ADD delete_order DATE NULL;

ALTER TABLE orders
ADD qty INT NULL;

CREATE TABLE customers
(
	id INT PRIMARY KEY IDENTITY(1,1),
	customer_id INT NULL,
	total_price FLOAT NULL,
	date DATE NULL
)
SELECT * FROM customers

SELECT * FROM orders WHERE customer_id =1


ALTER TABLE customers
ADD amount FLOAT NULL

ALTER TABLE customers
DROP COLUMN amount;

ALTER TABLE customers
ADD change FLOAT NULL

ALTER TABLE customers
ADD users VARCHAR(MAX) NULL