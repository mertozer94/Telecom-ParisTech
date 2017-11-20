select o.employee_id empl_id,
	o.ship_city ship_city,
	count(*) nborder
from orders o
group by cube(o.employee_id, o.ship_city)
order by o.employee_id, o.ship_city;

--

select o.employee_id empl_id,
	o.ship_city ship_city,
	count(*) nborder,
	case grouping_id(o.employee_id, o.ship_city)
	 when 3 then 'global'
         when 2 then 'city'
	 when 1 then 'employee'
	 when 0 then 'city-empl'
	end as summary_level	
from orders o
group by cube(o.employee_id, o.ship_city)
order by o.employee_id, o.ship_city;

-- bonus

select o.employee_id empl_id,
	o.ship_city ship_city,
	count(*) nborder,
	case grouping_id(o.employee_id, o.ship_city)
	 when 3 then 'global'
         when 2 then 'city'
	 when 1 then 'employee'
	 when 0 then 'city-empl'
	end as summary_level	
from orders o
group by cube(o.employee_id, o.ship_city)
having not(grouping_id(o.employee_id, o.ship_city) = 0 and
       count(*) < 5)
order by o.employee_id, o.ship_city;

--

select  c.country country,
	o.order_id order_id,
	sum(od.quantity * od.unit_price * (1- od.discount)) price,
        dense_rank() over(partition by c.country 
                          order by sum(od.quantity * od.unit_price * (1- od.discount))
                          desc) as ranking
from orders o, order_details od, customers c
where o.order_id = od.order_id and
      c.customer_id = o.customer_id
group by c.country,o.order_id
order by c.country,o.order_id;

-- bonus
with t(country, order_id, price, ranking) as
(
	select  c.country country,
		o.order_id order_id,
		sum(od.quantity * od.unit_price * (1- od.discount)) price,
		dense_rank() over(partition by c.country 
		                  order by sum(od.quantity * od.unit_price * (1- od.discount))
		                  desc) as ranking
	from orders o, order_details od, customers c
	where o.order_id = od.order_id and
	      c.customer_id = o.customer_id
	group by c.country,o.order_id
	order by c.country,o.order_id
)
select t.country, t.order_id, t.price, t.ranking, o.order_date
from t, orders o
where t.order_id = o.order_id
order by t.country,o.order_date;

--

with t(n, u_n) as
(
		select 0 n, 1 u_n 
		from dual 
	union all
		select t.n + 1 n, t.u_n + (power(-1, t.n + 1) / ( (2 * t.n + 3) * power(3,t.n + 1) )) u_n
		from t
		where t.n < 20
)
select t.u_n * sqrt(12) as result_Pi
from t
where t.n = 20;


