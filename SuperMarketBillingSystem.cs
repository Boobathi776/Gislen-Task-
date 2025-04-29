using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment;

internal class Product 
{ 
    public string ProductName { get; set; }
    public int ProductId { get; set; }
    public decimal ProductPrice { get; set; }
    //public int Quantity { get; set; }
    public Product(string name, decimal price, int productId)
    {
        ProductName = name;
        ProductPrice = price;
        ProductId = productId;
        //Quantity = quantity;
    }
}

internal class SuperMarketBillingSystem
{
    List<Product> products = new List<Product>();
    Dictionary<string , int[]> selectedProduct = new Dictionary<string, int[]>();
    public void GetProduct() {
        string product;
        int productId=0;
        bool isTrue;
        decimal price=0;
        do { 
        Console.Write("Enter the product name or type \"exit\" : ");
        product = Console.ReadLine() ?? "Invalid product";
            if (product != "exit")
            {
                
                Again1:
                    Console.Write("Enter product Id : ");
                    isTrue = int.TryParse(Console.ReadLine(), out productId);
                    if (isTrue)
                    {
                        Console.Write("Enter product price : ");
                Again2:
                    bool isSuccess = decimal.TryParse(Console.ReadLine(), out price);
                        if (isSuccess)
                        {
                        products.Add(new Product(product, price, productId));
                        Console.WriteLine("the product is added to the list....");
                        }
                        else
                        {
                            Console.Write("Enter a valid price :  ");
                            goto Again2;
                        }
                    }
                    else
                    {
                    Console.WriteLine("Enter a valid product Id : ");
                        goto Again1;
                    }
                }
          
        } while (product != "exit");
    }


    public void Purchasing()
    {
        GetProduct();
        ShowProduct(products);
        int productId = 0;
        do
        {
            Console.Write("Enter the product Id to purchase or enter 0 to exit : ");
            string productName;
            int price = 0;
            bool isTrue = int.TryParse(Console.ReadLine(), out productId);
            if (isTrue && productId != 0)
            {
                foreach (var product in products)
                {
                    if (product.ProductId == productId)
                    {
                        productName = product.ProductName;
                        price = (int)product.ProductPrice;
                        Console.Write("Enter the quantity : ");
                        int quantity = 0;
                    Again:
                        bool isSuccess = int.TryParse(Console.ReadLine(), out quantity);
                        if (isSuccess && quantity > 0)
                        {
                            selectedProduct.Add(productName, new int[] { price, quantity });
                            Console.WriteLine($"Product {product.ProductName} added to cart with quantity {quantity}");
                        }
                        else
                        {
                            Console.Write("Enter a valid quantity : ");
                            goto Again;
                        }
                    }
                }

            }
        } while (productId != 0);

        GenerateBill(selectedProduct);
        Console.WriteLine("Thank you for shopping with us!");
        Console.Write("Enter if have Extra bill to generate then enter 'y' : ");
        string extraBill = Console.ReadLine() ?? "Invalid input";
        if(extraBill == "y")
        Purchasing();

    }

    public void GenerateBill(Dictionary<string, int[]> selectedProduct)
    {
        Console.WriteLine("Bill : ");
        Console.WriteLine("Product Name\tPrice\tQuantity\tTotal");
        decimal total = 0;
        foreach (var product in selectedProduct)
        {
            decimal price = product.Value[0];
            int quantity = product.Value[1];
            decimal totalPrice = price * quantity;
            total += totalPrice;
            Console.WriteLine($"{product.Key}\t - {price} X \t{quantity}\t = {totalPrice}");
        }
        Console.WriteLine($"Total Amount : {total}");
    }
    public void ShowProduct(List<Product> products)
    {
        Console.WriteLine("Product List : ");
        foreach (var product in products)
        {
            Console.WriteLine($"Product Id : {product.ProductId} , Product Name : {product.ProductName}, Product Price : {product.ProductPrice}");
        }
    }

}
