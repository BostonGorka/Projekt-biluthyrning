using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_biluthyrning {
	internal class VehicleInfo {
		public string CarType;
		public string Gearbox;
		public string Fueltype;
		public string Drivetrain;
		public string CarModel;
		/// <summary>
		/// En konstruktor
		/// </summary>
		/// <param name="inputCarType">Gör möjlig input för biltyp</param>
		/// <param name="inputGearbox">Gör möjlig input för växellåda</param>
		/// <param name="inputFueltype">Gör möjlig input för drivmedel</param>
		/// <param name="inputDrivetrain">Gör möjlig input för drivlina</param>
		/// <param name="inputCarModel">Gör möjlig input för bilmodell</param>
		public VehicleInfo(string inputCarType, string inputGearbox, string inputFueltype, string inputDrivetrain, string inputCarModel) {
			CarType = inputCarType;
			Gearbox = inputGearbox;
			Fueltype = inputFueltype;
			Drivetrain = inputDrivetrain;
			CarModel = inputCarModel;
		}
	}
}
