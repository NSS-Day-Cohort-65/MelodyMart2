// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.WriteLine(@"  \  |      |           |         \  |            |
 |\/ |  _ \ |  _ \   _` | |   |  |\/ |  _` |  __| __|
 |   |  __/ | (   | (   | |   |  |   | (   | |    |
_|  _|\___|_|\___/ \__,_|\__, | _|  _|\__,_|_|   \__|
                         ____/                        ");

List<ProductType> productTypes = new List<ProductType>()
{
    new ProductType()
    {
        Title = "Instrument",
        Id = 1
    },
    new ProductType()
    {
        Title = "Audio Equipment",
        Id = 2
    },
    new ProductType()
    {
        Title = "Instrument Equipment",
        Id = 3
    },
    new ProductType()
    {
        Title = "Instrument Maintenance",
        Id = 4
    }
};

List<Product> products = new List<Product>()
{
    new Product()
    {
        Name = "Ibanez RGD Electric 6 String Guitar",
        Price = 535.00M,
        DateAdded = new DateTime(2022,5,20),
        DateSold = null,
        ProductTypeId = 1
    },
    new Product()
    {
        Name = "Fender Stratocaster",
        Price = 999.00M,
        DateAdded = new DateTime(2020,8,26),
        DateSold = null,
        ProductTypeId = 1
    },
    new Product()
    {
        Name = "Ludwig Backbeat 22x16 BassDrum Metallic Silver",
        Price = 67.08M,
        DateAdded = new DateTime(2023,1,20),
        DateSold = null,
        ProductTypeId = 1
    },
    new Product()
    {
        Name = "Fender Aerodyne Bass",
        Price = 910.00M,
        DateAdded = new DateTime(2020,1,24),
        DateSold = null,
        ProductTypeId = 1
    },
    new Product()
    {
        Name = "Taylor GA Acoustic Guitar",
        Price = 3299.00M,
        DateAdded = new DateTime(2023,3,10),
        DateSold = null,
        ProductTypeId = 1
    },
    new Product()
    {
        Name = "Samson Q2U Microphone Set",
        Price = 110.00M,
        DateAdded = new DateTime(2023,8,15),
        DateSold = new DateTime(2023,10,30),
        ProductTypeId = 2
    },
    new Product()
    {
        Name = "Korg Z1 88 Key",
        Price = 825.00M,
        DateAdded = new DateTime(2018,2,14),
        DateSold = null,
        ProductTypeId = 1
    },
    new Product()
    {
        Name = "Music Nomad Polish",
        Price = 8.00M,
        DateAdded = new DateTime(2023,3,14),
        DateSold = null,
        ProductTypeId = 4,
    },
    new Product{
        Name = "Line 6 Vetta II",
        Price = 699.00M,
        DateAdded = new DateTime(2010,2,10),
        DateSold = null,
        ProductTypeId = 3
    },
        new Product()
    {
        Name = "Music Nomad Drum Detailer",
        Price = 10.99M,
        DateAdded = new DateTime(2018,2,14),
        DateSold = new DateTime(2023,02,28),
        ProductTypeId = 4
    },
    new Product()
    {
        Name = "FL Studio",
        Price = 99.00M,
        DateAdded = new DateTime(2023,1,11),
        DateSold = null,
        ProductTypeId = 2
    }
};


string greeting = @"Welcome to Melody Mart
Get your shit and get out";

Console.WriteLine(greeting);
string choice = null;
while (choice != "0")
{
    Console.WriteLine(@"Choose an option:
0. Exit
1. View all products
2. View products by type
3. Purchase a product
4. Add a new product
5. Remove from inventory
6. View product details
7. Update product info
8. View inventory statistics");
    choice = Console.ReadLine();

    switch (choice)
    {
        case "0":
            Console.Clear();
            Console.WriteLine("Seeya shithead");
            break;
        case "1":
            Console.Clear();
            ViewAllProducts();
            TheCleanerUpper();
            break;
        case "2":
            Console.Clear();
            ViewProductsByType();
            TheCleanerUpper();
            break;
        case "3":
            throw new NotImplementedException("Feature not available, dumbass");
        case "4":
            throw new NotImplementedException("Feature not available, dumbass");
        case "5":
            Console.Clear();
            RemoveProduct();
            break;
        case "6":
            throw new NotImplementedException("Feature not available, dumbass");
        case "7":
            throw new NotImplementedException("Feature not available, dumbass");
        case "8":
            throw new NotImplementedException("Feature not available, dumbass");

        default:
            Console.Clear();
            Console.WriteLine("Pick an actual option, shithead. Press any key to try again, shithead.");
            Console.WriteLine("END OF LINE");
            Console.ReadKey();
            Console.Clear();
            break;
    }
}

void TheCleanerUpper()
{
    Console.WriteLine("Press any key to return to menu");
    Console.ReadKey();
    Console.Clear();
}


void ViewAllProducts()
{
    for (int i = 0; i < products.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {products[i].Name} {(products[i].DateSold == null ? "is available" : "was sold")} for ${products[i].Price}");
    }
}

void ViewProductsByType()
{
    Console.Clear();
    Console.WriteLine($"Please select a category of products to view:");

    foreach (ProductType type in productTypes)
    {
        Console.WriteLine($"{type.Id}. {type.Title}");
    }
    // refactor to have while loop
    int choice = int.Parse(Console.ReadLine());

    Console.Clear();

    List<Product> selectedProducts = products.Where(p => p.ProductTypeId == choice).ToList();

    for (int i = 0; i < selectedProducts.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {selectedProducts[i].Name}");
    };
}

void RemoveProduct()
{
    Console.WriteLine("Please choose a product to remove:");

    ViewAllProducts();

    string choice = null;
    while (choice == null)
    {
        try
        {
            int response = int.Parse(Console.ReadLine().Trim());
            products.RemoveAt(response - 1);
            choice = response.ToString();
        }
        catch (FormatException)
        {
            Console.WriteLine("Please type only integers!");
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Please pick an actual option!");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
            Console.WriteLine("Do Better!");
        }
    }
}

void PurchaseProduct()
{
    Console.WriteLine("Please choose a product to purchase:");
    ViewAllProducts();
    List<Product> purchaseableProducts = products.Where(p => p.DateSold == null).ToList();
    for (int i = 0; i < purchaseableProducts.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {purchaseableProducts[i].Name}");
    }
    int response = int.Parse(Console.ReadLine());
    // need to find item being purchased and update
}

/*

1. Be able to purchase instrument
1. Post new instrument
1. See how long an item has been in inventory
    1. See details
1. Update prices
1. Stats
    1. Total purchases
    1. Total sold $ amount
    1. How many of each type instrument in stock
1. Pick a random stock item for details */