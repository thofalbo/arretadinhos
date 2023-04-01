namespace Arretadinhos.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        public Department() {}
        public Department(string name)
        {
            Name = name;
        }
        
        public void AddSeller(Seller s)
        {
            Sellers.Add(s);
        }
        public void RemoveSeller(Seller s)
        {
            Sellers.Remove(s);
        }
        public double TotalSales(DateTime initial, DateTime final) => Sellers.Sum(s => s.TotalSales(initial, final));
    }
}
