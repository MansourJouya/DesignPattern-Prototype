using System;

/// <summary>
/// Interface for objects that can be cloned.
/// </summary>
public interface IPrototype
{
    /// <summary>
    /// Creates a deep copy of the current object.
    /// </summary>
    /// <returns>A deep copy of the current object.</returns>
    IPrototype Clone();
}

/// <summary>
/// A concrete class representing a complex object that implements the IPrototype interface.
/// </summary>
public class Product : IPrototype
{
    public string Name { get; set; }
    public decimal Price { get; set; }

    /// <summary>
    /// Constructor for initializing the product.
    /// </summary>
    /// <param name="name">The name of the product.</param>
    /// <param name="price">The price of the product.</param>
    public Product(string name, decimal price)
    {
        Name = name;
        Price = price;
    }

    /// <summary>
    /// Creates a deep copy of the current product.
    /// </summary>
    /// <returns>A new Product instance with the same values.</returns>
    public IPrototype Clone()
    {
        return new Product(this.Name, this.Price);
    }

    /// <summary>
    /// Displays the details of the product.
    /// </summary>
    public void DisplayProductInfo()
    {
        Console.WriteLine($"Product Name: {Name}, Product Price: ${Price}");
    }
}

/// <summary>
/// The main class to demonstrate the Prototype Design Pattern.
/// </summary>
public class Program
{
    /// <summary>
    /// The main entry point of the program.
    /// </summary>
    public static void Main(string[] args)
    {
        // Create an original product instance.
        Product originalProduct = new Product("Smartphone", 799.99m);
        Console.WriteLine("Original Product:");
        originalProduct.DisplayProductInfo();

        // Clone the original product.
        Product clonedProduct = (Product)originalProduct.Clone();
        Console.WriteLine("\nCloned Product:");
        clonedProduct.DisplayProductInfo();

        // Modify the cloned product to show it is a separate object.
        clonedProduct.Name = "Smartphone Pro";
        clonedProduct.Price = 999.99m;

        // Display both products to verify that they are distinct objects.
        Console.WriteLine("\nModified Cloned Product:");
        clonedProduct.DisplayProductInfo();
        Console.WriteLine("\nOriginal Product after modification of clone:");
        originalProduct.DisplayProductInfo();
    }
}
