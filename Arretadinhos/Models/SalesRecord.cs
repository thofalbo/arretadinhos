namespace Arretadinhos.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        
        [DisplayFormat(DataFormatString = "R$ {0:F2}")]
        public SalesStatus Status { get; set; }
        public Seller Seller { get; set; }

        public SalesRecord(){}
        public SalesRecord(DateTime date, double amount, SalesStatus status, Seller seller)
        {
            Date = date;
            Amount = amount;
            Status = status;
            Seller = seller;
        }
    }
}