CREATE TABLE orders (
    id INT IDENTITY(1,1) PRIMARY KEY,
    customer_id INT NOT NULL,
    prod_id NVARCHAR(50) NOT NULL,
    prod_name NVARCHAR(100) NOT NULL,
    prod_type NVARCHAR(50),
    qty INT NOT NULL,
    prod_price FLOAT NOT NULL,
    order_date DATE NOT NULL
);
SELECT * FROM orders

