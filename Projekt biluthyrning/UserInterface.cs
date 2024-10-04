using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_biluthyrning {
	internal class UserInterface {
		VehicleInfo vehicleInfo;

		public void StartPage() {
			Console.WriteLine("-------------------------------------------------------------------");
			Console.WriteLine("Welcome, we have very good rental cars here at CarRentCenter.Com");
			Console.WriteLine("-------------------------------------------------------------------");
			Console.WriteLine("1. Boka samt specificera din hyrbil");
			Console.WriteLine("--------------------------------------------");
			Console.WriteLine("2. Boka samt specificera din hyrsläpvagn");


			string userInterFace = Console.ReadLine();
			int userInterFaceInput = int.Parse(userInterFace);
			if (userInterFaceInput == 1) {
				BookingSpecifications();
			} else if (userInterFaceInput == 2) {

			} else {
				Console.WriteLine("Ogiltig input, försök igen");
				userInterFace = Console.ReadLine();
			}
			Console.Clear();


		}

		public void BookingSpecifications() {
			Console.WriteLine("Skriv in ditt för samt efternamn");
			string inputName = Console.ReadLine();
			while (inputName == "") {
				Console.WriteLine("Ogiltig input, vänligen försök igen");
				inputName = Console.ReadLine();

			}
			Console.Clear();

			Console.WriteLine("Skriv in din ålder");
			string inputAge = Console.ReadLine();
			int age;
			while (!int.TryParse(inputAge, out age)) {
				Console.WriteLine("Ogiltig input, försök igen");
				inputAge = Console.ReadLine();
			}

			Console.Clear();

			Console.WriteLine("Skriv in din adress");
			string inputAddress = Console.ReadLine();
			while (inputAddress == "") {
				Console.WriteLine("Ogiltig input, försök igen");
				inputAddress = Console.ReadLine();

			}
			Console.Clear();

			Console.WriteLine("skriv in ditt telefonnummer");
			string inputPhoneNumber = Console.ReadLine();
			int phoneNumber;
			while (!int.TryParse(inputPhoneNumber, out phoneNumber)) {
				Console.WriteLine("Ogiltig input, försök igen");
				inputPhoneNumber = Console.ReadLine();
			}

			Console.Clear();

			Console.WriteLine("Välj upphämtningsplats: Stockholm, Göteborg eller Malmö");
			string inputPickUpPlace = Console.ReadLine();
			while (inputPickUpPlace == "") {
				Console.WriteLine("Ogiltig input, försök igen");
				inputPickUpPlace = Console.ReadLine();

			}

			Console.Clear();

			Console.WriteLine("Skriv in hämtdatumet för ditt hyrfordon (Dag/Månad)");
			string inputPickupDate = Console.ReadLine();
			while (inputPickupDate == "") {
				Console.WriteLine("Ogiltig input, försök igen");
				inputPickupDate = Console.ReadLine();

			}

			Console.Clear();

			Console.WriteLine("Skriv in återlämningsdatumet för ditt hyrfordon");
			string inputEndDate = Console.ReadLine();
			while (inputEndDate == "") {
				Console.WriteLine("Ogiltig input, försök igen");
				inputEndDate = Console.ReadLine();

			}
			Console.Clear();

			

			Booking booking = new Booking(inputName, age, inputAddress, phoneNumber, inputPickUpPlace, inputPickupDate, inputEndDate);
		}

		public void VehicleBooking() {
			Console.WriteLine("Välj mellan dessa karosstyper");
			Console.WriteLine("------------------------------");
			Console.WriteLine("1. Sedan");
			Console.WriteLine("2. Kombi");
			Console.WriteLine("3. SUV");
			vehicleInfo.CarType = Console.ReadLine();

			Console.Clear();

			Console.WriteLine("Välj mellan dessa drivmedel");
			Console.WriteLine("---------------------------");
			Console.WriteLine("1. Bensin");
			Console.WriteLine("2. Diesel");
			Console.WriteLine("3. El");
			Console.WriteLine("4. CNG");
			vehicleInfo.Fueltype = Console.ReadLine();

			Console.Clear();


		}
	}
}
