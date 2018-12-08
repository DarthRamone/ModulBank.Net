using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

namespace ModulBank.Models
{
    public class BillPayload
    {
        public string Id { get; set; }
        
        public string Merchant { get; set; }
        
        public double Amount { get; set; }

        public string Description { get; set; }
        
        public DateTime Expires { get; set; }
        
        public string EmailForNotification { get; set; }
        
        public string ReceiptContact { get; set; }
        
        public string ClientEmail { get; set; }

        public bool Testing { get; set; }
        
        public string Signature { get; set; }
        
        public DateTime Timestamp { get; set; }
        
        public bool SendLinkViaEmail { get; set; }

        public List<ReceiptItem> ReceiptItems { get; set; }

        internal Dictionary<string, string> GetDictionary()
        {
            var result = new Dictionary<string, string>();
            
            var unixTimestamp = (Int32)(Timestamp.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;

            if (!string.IsNullOrEmpty(Id))
                result["id"] = Id;

            if (!string.IsNullOrEmpty(ReceiptContact))
                result["receipt_contact"] = ReceiptContact;
            
            result["merchant"] = Merchant;
            result["amount"] = Amount.ToString("F2").Replace(",", ".");
            result["testing"] = Testing ? "1" : "0";
            result["description"] = Description;
            result["unix_timestamp"] = unixTimestamp.ToString();

            if (ReceiptItems != null && ReceiptItems.Any())
            {
                var receipt_items = JsonConvert.SerializeObject(ReceiptItems, new JsonSerializerSettings
                {
                    ContractResolver = new DefaultContractResolver {NamingStrategy = new SnakeCaseNamingStrategy()},
                    Converters = new JsonConverter[] {new StringEnumConverter()}
                });

                result["receipt_items"] = receipt_items;
            }

            return result;
        }
    }
}