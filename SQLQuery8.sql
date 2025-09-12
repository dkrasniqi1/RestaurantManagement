UPDATE Products SET prod_stock = 0 WHERE prod_stock IS NULL;

UPDATE Products SET quantity_sold = 0 WHERE quantity_sold IS NULL;