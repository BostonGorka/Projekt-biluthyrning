using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_biluthyrning {
	internal class UserInterface {
		
		

		public void StartPage() {
			Console.WriteLine("-------------------------------------------------------------------");
			Console.WriteLine("Välkommen till Carrent.com, vi har dem bästa hyrbilarna på marknaden");
			Console.WriteLine("-------------------------------------------------------------------");
			Console.WriteLine("1. Boka samt specificera din hyrbil");
			


			string userInterFace = Console.ReadLine();
			Booking bookingLastInfo = BookingSpecifications();

			CarInfo vehicleSpecifications = VehicleBooking();

			LastInfo lastInfo = new LastInfo();
			lastInfo.Summary(bookingLastInfo, vehicleSpecifications);

			Console.WriteLine("Är du säker på att du vill slutföra bokning");
			string confirmBooking = Console.ReadLine();
			if(confirmBooking == "ja") {
				Console.Clear();
				Console.WriteLine("Din bokning är nu slutförd");
			}else if(confirmBooking == "nej") {
				Console.Clear();
				Console.WriteLine("Din bokning avbröts");
			} else {
				Console.WriteLine("Ogiltig input, försök igen");
				confirmBooking = Console.ReadLine();			}

		}

		public Booking BookingSpecifications() {
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
			return booking;
		}

		
		public CarInfo VehicleBooking() {
			Console.WriteLine("Välj mellan dessa karosstyper");
			Console.WriteLine("------------------------------");
			Console.WriteLine("1. Sedan");
			Console.WriteLine("2. Kombi");
			Console.WriteLine("3. SUV");
			string CarType = Console.ReadLine();
			if(CarType == "1") {
				CarType = "Sedan";
			}else if(CarType == "2") {
				CarType = "Kombi";
			}else if (CarType == "3") {
				CarType = "SUV";
			}
			Console.Clear();

			Console.WriteLine("Välj mellan dessa drivmedel");
			Console.WriteLine("---------------------------");
			Console.WriteLine("1. Bensin");
			Console.WriteLine("2. Diesel");
			Console.WriteLine("3. Elektrisk");
			Console.WriteLine("4. CNG");
			string Fueltype = Console.ReadLine();

			if(Fueltype == "1") {
				Fueltype = "Bensin";
			}else if (Fueltype == "2") {
				Fueltype = "Diesel";
			}else if (Fueltype == "3") {
				Fueltype = "Elektrisk";
			}else if (Fueltype == "4") {
				Fueltype = "CNG";
			}
			Console.Clear();

			Console.WriteLine("Välj din växellåda");
			Console.WriteLine("-------------------");
			Console.WriteLine("1. Manuell");
			Console.WriteLine("2. Automat");
			string Gearbox = Console.ReadLine();

			if(Gearbox == "1") {
				Gearbox = "Manuell";
			}else if(Gearbox == "2") {
				Gearbox = "Automat";
			}
			Console.Clear();

			Console.WriteLine("Välj drivlina");
			Console.WriteLine("---------------");
			Console.WriteLine("1. FWD");
			Console.WriteLine("2. RWD");
			Console.WriteLine("3. AWD");
			string Drivetrain = Console.ReadLine();
			if(Drivetrain == "1") {
				Drivetrain = "FWD";
			}else if (Drivetrain == "2") {
				Drivetrain = "RWD";
			}else if(Drivetrain == "3") {
				Drivetrain = "AWD";
			}
			Console.Clear();

			Console.WriteLine("Nedan visas bilar utifrån dina önskemål");
			List<CarInfo> PossibleCarChoices = CarInfo.MethodOfElimination(CarType, Gearbox, Fueltype, Drivetrain);
			for(int i = 0; i < PossibleCarChoices.Count; i++) {
				Console.WriteLine(PossibleCarChoices[i].CarModel);
			}

			Console.WriteLine("Välj din bil");
			string inputChosenCar = Console.ReadLine();
			int inputChosenCarAsInt = int.Parse(inputChosenCar);
			CarInfo ChosenCar = PossibleCarChoices[inputChosenCarAsInt - 1];

			
			return ChosenCar;
			
			
			
		}

		

		
	}
}
