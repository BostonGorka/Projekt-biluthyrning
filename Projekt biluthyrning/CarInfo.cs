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

		public CarInfo(int inputHorsePower, double inputFuelConsumption, int inputMileage, string inputCarType, string inputGearbox, string inputFueltype, string inputDrivetrain, string inputCarModel) : base(inputCarType, inputGearbox, inputFueltype, inputDrivetrain, inputCarModel) {
			inputHorsePower = HorsePower;
			inputFuelConsumption = FuelConsumption;
			inputMileage = Mileage;
		}

		static List<CarInfo> ListOfAvaiableCars = new List<CarInfo>() {
			new CarInfo(210, 0.88, 28000, "Sedan", "Manuell", "Bensin", "FWD", "Volvo S60"),
			new CarInfo(120, 0.7, 43000, "Kombi", "Automat", "Diesel", "RWD", "Volvo 945"),
			new CarInfo(260, 0.7, 25000, "SUV", "Automat", "Bensin", "AWD", "Ford Explorer"),
			new CarInfo(250, 0.95, 32000, "Sedan", "Automat", "Bensin", "FWD", "Ford Scorpio"),
			new CarInfo(200, 0.68, 19000, "Kombi", "Automat", "Diesel", "AWD", "Volvo V90"),
			new CarInfo(400, 0, 12000, "SUV", "Automat", "Elektrisk", "AWD", "Volvo EX30"),
			new CarInfo(220, 1.15, 20000, "SUV", "Manuell", "Bensin", "RWD", "Saab 900"),
			new CarInfo(170, 0.9, 36000, "Kombi", "Manuell", "CNG", "FWD", "Volvo V70"),
		};

		public static List<CarInfo> MethodOfElimination(string inputCarType, string inputGearbox, string inputFueltype, string inputDrivetrain) {
			List<CarInfo> AvailableCars = new List<CarInfo>();
			for(int i = 0; i < ListOfAvaiableCars.Count; i++) {
				if (ListOfAvaiableCars[i].CarType == inputCarType && ListOfAvaiableCars[i].Gearbox == inputGearbox && ListOfAvaiableCars[i].Fueltype == inputFueltype && ListOfAvaiableCars[i].Drivetrain == inputDrivetrain) {
					AvailableCars.Add(ListOfAvaiableCars[i]);
				}
			}
			return AvailableCars;
			
		}
		



	}
}
