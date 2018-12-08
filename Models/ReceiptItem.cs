namespace ModulBank.Models
{
    public class ReceiptItem
    {
        public double Price { get; set; }
        
        public string Name { get; set; }
        
        public int Quantity { get; set; }
        
        public string Description { get; set; }
        
        public TaxSystem Sno { get; set; }
        
        public PaymentObject PaymentObject { get; set; }
        
        public PaymentMethod PaymentMethod { get; set; }
        
        public VAT Vat { get; set; }
    }
}