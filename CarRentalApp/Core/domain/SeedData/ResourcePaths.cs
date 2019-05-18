﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ComponentFactory.Krypton.Toolkit;
using CsvHelper.Configuration;

namespace CarRentalApp.Core.domain.SeedData
{
    public static class ResourcePaths
    {
        private static string Prefix
        {
            get
            {
                // This will get the current WORKING directory (i.e. \bin\Debug)
                var workingDirectory = Environment.CurrentDirectory;
                // or: Directory.GetCurrentDirectory() gives the same result

                // This will get the current PROJECT directory
                return Directory.GetParent(workingDirectory).Parent?.FullName;

            }
        } 

        public static readonly string Clients = $"{Prefix}clients.csv";
        public static readonly string Classifications = $"{Prefix}classifications.csv";
        public static readonly string Cars = $"{Prefix}cars.csv";
    }

    public sealed class ClientMap : ClassMap<Client>
    {
        public ClientMap()
        {
            AutoMap();
            Map(c => c.Rents).Ignore();
            Map(c => c.Id).Ignore();
        }
    }

    public sealed class ClassificationMap : ClassMap<Classification>
    {
        public ClassificationMap()
        {
            AutoMap();
            Map(c => c.Cars).Ignore();
            Map(c => c.Id).Ignore();
        }
    }

    public sealed class CarMap : ClassMap<Car>
    {
        public static List<Classification> Classifications { get; set; }

        public CarMap()
        {
            if (Classifications == null || !Classifications.Any())
                throw new Exception(typeof(CarMap).FullName
                                    + " Classifications prop Need to be initialized before use");

            Map(c => c.Name).Name(nameof(Car.Name));
            Map(c => c.LicensePlate).Name(nameof(Car.LicensePlate));
            Map(c => c.Classification).Name(nameof(Car.LicensePlate));
            Map(c => c.PricePerDay).Name(nameof(Car.PricePerDay));
            Map(c => c.PurchaseDate).Name(nameof(Car.PurchaseDate));
            Map(c => c.NextDrainDate).Name(nameof(Car.NextDrainDate));
            Map(c => c.Description).Name(nameof(Car.Description));
            Map(c => c.Rents).Ignore();
            Map(c => c.Id).Ignore();
            Map(c => c.CarImage).Ignore();
            Map(c => c.Classification).ConvertUsing(row => ReadNested(row.GetField(nameof(Car.Classification))));
        }

        private static Classification ReadNested(string classificationName)
        {
            return Classifications.SingleOrDefault(c => c.Name == classificationName);
        }
    }
}