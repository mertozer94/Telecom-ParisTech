1) number of customers per country

SELECT COUNTRY,COUNT(*)
FROM CUSTOMERS
GROUP BY COUNTRY;

2) number of orders per country,(country and city), and in total. Results are ordered by alphabetical order on country then city

SELECT ORDERS.SHIP_COUNTRY,ORDERS.SHIP_CITY, COUNT(*) AS NBORDERS
FROM ORDERS 
GROUP BY ROLLUP (ORDERS.SHIP_COUNTRY,ORDERS.SHIP_CITY)
ORDER BY ORDERS.SHIP_COUNTRY,ORDERS.SHIP_CITY;


3) number of orders and quantity of items shipped (according to order details) for each pair of Customer country and Supplier country. Order result by customer country first, then supplier country


SELECT c.COUNTRY AS C_COUNTRY, s.COUNTRY AS S_COUNTRY, COUNT(DISTINCT o.ORDER_ID) AS NBORDER, SUM(od.QUANTITY) AS QUANTITY 
FROM CUSTOMERS c, ORDERS o, ORDER_DETAILS od, PRODUCTS p, SUPPLIERS s 
WHERE c.CUSTOMER_ID = o.CUSTOMER_ID AND o.ORDER_ID = od.ORDER_ID AND od.PRODUCT_ID = p.PRODUCT_ID AND p.SUPPLIER_ID = s.SUPPLIER_ID 
GROUP BY (c.COUNTRY, s.COUNTRY) 
ORDER BY c.COUNTRY, s.COUNTRY;


4) number of orders and quantity for all the cube levels when we only consider Customer and Supplier geography, at the top and country levels only. (i.e., same as before but add totals over each kind of country, and grand total).

SELECT c.COUNTRY AS C_COUNTRY, s.COUNTRY AS S_COUNTRY, COUNT(DISTINCT o.ORDER_ID) AS NBORDER, SUM(od.QUANTITY) AS QUANTITY 
FROM CUSTOMERS c, ORDERS o, ORDER_DETAILS od, PRODUCTS p, SUPPLIERS s 
WHERE c.CUSTOMER_ID = o.CUSTOMER_ID AND o.ORDER_ID = od.ORDER_ID AND od.PRODUCT_ID = p.PRODUCT_ID AND p.SUPPLIER_ID = s.SUPPLIER_ID 
GROUP BY CUBE (c.COUNTRY, s.COUNTRY) ;


5) total price (Quantity* UnitPrice) of orders with french suppliers, for each country, region and city. The country must be displayed whenever the region is, and likewise the region whenever the city is. No grand total should be displayed. Propose 2 solutions; each based on a different function to extend GROUP BY.

SELECT o.SHIP_COUNTRY, o.SHIP_REGION, o.SHIP_CITY, SUM(od.QUANTITY*od.UNIT_PRICE) AS TOTAL
FROM ORDERS o, ORDER_DETAILS od, SUPPLIERS s, PRODUCTS p
WHERE s.COUNTRY = 'France' AND o.ORDER_ID = od.ORDER_ID AND od.PRODUCT_ID = p.PRODUCT_ID AND p.SUPPLIER_ID = s.SUPPLIER_ID
GROUP BY o.SHIP_COUNTRY, ROLLUP (o.SHIP_REGION,o.SHIP_CITY);


6) modify your query from question 2 so that the string ’whole country’ is displayed instead of NULL on every row that aggregates all cities of a single country.

SELECT ORDERS.SHIP_COUNTRY,CASE WHEN (GROUPING(ORDERS.SHIP_CITY) = 1 AND GROUPING (ORDERS.SHIP_COUNTRY) = 0) THEN 'WHOLE COUNTRY' ELSE ORDERS.SHIP_CITY END, COUNT(*) AS NBORDERS
FROM ORDERS 
GROUP BY ROLLUP (ORDERS.SHIP_COUNTRY,ORDERS.SHIP_CITY)
ORDER BY ORDERS.SHIP_COUNTRY,ORDERS.SHIP_CITY;


1.4)
	1)number of orders per country and city on one column, together with total number of orders for the country, and maximal number of orders over the cities in this country on other columns. 

SELECT SHIP_COUNTRY, SHIP_CITY, COUNT(*) AS NBORDERS,
SUM(COUNT(*)) OVER(PARTITION BY SHIP_COUNTRY) AS NBORDCTY,
MAX(COUNT(*)) OVER(PARTITION BY SHIP_COUNTRY) AS NBORMAXCTY
FROM ORDERS
GROUP BY SHIP_COUNTRY,SHIP_CITY
ORDER BY SHIP_COUNTRY,SHIP_CITY;

	2)cities ranked within countries by number of orders, displaying number of orders and rank. There should not be any gaps in the ranks even in presence of ties.

