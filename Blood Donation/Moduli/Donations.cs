using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood_Donation.Moduli
{
    public class Donations
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        public string nameLocation { get; set; }
        
        public string datumDonation { get; set; }
        public int UserId { get; set; }


    }
}
