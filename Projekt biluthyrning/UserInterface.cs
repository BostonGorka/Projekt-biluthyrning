using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_biluthyrning {
	internal class UserInterface {


		/// <summary>
		/// Bygger upp sammanfattningen av bokning samt specifikationer på bil
		/// </summary>
		public void StartPage() {
			Console.WriteLine("-------------------------------------------------------------------");
			Console.WriteLine("Välkommen till Carrent.com, vi har dem bästa hyrbilarna på marknaden");
			Console.WriteLine("-------------------------------------------------------------------");
			Console.WriteLine("Klicka på valfri tangent för att fortsätta");

			Console.ReadKey();
			Console.Clear();

			Booking bookingLastInfo = BookingSpecifications();

			CarInfo vehicleSpecifications = VehicleBooking();

			LastInfo lastInfo = new LastInfo();
			lastInfo.Summary(bookingLastInfo, vehicleSpecifications);

			Console.WriteLine("Är du säker på att du vill slutföra bokning");
			string confirmBooking = Console.ReadLine().ToLower();
			while (confirmBooking == "" ) {

				Console.WriteLine("Ogiltig input försök igen");
				confirmBooking = Console.ReadLine();
			}
			if (confirmBooking == "ja") {
				Console.Clear();
				Console.WriteLine("Din bokning är slutförd");
			} else if (confirmBooking == "nej") {
				Console.WriteLine("Din bokning avbröts");
			}
		}

		/// <summary>
		/// Låter användaren göra inputs om sin bokning
		/// </summary>
		/// <returns>användarens inputs för bokning</returns>
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
			while (!int.TryParse(inputAge, out age) || age < 18) {
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
			while (inputPickUpPlace == "" || (inputPickUpPlace != "Stockholm" && inputPickUpPlace != "Göteborg" && inputPickUpPlace != "Malmö")) {
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

			Console.WriteLine("Skriv in återlämningsdatumet för ditt hyrfordon (Dag/månad)");
			string inputEndDate = Console.ReadLine();
			while (inputEndDate == "") {
				Console.WriteLine("Ogiltig input, försök igen");
				inputEndDate = Console.ReadLine();

			}
			Console.Clear();



			Booking booking = new Booking(inputName, age, inputAddress, phoneNumber, inputPickUpPlace, inputPickupDate, inputEndDate);
			return booking;
		}


		/// <summary>
		/// Låter användaren specificera sin hrybil
		/// </summary>
		/// <returns>Bilarna som passar användaren bäst</returns>
		public CarInfo VehicleBooking() {
			Console.WriteLine("Välj mellan dessa karosstyper genom dessa nummer");
			Console.WriteLine("------------------------------");
			Console.WriteLine("1. Sedan");
			Console.WriteLine("2. Kombi");
			Console.WriteLine("3. SUV");
			string CarType = Console.ReadLine();
			if (CarType == "1") {
				CarType = "Sedan";
			} else if (CarType == "2") {
				CarType = "Kombi";
			} else if (CarType == "3") {
				CarType = "SUV";
			} else if (CarType == "") {
				Console.WriteLine("Ogiltig input, försök igen");
				CarType = Console.ReadLine();
			} else {
				Console.WriteLine("Ogiltig input, försök igen");
				CarType = Console.ReadLine();
			}
			Console.Clear();

			Console.WriteLine("Välj mellan dessa drivmedel genom dessa nummer");
			Console.WriteLine("---------------------------");
			Console.WriteLine("1. Bensin");
			Console.WriteLine("2. Diesel");
			Console.WriteLine("3. Elektrisk");
			Console.WriteLine("4. CNG");
			string Fueltype = Console.ReadLine();

			if (Fueltype == "1") {
				Fueltype = "Bensin";
			} else if (Fueltype == "2") {
				Fueltype = "Diesel";
			} else if (Fueltype == "3") {
				Fueltype = "Elektrisk";
			} else if (Fueltype == "4") {
				Fueltype = "CNG";
			} else if (Fueltype == "") {
				Console.WriteLine("Ogiltig input, försök igen");
				Fueltype = Console.ReadLine();
			} else {
				Console.WriteLine("Ogiltig input, försök igen");
				Fueltype = Console.ReadLine();
			}
			Console.Clear();

			Console.WriteLine("Välj din växellåda genom dessa nummer");
			Console.WriteLine("-------------------");
			Console.WriteLine("1. Manuell");
			Console.WriteLine("2. Automat");
			string Gearbox = Console.ReadLine();

			if (Gearbox == "1") {
				Gearbox = "Manuell";
			} else if (Gearbox == "2") {
				Gearbox = "Automat";
			} else if (Gearbox == "") {
				Console.WriteLine("Ogiltig input, försök igen");
				Gearbox = Console.ReadLine();
			} else if (Gearbox == "") {
				Console.WriteLine("Ogiltig input, försök igen");
				Gearbox = Console.ReadLine();
			} else {
				Console.WriteLine("Ogiltig input, försök igen");
				Gearbox = Console.ReadLine();
			}
			Console.Clear();

			Console.WriteLine("Välj drivlina genom dessa nummer");
			Console.WriteLine("---------------");
			Console.WriteLine("1. FWD");
			Console.WriteLine("2. RWD");
			Console.WriteLine("3. AWD");
			string Drivetrain = Console.ReadLine();
			if (Drivetrain == "1") {
				Drivetrain = "FWD";
			} else if (Drivetrain == "2") {
				Drivetrain = "RWD";
			} else if (Drivetrain == "3") {
				Drivetrain = "AWD";
			} else if (Drivetrain == "") {
				Console.WriteLine("Ogiltig input, försök igen");
				Drivetrain = Console.ReadLine();
			} else {
				Console.WriteLine("Ogiltig input, försök igen");
				Drivetrain = Console.ReadLine();
			}
			Console.Clear();

			Console.WriteLine("Nedan visas bilar utifrån dina önskemål:");
			List<CarInfo> PossibleCarChoices = CarInfo.MethodOfElimination(CarType, Gearbox, Fueltype, Drivetrain);
			for (int i = 0; i < PossibleCarChoices.Count; i++) {
				Console.WriteLine(i + 1 + ": " + PossibleCarChoices[i].CarModel);
			}

			Console.WriteLine("Välj din bil");
			string inputChosenCar = Console.ReadLine();
			int inputChosenCarAsInt = int.Parse(inputChosenCar);
			CarInfo ChosenCar = PossibleCarChoices[inputChosenCarAsInt - 1];

			Console.Clear();
			return ChosenCar;





		}




	}
}
