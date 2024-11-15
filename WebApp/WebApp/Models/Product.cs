﻿using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public TimeSpan EstimatedProductionTime { get; set; }
        public Dictionary<RawMaterial, double> RawMaterialNeeded { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int AmountInStock { get; set; }

        public Product(int id, string name, TimeSpan estimatedProductionTime, Dictionary<RawMaterial, double> rawMaterialNeeded, DateTime createdAt, DateTime updatedAt, int amountInStock)
        {
            Id = id;
            Name = name;
            EstimatedProductionTime = estimatedProductionTime;
            RawMaterialNeeded = rawMaterialNeeded;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            AmountInStock = AmountInStock;
        }
        public Product(){}

        public void AddMaterial(RawMaterial rawMaterial, double amount)
        {
            RawMaterialNeeded.Add(rawMaterial, amount);
        }

        public void RemoveMaterial(RawMaterial rawMaterial)
        {
            RawMaterialNeeded.Remove(rawMaterial);
        }

        public void RemoveAmountFromMaterial(RawMaterial rawMaterial, double amount)
        {
            if (RawMaterialNeeded.ContainsKey(rawMaterial) && RawMaterialNeeded[rawMaterial] > amount)
            {
                throw new Exception("Du kan ikke fjerne antal der er mere end hvad der er tilgængeligt");
            } else
            {
                RawMaterialNeeded[rawMaterial] -= amount;
            }
        }

        public override string ToString()
        {
            return Name + ": " + EstimatedProductionTime + ". Created at: " + CreatedAt + ". Updated at: " + UpdatedAt;
        }
    }
}