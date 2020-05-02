using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatMicroservice.Models
{
    public class PrepDb
    {
        public static void PrepPopulation(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                SeedData(serviceScope.ServiceProvider.GetService<CatContext>());
            }

        }

        public static void SeedData(CatContext context)
        {
            System.Console.WriteLine("Appling Migrations...");

            context.Database.Migrate();

            Cat cat = new Cat()
            {
                CatName = "Cat",
                CatCharacter = "test",
                CatLitter = "standard",
                ChekedIn = false,
                ChekedOut = false,
                CatMedicalCondition = "none",
                CatVetAddress1 = "The street",
                CatVetAddress2 = "The area",
                CatVetCity = "The city",
                CatVetPostCode = "M10 2GH",
                CatVetName = "The vet",
                CatVetPhoneNo = "01234785412",
                DateOfLastVac = DateTime.Now,
                MealType = Enum.MealType.Luxury,
                TagID = "1478523698",
                Vaccination = true,
                UserId = "system",
                Customer = Guid.NewGuid()
            };

            IList<Cat> catList = new List<Cat>();
            IList<Cat> catList1 = new List<Cat>();
            IList<Cat> catList2 = new List<Cat>();
            IList<Cat> catList3 = new List<Cat>();
            IList<Cat> catList4 = new List<Cat>();

            catList.Add(cat);

            Cat cat1 = new Cat()
            {
                CatName = "Cat1",
                CatCharacter = "test",
                CatLitter = "standard",
                ChekedIn = false,
                ChekedOut = false,
                CatMedicalCondition = "none",
                CatVetAddress1 = "The street",
                CatVetAddress2 = "The area",
                CatVetCity = "The city",
                CatVetPostCode = "M10 2GH",
                CatVetName = "The vet",
                CatVetPhoneNo = "01234785412",
                DateOfLastVac = DateTime.Now,
                MealType = Enum.MealType.Luxury,
                TagID = "2478523698",
                Vaccination = true,
                UserId = "system",
                Customer = Guid.NewGuid()
            };

            catList.Add(cat1);

            Cat cat2 = new Cat()
            {
                CatName = "Cat2",
                CatCharacter = "test",
                CatLitter = "standard",
                ChekedIn = false,
                ChekedOut = false,
                CatMedicalCondition = "none",
                CatVetAddress1 = "The street",
                CatVetAddress2 = "The area",
                CatVetCity = "The city",
                CatVetPostCode = "M10 2GH",
                CatVetName = "The vet",
                CatVetPhoneNo = "01234785412",
                DateOfLastVac = DateTime.Now,
                MealType = Enum.MealType.Luxury,
                TagID = "3478523698",
                Vaccination = true,
                UserId = "system",
                Customer = Guid.NewGuid()
            };

            catList1.Add(cat2);

            Cat cat3 = new Cat()
            {
                CatName = "Cat3",
                CatCharacter = "test",
                CatLitter = "standard",
                ChekedIn = false,
                ChekedOut = false,
                CatMedicalCondition = "none",
                CatVetAddress1 = "The street",
                CatVetAddress2 = "The area",
                CatVetCity = "The city",
                CatVetPostCode = "M10 2GH",
                CatVetName = "The vet",
                CatVetPhoneNo = "01234785412",
                DateOfLastVac = DateTime.Now,
                MealType = Enum.MealType.Luxury,
                TagID = "4478523698",
                Vaccination = true,
                UserId = "system",
                Customer = Guid.NewGuid()
            };

            catList1.Add(cat3);

            Cat cat4 = new Cat()
            {
                CatName = "Cat4",
                CatCharacter = "test",
                CatLitter = "standard",
                ChekedIn = false,
                ChekedOut = false,
                CatMedicalCondition = "none",
                CatVetAddress1 = "The street",
                CatVetAddress2 = "The area",
                CatVetCity = "The city",
                CatVetPostCode = "M10 2GH",
                CatVetName = "The vet",
                CatVetPhoneNo = "01234785412",
                DateOfLastVac = DateTime.Now,
                MealType = Enum.MealType.Luxury,
                TagID = "5478523698",
                Vaccination = true,
                UserId = "system",
                Customer = Guid.NewGuid()
            };

            catList2.Add(cat4);

            Cat cat5 = new Cat()
            {
                CatName = "Cat5",
                CatCharacter = "test",
                CatLitter = "standard",
                ChekedIn = false,
                ChekedOut = false,
                CatMedicalCondition = "none",
                CatVetAddress1 = "The street",
                CatVetAddress2 = "The area",
                CatVetCity = "The city",
                CatVetPostCode = "M10 2GH",
                CatVetName = "The vet",
                CatVetPhoneNo = "01234785412",
                DateOfLastVac = DateTime.Now,
                MealType = Enum.MealType.Luxury,
                TagID = "6478523698",
                Vaccination = true,
                UserId = "system",
                Customer = Guid.NewGuid()
            };

            catList2.Add(cat5);

            Cat cat6 = new Cat()
            {
                CatName = "Cat6",
                CatCharacter = "test",
                CatLitter = "standard",
                ChekedIn = false,
                ChekedOut = false,
                CatMedicalCondition = "none",
                CatVetAddress1 = "The street",
                CatVetAddress2 = "The area",
                CatVetCity = "The city",
                CatVetPostCode = "M10 2GH",
                CatVetName = "The vet",
                CatVetPhoneNo = "01234785412",
                DateOfLastVac = DateTime.Now,
                MealType = Enum.MealType.Luxury,
                TagID = "7478523698",
                Vaccination = true,
                UserId = "system",
                Customer = Guid.NewGuid()
            };

            catList3.Add(cat6);

            Cat cat7 = new Cat()
            {
                CatName = "Cat7",
                CatCharacter = "test",
                CatLitter = "standard",
                ChekedIn = false,
                ChekedOut = false,
                CatMedicalCondition = "none",
                CatVetAddress1 = "The street",
                CatVetAddress2 = "The area",
                CatVetCity = "The city",
                CatVetPostCode = "M10 2GH",
                CatVetName = "The vet",
                CatVetPhoneNo = "01234785412",
                DateOfLastVac = DateTime.Now,
                MealType = Enum.MealType.Luxury,
                TagID = "8478523698",
                Vaccination = true,
                UserId = "system",
                Customer = Guid.NewGuid()
            };

            catList3.Add(cat7);

            Cat cat8 = new Cat()
            {
                CatName = "Cat8",
                CatCharacter = "test",
                CatLitter = "standard",
                ChekedIn = false,
                ChekedOut = false,
                CatMedicalCondition = "none",
                CatVetAddress1 = "The street",
                CatVetAddress2 = "The area",
                CatVetCity = "The city",
                CatVetPostCode = "M10 2GH",
                CatVetName = "The vet",
                CatVetPhoneNo = "01234785412",
                DateOfLastVac = DateTime.Now,
                MealType = Enum.MealType.Luxury,
                TagID = "9478523698",
                Vaccination = true,
                UserId = "system",
                Customer = Guid.NewGuid()
            };

            catList4.Add(cat8);

            Cat cat9 = new Cat()
            {
                CatName = "Cat8",
                CatCharacter = "test",
                CatLitter = "standard",
                ChekedIn = false,
                ChekedOut = false,
                CatMedicalCondition = "none",
                CatVetAddress1 = "The street",
                CatVetAddress2 = "The area",
                CatVetCity = "The city",
                CatVetPostCode = "M10 2GH",
                CatVetName = "The vet",
                CatVetPhoneNo = "01234785412",
                DateOfLastVac = DateTime.Now,
                MealType = Enum.MealType.Luxury,
                TagID = "9478523698",
                Vaccination = true,
                UserId = "system",
                Customer = Guid.NewGuid()
            };

            catList4.Add(cat9);

            if (!context.Cats.Any())
            {
                System.Console.WriteLine("Seeding Cat Data...");
                context.Cats.AddRange(cat, cat1, cat2, cat3, cat4, cat5, cat6, cat7, cat8, cat9);

                context.SaveChanges();
            }
            else
            {
                System.Console.WriteLine("Already have data Cat - not seeding");
            }
        }
        }
}
