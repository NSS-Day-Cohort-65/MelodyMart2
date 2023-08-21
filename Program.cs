// See https://aka.ms/new-console-template for more information
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