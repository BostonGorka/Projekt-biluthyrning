using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_biluthyrning {
	internal class Program {
		static void Main(string[] args) {
			
			Console.WriteLine("Skriv in ditt för samt efternamn");
			string inputName = Console.ReadLine();
			while(inputName == ""){
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
			while(inputAddress == "") {
				Console.WriteLine("Ogiltig input, försök igen");
				string inputAddress = Console.ReadLine();

			}
			Console.Clear();

			Console.WriteLine("skriv in ditt telefonnummer");
			int inputPhoneNumber = int.Parse(Console.ReadLine());

			Console.Clear();

			Console.WriteLine("Välj upphämtningsplats: Stockholm, Göteborg eller Malmö");
			string inputPickUpPlace = Console.ReadLine();

			Console.Clear();

			Console.WriteLine("Skriv in hämtdatumet för ditt hyrfordon / DD Month");
			string inputPickupDate = Console.ReadLine();

			Console.Clear();

			Console.WriteLine("Skriv in återlämningsdatumet för ditt hyrfordon");
			string inputEndDate = Console.ReadLine();

			Console.Clear();

			//Booking booking = new Booking(inputName, inputAge, inputAddress, inputPhoneNumber, inputPickUpPlace, inputPickupDate, inputEndDate);
			

			

		}
	}
}
