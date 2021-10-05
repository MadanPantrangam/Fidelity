using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace SampleWebApp
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
    }

    public static class Products
    {
        public static List<Item> AllProducts => getProducts();
        private static List<Item> getProducts()
        {
           var _products = new List<Item>();
         XDocument doc = XDocument.Load("C:/Users/6133094/OneDrive - Fidelity National Financial/Desktop/FNF Trainning/Assignment Programms/Day01/SampleWebApp/Product.xml");
            var elements = from element in doc.Descendants("Item")
                           select new Item
                           {
                               Id = int.Parse(element.Element("ItemId").Value),
                               Name = element.Element("ItemName").Value,
                               Price = int.Parse(element.Element("ItemPrice").Value),
                               Quantity = int.Parse(element.Element("ItemQuantity").Value)
                           };
            return elements.ToList();
        }

    }
}

