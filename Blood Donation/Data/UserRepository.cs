
using Blood_Donation.Moduli;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood_Donation.Data
{
    public class UserRepository
    {
        public string StatusMessage { get; set; }

        public static SQLiteConnection conn;

        public static void Init()
        {
            if (conn != null)
                return;
            conn = new SQLiteConnection(Database.DatabasePath, Database.Flags);
            conn.CreateTable<User>();

        }
      public void AddUser(string name, string lastname,string dateBirth, string bloodGroup, string genderUser, string contactnumber, string city, string adress,string image, string email, string pass)
        {
            int result = 0;
            try
            {
                Init();

                if (string.IsNullOrEmpty(name))
                       throw new Exception("Sva polja moraju biti popunjena!!");
                if (string.IsNullOrEmpty(lastname))
                    throw new Exception("Sva polja moraju biti popunjena!!");
                if (string.IsNullOrEmpty(dateBirth))
                    throw new Exception("Sva polja moraju biti popunjena!!");
                if (string.IsNullOrEmpty(bloodGroup))
                    throw new Exception("Sva polja moraju biti popunjena!!");
                if (string.IsNullOrEmpty(genderUser))
                    throw new Exception("Sva polja moraju biti popunjena!!");
                if (string.IsNullOrEmpty(contactnumber))
                    throw new Exception("Sva polja moraju biti popunjena!!");
                if (string.IsNullOrEmpty(city))
                    throw new Exception("Sva polja moraju biti popunjena!!");
                if (string.IsNullOrEmpty(adress))
                    throw new Exception("Sva polja moraju biti popunjena!!");
                if (string.IsNullOrEmpty(email))
                    throw new Exception("Sva polja moraju biti popunjena!!");
                if (string.IsNullOrEmpty(pass))
                    throw new Exception("Sva polja moraju biti popunjena!!");

                result = conn.Insert(new User { Name = name, LastName = lastname, DateOfBirth = dateBirth, BloodGroup=bloodGroup, Gender = genderUser, ContactNumber = contactnumber, City = city, Address = adress,Image=image, Email = email, Pass = pass });
                StatusMessage = string.Format("Uspješna registracija. Dobro došli {0}!", name);
            }catch(Exception ex)
            {
                StatusMessage = string.Format("Nije moguće izvršiti registraciju!\n{0}", ex.Message); 
            }
        }

        public List<User> GetAllUsers()
        {
            try
            {
                Init();
                return conn.Table<User>().ToList();
            }
            catch(Exception ex)
            {
                StatusMessage = string.Format("Nije moguce ucitati podatke, {0}", ex.Message);
            }
            return new List<User>();
        }

        public User GetUserByEmail(string email)
        {
            Init();
            var user = conn.Table<User>().Where(u => u.Email == email).FirstOrDefault();
            return user;
        }
        public void UpdateUser(User user)
        {
            try
            {
                Init();
                conn.Update(user);
                StatusMessage = string.Format("User {0} has been updated successfully.", user.Name);
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Failed to update user. Error: {0}", ex.Message);
            }
        }

    }
}
