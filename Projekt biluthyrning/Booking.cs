using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_biluthyrning {
	internal class Booking {
		protected string Name;
		protected int Age;
		protected string Address;
		protected int Phonenumber;
		protected string PickUpDate;
		protected string EndDate;

		public Booking(string inputName, int inputAge, string inputAddress, int inputPhonenumber, string inputPickUpDate, string inputEndDate) {
			Name = inputName;
			Age = inputAge;
			Address = inputAddress;
			Phonenumber = inputPhonenumber;
			PickUpDate = inputPickUpDate;
			EndDate = inputEndDate;
		}
			
		
		}
	}

