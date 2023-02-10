using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TableAttribute = SQLite.TableAttribute;


namespace Blood_Donation.Moduli
{
    [Table("donationhistory")]
    public class DonationHistory
    {
        [PrimaryKey, AutoIncrement]
        private int Id { get; set; }
        public string LokacijaName {get; set;}
        public string DatumDarivanja {get; set;}

        [ForeignKey(typeof(User))]
        public int UserId { get; set; }
    }
}
