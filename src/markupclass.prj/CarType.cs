using System;
using System.Drawing;

namespace MarkupClass
{
	public enum CarType
	{
		Car = 0,
		CarWithTrailer,
		MiniTruck,
		Truck,
		BigTruck,
		Hauler,
		MiniBus,
		Bus, 
		LongBus,
		Bike,
		SpecialCar,
		EmergencyCar,
		NoClass,
	}

	public class GetNameClass
	{

		public CarType CarType { get; }

		public GetNameClass(CarType carType)
		{
			CarType = carType;
		}

		public GetNameClass(int IdcarType)
		{
			CarType = (CarType)IdcarType;
		}

		public override string ToString()
		{
			switch(CarType)
			{

				case CarType.Car:
					return "Car";
				case CarType.CarWithTrailer:
					return "CarWithTrailer";
				case CarType.MiniTruck:
					return "MiniTruck";
				case CarType.Truck:
					return "Truck";
				case CarType.BigTruck:
					return "BigTruck";
				case CarType.Hauler:
					return "Hauler";
				case CarType.MiniBus:
					return "MiniBus";
				case CarType.Bus:
					return "Bus";
				case CarType.LongBus:
					return "LongBus";
				case CarType.Bike:
					return "Bike";
				case CarType.SpecialCar:
					return "SpecialCar";
				case CarType.EmergencyCar:
					return "EmergencyCar";
				case CarType.NoClass:
					return "NoClass";
			}
			return "XZt" + base.ToString();
		}
		public Color ToColor()
		{
			switch(CarType)
			{

				case CarType.Car:
					return Color.Red;
				case CarType.CarWithTrailer:
					return Color.DarkRed;
				case CarType.MiniTruck:
					return Color.Blue;
				case CarType.Truck:
					return Color.BlueViolet;
				case CarType.BigTruck:
					return Color.DarkBlue;
				case CarType.Hauler:
					return Color.DeepSkyBlue;
				case CarType.MiniBus:
					return Color.Green;
				case CarType.Bus:
					return Color.DarkGreen;
				case CarType.LongBus:
					return Color.YellowGreen;
				case CarType.Bike:
					return Color.Orange;
				case CarType.SpecialCar:
					return Color.Aqua;
				case CarType.EmergencyCar:
					return Color.Coral;
				case CarType.NoClass:
					return Color.Black; ;
			}
			return Color.Black;
		}
	}

}
