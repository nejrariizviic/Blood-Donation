using Blood_Donation.Moduli;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood_Donation.Data
{
    public class DonationHistoryRepository
    {
        public string StatusMessage { get; set; }

        public static SQLiteConnection conn;

        public static void Init()
        {
            if (conn != null)
                return;
            conn = new SQLiteConnection(Database.DatabasePath, Database.Flags);
            conn.CreateTable<DonationHistory>();

        }
        public void AddOne(string name, string datumDarivanja, int userId)
        {
            int result = 0;
            try
            {
                Init();

                result = conn.Insert(new DonationHistory {  LokacijaName = name, DatumDarivanja = datumDarivanja, UserId = userId});
                StatusMessage = string.Format("Uspješno spreljeno!");
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Nije moguće izvršiti spremanje!\n{0}", ex.Message);
            }
        }
        public List<DonationHistory> GetDonationHistoryByUserId(int userId)
        {
            Init();
            return conn.Table<DonationHistory>().Where(r => r.UserId == userId).ToList();
        }

    }
}
