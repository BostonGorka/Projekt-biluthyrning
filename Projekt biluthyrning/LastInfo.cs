﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_biluthyrning {
	internal class LastInfo{
		Booking bookingSum;
		CarInfo carSum;

		/// <summary>
		/// Summering av bookingSum samt carSum (det användaren matat in)
		/// </summary>
		/// <param name="bookingSum">innehåller användarens kontaktuppgifter</param>
		/// <param name="carSum">innehåller användarens specifikationer på hyrbilen</param>
		public void Summary(Booking bookingSum, CarInfo carSum) {
			Console.WriteLine("Summering av bokingsuppgifter");
			Console.WriteLine("Namn: " + bookingSum.Name);
			Console.WriteLine("Ålder: " + bookingSum.Age);
			Console.WriteLine("Address: " + bookingSum.Address);
			Console.WriteLine("Telefonnummer: " + bookingSum.Phonenumber);
			Console.WriteLine("Hämtningsdatum för din hyrbil: " + bookingSum.PickUpDate);
			Console.WriteLine("Återlämningsdatum för din hyrbil: " + bookingSum.EndDate);
			Console.WriteLine("Hämtningsplats: " + bookingSum.PickUpPlace);

			Console.WriteLine("Summering av din utvalda hyrbil");
			Console.WriteLine("biltypen: " + carSum.CarType);
			Console.WriteLine("Drivmedel: " + carSum.Fueltype);
			Console.WriteLine("Växellåda: " + carSum.Gearbox);
			Console.WriteLine("Drivlina: " + carSum.Drivetrain);
			Console.WriteLine("Bilmodelen: " + carSum.CarModel);
			

		}

	}
}
