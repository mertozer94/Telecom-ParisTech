select tablespace_name, table_name from user_tables;


1)Number of orders for each of the following groups: ship_city, (ship_city, employee), employee and in total. Display the
result by increasing order of employee then (for ties) ship_city

SELECT o.EMPLOYEE_ID, o.SHIP_CITY, COUNT(*) AS nborders
FROM ORDERS o
GROUP BY CUBE (o.SHIP_CITY,o.EMPLOYEE_ID)
ORDER BY o.EMPLOYEE_ID,  o.SHIP_CITY;

2) add on a fourth column a string indicating the level at which the group is summarized (city, employee, city-empl, or global)

SELECT o.EMPLOYEE_ID, o.SHIP_CITY, COUNT(*) AS nborders, DECODE(GROUPING_ID(o.SHIP_CITY,o.EMPLOYEE_ID ), 1, 'city', 2, 'emply', 3, 'global', 'city-emply') 
summary_level
FROM ORDERS o
GROUP BY CUBE (o.SHIP_CITY,o.EMPLOYEE_ID)
ORDER BY o.EMPLOYEE_ID,  o.SHIP_CITY;

3) For each customer country, the list of orders displayed by chronological order (oldest appearing first, most recent
appearing last. . . ) indicating for each order:
add customer

SELECT o.SHIP_COUNTRY AS country, o.ORDER_ID as corder_id, SUM(od.UNIT_PRICE * od.QUANTITY * (1-od.DISCOUNT)) as price, RANK () OVER (PARTITION BY o.SHIP_COUNTRY ORDER BY(SUM(od.UNIT_PRICE * od.QUANTITY * (1-od.DISCOUNT))) DESC) AS ranking
FROM ORDERS o, ORDER_DETAILS od
WHERE o.ORDER_ID = od.ORDER_ID
GROUP BY o.SHIP_COUNTRY, o.order_id;

4)


