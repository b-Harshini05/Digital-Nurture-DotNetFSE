using System;

class Product
{
    public int ProductId;
    public string ProductName;
    public string Category;

    public Product(int id, string name, string category)
    {
        ProductId = id;
        ProductName = name;
        Category = category;
    }
}

class SearchOperations
{
    // Linear Search
    static Product LinearSearch(Product[] products, int id)
    {
        foreach (Product p in products)
        {
            if (p.ProductId == id)
                return p;
        }
        return null;
    }

    // Binary Search
    static Product BinarySearch(Product[] products, int id)
    {
        int left = 0;
        int right = products.Length - 1;

        while (left <= right)
        {
            int mid = (left + right) / 2;

            if (products[mid].ProductId == id)
                return products[mid];

            if (products[mid].ProductId < id)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return null;
    }

    static void Main(string[] args)
    {
        Product[] products =
        {
            new Product(101,"Laptop","Electronics"),
            new Product(102,"Phone","Electronics"),
            new Product(103,"Shoes","Fashion"),
            new Product(104,"Watch","Accessories"),
            new Product(105,"Book","Education")
        };

        Console.Write("Enter Product ID to Search: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nLinear Search Result:");

        Product result1 = LinearSearch(products, id);

        if (result1 != null)
            Console.WriteLine($"{result1.ProductId} {result1.ProductName} {result1.Category}");
        else
            Console.WriteLine("Product Not Found");

        Console.WriteLine("\nBinary Search Result:");

        Product result2 = BinarySearch(products, id);

        if (result2 != null)
            Console.WriteLine($"{result2.ProductId} {result2.ProductName} {result2.Category}");
        else
            Console.WriteLine("Product Not Found");
    }
}