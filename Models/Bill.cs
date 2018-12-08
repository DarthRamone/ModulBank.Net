using System;
using ModulBank.Models.Dto;

namespace ModulBank.Models
{
    public class Bill
    {
        public double Amount { get; set; }
        
        public string Id { get; set; }
        
        public string ClientEmail { get; set; }
        
        public DateTime CreatedDatetime { get; set; }
        
        public string Currency { get; set; }
        
        public string Description { get; set; }
        
        public bool Expired { get; set; }
        
        public string Merchant { get; set; }
        
        public int Number { get; set; }
        
        public bool Paid { get; set; }
        
        public bool SendLetter { get; set; }
        
        public bool Testing { get; set; }
        
        //TODO: figure out what's this
        public object Transaction { get; set; }
        
        public string Url { get; set; }

        internal Bill(BillDto dto)
        {
            Amount = dto.Amount;
            Id = dto.Id;
            ClientEmail = dto.ClientEmail;
            CreatedDatetime = dto.CreatedDatetime;
            Currency = dto.Currency;
            Description = dto.Description;
            Expired = dto.Expired;
            Merchant = dto.Merchant;
            Number = dto.Number;
            Paid = dto.Paid;
            SendLetter = dto.SendLetter;
            Testing = dto.Testing;
            Transaction = dto.Transaction;
            Url = dto.Url;
        }
    }
}