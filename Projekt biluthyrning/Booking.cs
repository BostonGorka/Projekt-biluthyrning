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
		/// En konstruktor som skickar med värden
		/// </summary>
		/// <param name="inputName">Gör möjlig input för namn</param>
		/// <param name="inputAge">Gör möjlig input för ålder</param>
		/// <param name="inputAddress">Gör möjlig input för address</param>
		/// <param name="inputPhonenumber">Gör möjlig input för telefonnummer</param>
		/// <param name="inputPickUpPlace">Gör möjlig input för upphämtningsplats</param>
		/// <param name="inputPickUpDate">Gör möjlig input för upphämtningsdatum</param>
		/// <param name="inputEndDate">Gör möjlig input för återlämningsdatum</param>
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

