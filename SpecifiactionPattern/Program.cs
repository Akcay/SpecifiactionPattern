using SpecificationPattern.Enums;
using SpecificationPattern.Models;
using SpecificationPattern.Services;

var cargoService = new CargoService();

var cargoModel1 = new CargoModel { CargoFee = 20, CargoType = CargoPayType.XPays, OrderType = OrderType.Return };
cargoService.AddCargo(cargoModel1);

var cargoModel2 = new CargoModel { CargoFee = 0, CargoType = CargoPayType.XPays, OrderType = OrderType.Return };
cargoService.AddCargo(cargoModel2);

var cargoModel3 = new CargoModel { CargoFee = 10, CargoType = CargoPayType.YPays, OrderType = OrderType.Sales };
cargoService.AddCargo(cargoModel3);