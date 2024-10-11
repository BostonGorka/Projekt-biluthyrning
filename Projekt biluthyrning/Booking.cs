using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_biluthyrning {
	internal class Booking {
		public string Name;
		public int Age;
		public string Address;
		public int Phonenumber;
		public string PickUpPlace;
		public string PickUpDate;
		public string EndDate;
		/// <summary>
		/// En konstruktor
		/// </summary>
		/// <param name="inputName"></param>
		/// <param name="inputAge"></param>
		/// <param name="inputAddress"></param>
		/// <param name="inputPhonenumber"></param>
		/// <param name="inputPickUpPlace"></param>
		/// <param name="inputPickUpDate"></param>
		/// <param name="inputEndDate"></param>
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

