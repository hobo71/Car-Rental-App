﻿using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.IO;
using System.Linq;
using CarRentalApp.Core.domain;
using CarRentalApp.Core.domain.SeedData;
using CsvHelper;

namespace CarRentalApp.Persistence
{
    public class CarRentalDbInitializer : DropCreateDatabaseIfModelChanges<CarRentalAppContext>
    {
        protected override void Seed(CarRentalAppContext context)
        {
         
            var administratorRole = new Role
            {
                Name = RoleName.ADMINISTRATOR,
                Description = "The big boss in less words"
            };

            var managerRole = new Role
            {
                Name = RoleName.MANAGER,
                Description = "The manager is the person Who Handle Client and Rents"
            };

            context.Roles.AddOrUpdate(r => r.Name,
                administratorRole,
                managerRole);


            context.Users.AddOrUpdate(u => u.Username,
                new User
                {
                    Username = "kowama",
                    FirstName = "Latif",
                    LastName = "Karambiri",
                    Cin = "L002257P",
                    Email = "n.kowama@gmail.com",
                    Phone = "0691025223",
                    Password = "12345",
                    Roles = new ObservableCollection<Role>
                    {
                        administratorRole
                    }
                },
                new User
                {
                    Username = "Medi1",
                    FirstName = "Mehdi",
                    LastName = "Lahk",
                    Cin = "C002057P",
                    Email = "l.mehdi@gmail.com",
                    Phone = "0691889223",
                    Password = "12345",
                    Roles = new ObservableCollection<Role>
                    {
                        managerRole
                    }
                },
                new User
                {
                    Username = "KoyeKoye",
                    FirstName = "Verassou",
                    LastName = "Koye",
                    Cin = "L002297P",
                    Email = "kverassou7@gmail.com",
                    Phone = "069104223",
                    Password = "12345",
                    Roles = new ObservableCollection<Role>
                    {
                        managerRole
                    }
                });

            //Clients
            var reader = new StreamReader(ResourcePaths.Clients);
            var csv = new CsvReader(reader);
            csv.Configuration.RegisterClassMap<ClientMap>();
            var clientsRecords = csv.GetRecords<Client>().ToArray();
            context.Clients.AddOrUpdate(c => c.Id, clientsRecords);

            //Classifications
            reader = new StreamReader(ResourcePaths.Classifications);
            csv = new CsvReader(reader);
            csv.Configuration.RegisterClassMap<ClassificationMap>();
            var classificationsRecords = csv.GetRecords<Classification>().ToArray();
            context.Classifications.AddOrUpdate(c => c.Id, classificationsRecords);

            //Cars
            reader = new StreamReader(ResourcePaths.Cars);
            csv = new CsvReader(reader);
            CarMap.Classifications = classificationsRecords.ToList();
            csv.Configuration.RegisterClassMap<CarMap>();
            var carsRecords = csv.GetRecords<Car>().ToArray();
            context.Cars.AddOrUpdate(c => c.Id, carsRecords);

        }

    }
}