SELECT SHIP_COUNTRY, SHIP_CITY, COUNT(*) AS NBORDERS,
DENSE_RANK() OVER(PARTITION BY SHIP_COUNTRY ORDER BY COUNT(*)) AS RANK
FROM ORDERS
GROUP BY SHIP_COUNTRY,SHIP_CITY
ORDER BY SHIP_COUNTRY,SHIP_CITY;

	3) add to query 2 the percentage of the total number of orders reached by each city within a country. ?

SELECT o.SHIP_COUNTRY, o.SHIP_CITY, COUNT(DISTINCT o.ORDER_ID) AS NBORDERS,
DENSE_RANK() OVER(PARTITION BY SHIP_COUNTRY ORDER BY COUNT(*)) AS RANK,
SUM(COUNT (*)) OVER(PARTITION BY o.SHIP_CITY) / SUM(COUNT (*)) OVER(PARTITION BY o.SHIP_COUNTRY) AS PERCENTAGE
FROM ORDERS o, ORDER_DETAILS od
WHERE o.ORDER_ID = od.ORDER_ID
GROUP BY o.SHIP_COUNTRY,o.SHIP_CITY
ORDER BY o.SHIP_COUNTRY,o.SHIP_CITY;

// count*/ sum(count*) over partition 
or ratio to report

DENSE_RANK() OVER (PARTITION BY SHIP_COUNTRY ORDER BY COUNT(*) 
RANK RATIO_TO_REPORT(COUNT(*))
OVER (PARTITION BY SHIP_COUNTRY) AS PERCENT

	4) total price for each order, filtering out all the orders whose price is higher than 110% of the preceding order (defining the preceding OrderID as the largest among smaller OrderID) (you may nest queries).

SELECT ORDER_ID, LAG(SUM(UNIT_PRICE*QUANTITY)) OVER(ORDER BY ORDER_ID) as price
FROM ORDER_DETAILS
GROUP BY ORDER_ID;

	5) product sold in highest quantity per year, with the quantity. Propose one answer using windowing functions
and another that does not (you may nest queries).

WITH temp AS(SELECT EXTRACT(YEAR FROM o.ORDER_DATE) as YEAR, p.PRODUCT_NAME, SUM(QUANTITY) qty, MAX(SUM(QUANTITY) OVER(PARTITION BY EXTRACT())
FROM ORDERS o, ORDER_DETAILS od, PRODUCTS p
WHERE o.ORDER_ID = od.ORDER_ID AND od.PRODUCT_ID = p.PRODUCT_ID
GROUP BY EXTRACT(YEAR FROM o.ORDER_DATE) p.PRODUCT_ID, p.PRODUCT_NAME
)
SELECT YEAR, PRODUCT_NAME, qty
FROM TEMP
WHERE qry = mxqt;


SELECT EXTRACT(YEAR FROM o.ORDER_DATE) AS year, p.PRODUCT_NAME AS pname
FROM ORDERS o, PRODUCTS p, ORDER_DETAILS od
WHERE o.ORDER_ID = od.ORDER_ID AND od.PRODUCT_ID = p.PRODUCT_ID
GROUP BY EXTRACT(YEAR FROM o.ORDER_DATE);

SELECT EXTRACT(YEAR FROM o.ORDER_DATE) AS year
FROM ORDERS o;
4) Hierarchies
	1.5)Use a hierarchical query on the DUAL table to create a table listing integers from 1 to 60.

WITH T(u) AS			
(SELECT 0 FROM DUAL
UNION ALL 
SELECT u+1 FROM T
WHERE u<60
)
SELECT u FROM T;

	1.6)Generate the list of the next 30 months (format: MON-YY) starting from today.

WITH 
t(u, month) AS
(
SELECT 1 u, to_date('oct17','monYY') month
FROM DUAL
UNION ALL
SELECT t.(u+1) u, t.(ADD_MONTHS(month,1)) month
FROM t
WHERE t.u < 30
)
SELECT t.u, t.(to_date(month,'monYY'))
FROM T;

	1.7)Write a query to display the supervisor of each employee and the employee’s distance to its topmost manager.
Modify the query to compute results through depth first search. Modify the data to introduce a cycle in the
supervisor relationship. Evaluate the inpact of such cycles on the query.









