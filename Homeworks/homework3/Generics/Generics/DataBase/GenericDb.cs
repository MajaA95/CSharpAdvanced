using Generics.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Generics.DataBase
{
    public static class GenericDb<T> where T : BaseEntity
    {
        public static List<T> Db;

        static GenericDb()
        {
            Db = new List<T>();
        }

    

        public static void InsertingACar(T entity)
        {
            Db.Add(entity);
            Console.WriteLine($"New car Id: {entity.Id}, Brand: {entity.Brand}, Max Speed: {entity.MaxSpeed}, Horse Power: {entity.HorsePower}, Fuel Type: {entity.FuelType}");
        }

        public static void GetACarById(string id)
        {
            foreach (T entity in Db)
            {
                if (entity.Id == id)
                {
                    Console.WriteLine($"Car with id: {entity.Id} is {entity.Brand}");
                }
                else
                {
                    Console.WriteLine("Wrong id, try again");
                }
            }
        }

        public static void PrintAllCars()
        {
            foreach(var T in Db)
            {
                Console.WriteLine($"Id: {T.Id}, Brand: {T.Brand}, MaxSpeed: {T.MaxSpeed}, HorsePower: {T.HorsePower}, FuelType: {T.FuelType}");
            }
        }

    }
}