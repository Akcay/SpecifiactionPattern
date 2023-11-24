using SpecificationPattern.Business;
using SpecificationPattern.Infra;
using SpecificationPattern.Models;

namespace SpecificationPattern.Services
{
    public class CargoService
    {
        public async Task AddCargo(CargoModel cargoModel)
        {
            OrderTypeIsReturnSpecification typeIsReturnSpecification = new();
            XPaysSpecification xPaysSpecification = new();
            CargoFeeGratherThanZeroSpecification cargoFeeGratherThanZeroSpecification = new();
            OrSpecification<CargoModel> orSpecification = new(typeIsReturnSpecification, xPaysSpecification);
            AndSpecification<CargoModel> andSpecification = new(cargoFeeGratherThanZeroSpecification, orSpecification);

            if (andSpecification.IsSatisfiedBy(cargoModel))
            {
                await Console.Out.WriteLineAsync($"Insert işlemi yapıldı. OrderType:{cargoModel.OrderType} CargoType:{cargoModel.CargoType} CargoFee:{cargoModel.CargoFee}");
            }
            else
            {
                await Console.Out.WriteLineAsync($"Insert işlemi yapılamadı. OrderType:{cargoModel.OrderType} CargoType:{cargoModel.CargoType} CargoFee:{cargoModel.CargoFee}");
            }
        }
    }
}
