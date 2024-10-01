using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_biluthyrning {
	internal class UserInterface {
		VehicleInfo vehicleInfo;

	   public void StartPage() {
			Console.WriteLine("-----------------------------------------");
			Console.WriteLine("Welcome, we have very good rental cars here at CarRentCenter.Com");
			Console.WriteLine("--------------------------------------------");
			Console.WriteLine("Press any key to continue to booking");
			Console.ReadKey();

			Console.Clear();

		}
	}
}
