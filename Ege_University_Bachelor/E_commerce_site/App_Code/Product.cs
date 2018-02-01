using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Product
/// </summary>
public class Product
{
    
    public int ProductID { get; set; }
    public string Name { get; set; }
    public string Desc { get; set; }
    public string Supplier { get; set; }
    public int UnitsInStock { get; set; }
    public double Price { get; set; }
    
}