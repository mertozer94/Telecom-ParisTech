import pandas as pd
import numpy as np
import matplotlib.pyplot as plt
csv_file = pd.read_csv('/home/mert/Downloads/SalesJan2009.csv')
sales = csv_file[['Country','Product','Price']]
print sales.dtypes
category_group=sales.groupby(['Country','Product']).sum()
print category_group.unstack()
my_plot = category_group.unstack().plot(kind='bar',stacked=True,title="Total Sales by Countries",figsize=(9, 7))
my_plot.set_xlabel("Countries")
my_plot.set_ylabel("Sales")
my_plot.legend(["Product1","Product2","Product3"], loc=9,ncol=3)
plt.show()

