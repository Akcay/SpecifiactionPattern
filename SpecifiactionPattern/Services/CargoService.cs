using SpecificationPattern.Business;
using SpecificationPattern.Infra;
using SpecificationPattern.Models;

namespace SpecificationPattern.Services
{
    public class CargoService
    {
        OrderTypeIsReturnSpecification typeIsReturnSpecification;
        XPaysSpecification xPaysSpecification;
        CargoFeeGratherThanZeroSpecification cargoFeeGratherThanZeroSpecification;
        OrSpecification<CargoModel> orSpecification;
        AndSpecification<CargoModel> andSpecification;
        public CargoService()
        {
            typeIsReturnSpecification = new();
            xPaysSpecification = new();
            cargoFeeGratherThanZeroSpecification = new();
        }

        public async Task AddCargo(CargoModel cargoModel)
        {
            orSpecification = new(typeIsReturnSpecification, xPaysSpecification);
            andSpecification = new(cargoFeeGratherThanZeroSpecification, orSpecification);
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
