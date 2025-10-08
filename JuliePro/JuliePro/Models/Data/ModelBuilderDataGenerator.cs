﻿using Microsoft.EntityFrameworkCore;

namespace JuliePro.Models.Data
{
    static class ModelBuilderDataGenerator
    {
        public static void GenerateData(this ModelBuilder builder)
        {

            //Ajout de champs temporaire pour tester.
            builder.Entity<Speciality>().HasData(new Speciality() { Id = 1, Name = "Perte de poids" });
            builder.Entity<Speciality>().HasData(new Speciality() { Id = 2, Name = "Course" });
            builder.Entity<Speciality>().HasData(new Speciality() { Id = 3, Name = "Halthérophilie" });
            builder.Entity<Speciality>().HasData(new Speciality() { Id = 4, Name = "Réhabilitation" });

            //Ajout de seeds pour Entraineurs.
            builder.Entity<Trainer>().HasData(new Trainer() { Id = 1, FirstName = "Chrystal", LastName = "Lapierre", Email = "Chrystal.lapierre@juliepro.ca", SpecialityId = 1, Photo = "Chrystal.png" });
            builder.Entity<Trainer>().HasData(new Trainer() { Id = 2, FirstName = "Félix", LastName = "Trudeau", Email = "Felix.trudeau@juliePro.ca", SpecialityId = 2, Photo = "Felix.png" });
            builder.Entity<Trainer>().HasData(new Trainer() { Id = 3, FirstName = "François", LastName = "Saint-John", Email = "Frank.StJohn@juliepro.ca", SpecialityId = 1, Photo = "Francois.png" });
            builder.Entity<Trainer>().HasData(new Trainer() { Id = 4, FirstName = "Jean-Claude", LastName = "Bastien", Email = "JC.Bastien@juliepro.ca", SpecialityId = 4, Photo = "JeanClaude.png" });
            builder.Entity<Trainer>().HasData(new Trainer() { Id = 5, FirstName = "Jin Lee", LastName = "Godette", Email = "JinLee.godette@juliepro.ca", SpecialityId = 3, Photo = "Jin Lee.png" });
            builder.Entity<Trainer>().HasData(new Trainer() { Id = 6, FirstName = "Karine", LastName = "Lachance", Email = "Karine.Lachance@juliepro.ca", SpecialityId = 2, Photo = "Karine.png" });
            builder.Entity<Trainer>().HasData(new Trainer() { Id = 7, FirstName = "Ramone", LastName = "Esteban", Email = "Ramone.Esteban@juliepro.ca", SpecialityId = 3, Photo = "Ramone.png" });

            //Ajout de Seeds Customer
            builder.Entity<Customer>().HasData(new Customer() { Id = 1, FirstName = "Alexandre", LastName = "Vigneault", BirthDate = new DateTime(2003, 3, 15), Email = "AdeptInformatique@gmail.com", TrainerId = 1, StartWeight = 140 });
            builder.Entity<Customer>().HasData(new Customer() { Id = 2, FirstName = "Julien", LastName = "Blitzer", BirthDate = new DateTime(2004, 11, 2), Email = "Umamusume@gamer.org", TrainerId = 1, StartWeight = 290 });
            builder.Entity<Customer>().HasData(new Customer() { Id = 3, FirstName = "Ludovick", LastName = "Nadeau", BirthDate = new DateTime(2005, 8, 4), Email = "bonhommebabs@gmail.com", TrainerId = 1, StartWeight = 210 });
            builder.Entity<Customer>().HasData(new Customer() { Id = 4, FirstName = "Hedi", LastName = "Melo Cherni", BirthDate = new DateTime(2005, 10, 8), Email = "spookyeye@gmail.com", TrainerId = 2, StartWeight = 195 });



            //Ajout de Seeds Objective

            builder.Entity<Objective>().HasData(new Objective() { Id = 1, CustomerId = 1, Name = "Course", DistanceKm = 2, LostWeightKg = 5, AchievedDate = null });
            builder.Entity<Objective>().HasData(new Objective() { Id = 2, CustomerId = 1, Name = "Perte de poids", DistanceKm = 15, LostWeightKg = 4, AchievedDate = null });
            builder.Entity<Objective>().HasData(new Objective() { Id = 3, CustomerId = 1, Name = "Perte de poids", DistanceKm = 20, LostWeightKg = 10, AchievedDate = new DateTime(2023, 5, 10) });
            builder.Entity<Objective>().HasData(new Objective() { Id = 4, CustomerId = 1, Name = "Course", DistanceKm = 10, LostWeightKg = 7, AchievedDate = new DateTime(2025, 6, 17) });

            builder.Entity<Objective>().HasData(new Objective() { Id = 5, CustomerId = 2, Name = "Perte de poids", DistanceKm = 15, LostWeightKg = 10, AchievedDate = null });

            builder.Entity<Objective>().HasData(new Objective() { Id = 6, CustomerId = 3, Name = "Perte de poids", DistanceKm = 1, LostWeightKg = 1, AchievedDate = new DateTime(2025, 7, 8) });
            builder.Entity<Objective>().HasData(new Objective() { Id = 7, CustomerId = 3, Name = "Course", DistanceKm = 1, LostWeightKg = 2, AchievedDate = new DateTime(2024, 10, 11) });
            builder.Entity<Objective>().HasData(new Objective() { Id = 8, CustomerId = 3, Name = "Course", DistanceKm = 3, LostWeightKg = 4, AchievedDate = new DateTime(2025, 1, 6) });

            builder.Entity<Objective>().HasData(new Objective() { Id = 9, CustomerId = 4, Name = "Perte de poids", DistanceKm = 5, LostWeightKg = 7, AchievedDate = null });
            builder.Entity<Objective>().HasData(new Objective() { Id = 10, CustomerId = 4, Name = "Course", DistanceKm = 2, LostWeightKg = 5, AchievedDate = new DateTime(2025, 9, 3) });



        }
    }
}
