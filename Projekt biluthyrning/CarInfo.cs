using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_biluthyrning {
	internal class CarInfo : VehicleInfo {
		private int _horsePower;
		private double _fuelConsumption;
		private int _mileage;

		public int Horsepower {
			get {
				return _horsePower;
			}
			set {
				_horsePower = value;
			}
		}

		public double FuelConsumption {
			get {
				return _fuelConsumption;
			}
			set {
				_fuelConsumption = value;
			}
		}

		public int Mileage {
			get {
				return _mileage;
			}
			set {
				_mileage = value;
			}
		}

		/// <summary>
		/// En konstruktor
		/// </summary>
		/// <param name="inputHorsePower">gör möjlig input för hästkrafter</param>
		/// <param name="inputFuelConsumption">gör möjlig input för bränsleförbrukning</param>
		/// <param name="inputMileage">gör möjlig input för miltal</param>
		/// <param name="inputCarType">gör möjlig input för biltyp</param>
		/// <param name="inputGearbox">gör möjlig input för växellåda</param>
		/// <param name="inputFueltype">gör möjlig input för drivmedel</param>
		/// <param name="inputDrivetrain">gör möjlig input för drivlina</param>
		/// <param name="inputCarModel">gör möjlig input för bilmodell</param>
		public CarInfo(int inputHorsePower, double inputFuelConsumption, int inputMileage, string inputCarType, string inputGearbox, string inputFueltype, string inputDrivetrain, string inputCarModel) : base(inputCarType, inputGearbox, inputFueltype, inputDrivetrain, inputCarModel) {
			Horsepower = inputHorsePower;
			FuelConsumption = inputFuelConsumption;
			Mileage = inputMileage;
		}
		/// <summary>
		/// Lista med tillgängliga bilar
		/// </summary>
		static List<CarInfo> ListOfAvaiableCars = new List<CarInfo>() {
			new CarInfo(210, 0.88, 28000, "Sedan", "Manuell", "Bensin", "FWD", "Volvo S60"),
			new CarInfo(120, 0.7, 43000, "Kombi", "Automat", "Diesel", "RWD", "Volvo 945"),
			new CarInfo(260, 0.7, 25000, "SUV", "Automat", "Bensin", "AWD", "Ford Explorer"),
			new CarInfo(250, 0.95, 32000, "Sedan", "Automat", "Bensin", "FWD", "Ford Scorpio"),
			new CarInfo(200, 0.68, 19000, "Kombi", "Automat", "Diesel", "AWD", "Volvo V90"),
			new CarInfo(400, 0, 12000, "SUV", "Automat", "Elektrisk", "AWD", "Volvo EX30"),
			new CarInfo(220, 1.15, 20000, "SUV", "Manuell", "Bensin", "RWD", "Saab 900"),
			new CarInfo(170, 0.9, 36000, "Kombi", "Manuell", "CNG", "FWD", "Volvo V70"),
			new CarInfo(200, 1.2, 30000, "Kombi", "Automat", "Bensin", "RWD", "Volvo 744"),
			new CarInfo(140, 0.8, 50000, "Sedan", "Automat", "Diesel", "AWD", "Volvo S80")
		};

		/// <summary>
		/// Gör utesutningmetod beroende på vad användaren väljer
		/// </summary>
		/// <param name="inputCarType">gör möjlig input för biltyp</param>
		/// <param name="inputGearbox">gör möjlig input för växellåda</param>
		/// <param name="inputFueltype">gör möjlig input för drivmedel</param>
		/// <param name="inputDrivetrain">gör möjlig input för drivlina</param>
		/// <returns>
		/// Dem bilar som mathcar användarens val
		/// </returns>
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
