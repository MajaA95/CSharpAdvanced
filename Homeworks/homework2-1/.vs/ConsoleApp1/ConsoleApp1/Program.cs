using ConsoleApp1.Entities;


Car Volvo = new Car("Volvo",2023);
CarCenter Center = new CarCenter();


Center.WashCar(Volvo);
Center.PumpGas(Volvo);
Center.CheckVehicle(Volvo);
Volvo.Drive();


Truck Some = new Truck("Some",2012);
Center.WashTrailer(Some);
Center.FixVehicle(Some);
Some.Drive();

