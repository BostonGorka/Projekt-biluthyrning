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

		public VehicleInfo(string inputCarType, string inputGearbox, string inputFueltype, string inputDrivetrain, string inputCarModel) {
			CarType = inputCarType;
			Gearbox = inputGearbox;
			Fueltype = inputFueltype;
			Drivetrain = inputDrivetrain;
			CarModel = inputCarModel;
		}
	}
}
