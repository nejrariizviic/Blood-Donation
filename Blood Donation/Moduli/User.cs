
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Blood_Donation.Moduli
{
    [Table("user")]
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(100)]
        public string LastName { get; set; }
        public string DateOfBirth { get; set; }
        public string BloodGroup { get; set; }
        public string Gender { get; set; }
        [MaxLength(100)]
        public string ContactNumber { get; set; }
        [MaxLength(100)]
        public string City { get; set; }
        [MaxLength(100)]
        public string Address { get; set; }
        [MaxLength(100)]
        public string Image { get; set; }
        [MaxLength(100), Unique]
        public string Email { get; set; }
        [MaxLength(100)]
        public string Pass { get; set; }

    }
}
