using System;
using System.Collections.Generic;
using RealEstateMvc.Models.Enums;


namespace RealEstateMvc.Models
{
    public class Rent
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public ContractStatus ContractStatus { get; set; }
        public PropertyType PropertyType { get; set; }
        public Contract Contract { get; set; }

        public Consultant Consultant { get; set; }

        public Rent()
        {
        }

        public Rent(int id, DateTime date, double amount, ContractStatus contractStatus, PropertyType propertyType, Contract contract, Consultant consultant)
        {
            Id = id;
            Date = date;
            Amount = amount;
            ContractStatus = contractStatus;
            PropertyType = propertyType;
            Contract = contract;
            Consultant = consultant;
        }
    }
}
