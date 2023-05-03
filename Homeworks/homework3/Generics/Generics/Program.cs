using Generics.DataBase;
using Generics.Entities;
using Generics.Helper;
using Microsoft.VisualBasic.FileIO;

JapaneseCar Toyota = new JapaneseCar()
{
    Id = "0001",
    Brand = "GR Supra",
    MaxSpeed = "250 mph",
    HorsePower = "25",
    FuelType = "Premium Gasoline"
};

ItalianCar Ferrari = new ItalianCar()
{
    Id = "0002",
    Brand = "F70 LaFerrari",
    MaxSpeed = "218mph",
    HorsePower = "28",
    FuelType = "hybrid petrol"
};

GenericDb<JapaneseCar>.InsertingACar(Toyota);
GenericDb<ItalianCar>.InsertingACar(Ferrari);

GenericDb<JapaneseCar>.GetACarById(Toyota.Id);

string text = Ferrari.Brand;

text.ColorText(ConsoleColor.Red);


