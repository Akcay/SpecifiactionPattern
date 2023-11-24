using SpecificationPattern.Infra;
using SpecificationPattern.Models;

namespace SpecificationPattern.Business
{
    public class CargoFeeGratherThanZeroSpecification : ISpecification<CargoModel>
    {
        public bool IsSatisfiedBy(CargoModel cargoModel)
        {
            return cargoModel.CargoFee > 0;
        }
    }
}
