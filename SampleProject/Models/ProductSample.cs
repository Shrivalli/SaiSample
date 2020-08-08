using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleProject.Models
{
    public class ProductSample
    {
        public int Pid { get; set; }
        public string Pname { get; set; }
        public float Price { get; set; }
        public DateTime dom { get; set; }
        public string Supplier { get; set; }
        public int Qty { get; set; }

        public ProductSample()
        {

        }

        public ProductSample(int pid,string pname,float price, DateTime dom,string sup,int qty)
        {
            Pid = pid;
            Pname = pname;
            Price = price;
            this.dom = dom;
            Supplier = sup;
            Qty = qty;
        }

        public IList<ProductSample> getAllProducts()
        {
            List<ProductSample> products = new List<ProductSample>();
            products.Add(new ProductSample(1, "Mobiles", 98.7f, Convert.ToDateTime("5/6/2010"), "Cavinkare", 5));
            products.Add(new ProductSample(2, "Pencil", 87000, Convert.ToDateTime("5/7/2012"), "Apple", 5));
            products.Add(new ProductSample(3, "Mobiles", 8766f, Convert.ToDateTime("5/6/2010"), "HP", 7));
            products.Add(new ProductSample(4, "Computer", 9887f, Convert.ToDateTime("5/9/2010"), "Acer", 20));
            products.Add(new ProductSample(5, "Biscuits", 9807f, Convert.ToDateTime("5/6/2012"), "Apple", 56));
            products.Add(new ProductSample(6, "Mobiles", 67000f, Convert.ToDateTime("5/6/2010"), "Lenovo", 89));
            products.Add(new ProductSample(7, "Pencil", 2300f, Convert.ToDateTime("5/2/2017"), "HP", 21));
            products.Add(new ProductSample(8, "Mobiles", 12000f, Convert.ToDateTime("5/6/2010"), "Acer", 19));
            products.Add(new ProductSample(9, "Pencil", 1290f, Convert.ToDateTime("5/6/2017"), "Cavinkare", 90));
            products.Add(new ProductSample(10, "Mobiles", 9837f, Convert.ToDateTime("5/4/2013"), "Acer", 17));
            products.Add(new ProductSample(11, "Biscuits", 128.7f, Convert.ToDateTime("5/6/2019"), "HP", 11));
            products.Add(new ProductSample(12, "Computer", 1247f, Convert.ToDateTime("5/6/2020"), "Brittania", 5));
            return products;
        }
    }
}