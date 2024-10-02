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
		protected string PickUpPlace;
		protected string PickUpDate;
		protected string EndDate;

		public Booking(string inputName, int inputAge, string inputAddress, int inputPhonenumber, string inputPickUpPlace,string inputPickUpDate, string inputEndDate) {
			Name = inputName;
			Age = inputAge;
			Address = inputAddress;
			Phonenumber = inputPhonenumber;
			PickUpPlace = inputPickUpPlace;
			PickUpDate = inputPickUpDate;
			EndDate = inputEndDate;
		}

		
			
		
		}
	}

