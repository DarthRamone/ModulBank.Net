using System;
using Newtonsoft.Json;

namespace ModulBank.Models.Dto
{
    internal class BillDto
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
    }
}