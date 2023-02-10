using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood_Donation.Services
{
    public static class Davaoci_KrviServices
	{
        public static void CallNumberPhone(string number)
        {
			if (PhoneDialer.Default.IsSupported)
				PhoneDialer.Current.Open(number);

		}
    }
}
