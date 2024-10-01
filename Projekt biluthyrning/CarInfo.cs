using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_biluthyrning {
	internal class CarInfo : VehicleInfo {
		protected int HorsePower;
		protected double FuelConsumption;
		protected int Mileage;

		public CarInfo(int inputHorsePower, double inputFuelConsumption, int inputMileage, string inputCarType, string inputGearbox, string inputFueltype, string inputDrivetrain) : base(inputCarType, inputGearbox, inputFueltype, inputDrivetrain) {
			inputHorsePower = HorsePower;
			inputFuelConsumption = FuelConsumption;
			inputMileage = Mileage;
		}

		List<CarInfo> ListOfAvaiableCars = new List<CarInfo>() {
			new CarInfo(210, 0.88, 28000, "Sedan", "Manual", "Petrol", "FWD"),
			new CarInfo(170, 0.7, 43000, "Combi", "Automatic", "Diesel", "RWD"),
			new CarInfo(260, 0.7, 25000, "SUV", "Automatic", "Petrol", "AWD"),
			new CarInfo(300, 0.95, 32000, "Sedan", "Automatic", "Petrol", "FWD"),
			new CarInfo(200, 0.68, 19000, "Combi", "Automatic", "Diesel", "AWD"),
			new CarInfo(400, 0, 12000, "SUV", "Automatic", "Electric", "AWD"),
			new CarInfo(220, 1.15, 20000, "SUV", "Manual", "Petrol", "RWD"),
			new CarInfo(170, 0.9, 36000, "Combi", "Manual", "CNG", "FWD"),
		};

		public List<CarInfo> MethodOfElimination(string inputCarType, string inputGearbox, string inputFueltype, string inputDrivetrain) {
			List<CarInfo> AvailableCars = new List<CarInfo>();
			for(int i = 0; i <= ListOfAvaiableCars.Count; i++) {
				if (ListOfAvaiableCars[i].CarType == inputCarType && ListOfAvaiableCars[i].Gearbox == inputGearbox && ListOfAvaiableCars[i].Fueltype == inputFueltype && ListOfAvaiableCars[i].Drivetrain == inputDrivetrain) {
					AvailableCars.Add(ListOfAvaiableCars[i]);
				}
			}
			return AvailableCars;
			
		}
		



	}
}
