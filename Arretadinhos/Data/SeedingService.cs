using Arretadinhos.Models;
using Arretadinhos.Models.Enums;

namespace Arretadinhos.Data
{
    public class SeedingService
    {
        private ArretadinhosContext _context;
        public SeedingService(ArretadinhosContext context)
        {
            _context = context;
        }
        public void Seed()
        {
            if(
                _context.Department.Any() ||
                _context.SalesRecord.Any() ||
                _context.Seller.Any()
            ){
                return;
            }
            Department d1 = new Department("Kitchen");
            Department d2 = new Department("TI");
            Department d3 = new Department("Sales");
            Department d4 = new Department("Customer Service");
            Department d5 = new Department("Marketing");
 
            Seller s1 = new Seller("Bob Brown", "bob@email.com", new DateTime(1998, 4, 21).ToUniversalTime(), 1000.0, d1);
            Seller s2 = new Seller("John Doe", "john.doe@email.com", new DateTime(1990, 2, 11).ToUniversalTime(), 1500.0, d2);
            Seller s3 = new Seller("Jane Smith", "jane.smith@email.com", new DateTime(1985, 7, 3).ToUniversalTime(), 2000.0, d3);
            Seller s4 = new Seller("Peter Parker", "peter.parker@email.com", new DateTime(1995, 9, 12).ToUniversalTime(), 1800.0, d4);
            Seller s5 = new Seller("Mary Jane", "mary.jane@email.com", new DateTime(1996, 11, 8).ToUniversalTime(), 1600.0, d1);
            Seller s6 = new Seller("Bruce Wayne", "bruce.wayne@email.com", new DateTime(1980, 6, 23).ToUniversalTime(), 3000.0, d2);
            Seller s7 = new Seller("Clark Kent", "clark.kent@email.com", new DateTime(1978, 3, 30).ToUniversalTime(), 2500.0, d3);
            Seller s8 = new Seller("Diana Prince", "diana.prince@email.com", new DateTime(1992, 1, 15).ToUniversalTime(), 1900.0, d4);
            Seller s9 = new Seller("Barry Allen", "barry.allen@email.com", new DateTime(1994, 8, 5).ToUniversalTime(), 1700.0, d5);
            Seller s10 = new Seller("Oliver Queen", "oliver.queen@email.com", new DateTime(1991, 4, 29).ToUniversalTime(), 2200.0, d5);

            SalesRecord sr1 = new SalesRecord(new DateTime(2018, 09,25).ToUniversalTime(), 12000.0, SalesStatus.Billed, s1);
            SalesRecord sr2 = new SalesRecord(new DateTime(2018, 09,26).ToUniversalTime(), 15000.0, SalesStatus.Billed, s1);
            SalesRecord sr3 = new SalesRecord(new DateTime(2018, 09,27).ToUniversalTime(), 8000.0, SalesStatus.Billed, s2);
            SalesRecord sr4 = new SalesRecord(new DateTime(2018, 09,28).ToUniversalTime(), 5000.0, SalesStatus.Pending, s2);
            SalesRecord sr5 = new SalesRecord(new DateTime(2018, 09,29).ToUniversalTime(), 10000.0, SalesStatus.Pending, s3);
            SalesRecord sr6 = new SalesRecord(new DateTime(2018, 09,30).ToUniversalTime(), 7000.0, SalesStatus.Canceled, s3);
            SalesRecord sr7 = new SalesRecord(new DateTime(2018, 10,01).ToUniversalTime(), 20000.0, SalesStatus.Billed, s4);
            SalesRecord sr8 = new SalesRecord(new DateTime(2018, 10,02).ToUniversalTime(), 3000.0, SalesStatus.Billed, s4);
            SalesRecord sr9 = new SalesRecord(new DateTime(2018, 10,03).ToUniversalTime(), 4000.0, SalesStatus.Billed, s5);
            SalesRecord sr10 = new SalesRecord(new DateTime(2018, 10,04).ToUniversalTime(), 9000.0, SalesStatus.Billed, s5);
            SalesRecord sr11 = new SalesRecord(new DateTime(2018, 10,05).ToUniversalTime(), 11000.0, SalesStatus.Canceled, s6);
            SalesRecord sr12 = new SalesRecord(new DateTime(2018, 10,06).ToUniversalTime(), 13000.0, SalesStatus.Billed, s6);
            SalesRecord sr13 = new SalesRecord(new DateTime(2018, 10,07).ToUniversalTime(), 6000.0, SalesStatus.Billed, s7);
            SalesRecord sr14 = new SalesRecord(new DateTime(2018, 10,08).ToUniversalTime(), 8000.0, SalesStatus.Billed, s7);
            SalesRecord sr15 = new SalesRecord(new DateTime(2018, 10,09).ToUniversalTime(), 12000.0, SalesStatus.Billed, s8);
            SalesRecord sr16 = new SalesRecord(new DateTime(2018, 10,10).ToUniversalTime(), 15000.0, SalesStatus.Pending, s8);
            SalesRecord sr17 = new SalesRecord(new DateTime(2018, 10,11).ToUniversalTime(), 9000.0, SalesStatus.Pending, s9);
            SalesRecord sr18 = new SalesRecord(new DateTime(2018, 10,12).ToUniversalTime(), 7000.0, SalesStatus.Canceled, s9);
            SalesRecord sr19 = new SalesRecord(new DateTime(2018, 10,13).ToUniversalTime(), 5000.0, SalesStatus.Billed, s10);
            SalesRecord sr20 = new SalesRecord(new DateTime(2018, 10,14).ToUniversalTime(), 8000.0, SalesStatus.Billed, s10);
            SalesRecord sr21 = new SalesRecord(new DateTime(2018, 10,15).ToUniversalTime(), 9000.0, SalesStatus.Pending, s1);
            SalesRecord sr22 = new SalesRecord(new DateTime(2018, 10,16).ToUniversalTime(), 11000.0, SalesStatus.Pending, s1);

            _context.Department.AddRange(d1, d2, d3, d4, d5);
            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6, s7, s8, s9, s10);
            _context.SalesRecord.AddRange(
                sr1, sr2, sr3, sr4, sr5, sr6, sr7, sr9, sr10,
                sr11, sr12, sr13, sr14, sr15, sr16, sr17, sr18, sr19, sr20, sr22
                );

            _context.SaveChanges();
        }
    }
}