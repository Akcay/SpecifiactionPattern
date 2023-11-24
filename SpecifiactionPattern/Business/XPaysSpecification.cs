using SpecificationPattern.Enums;
using SpecificationPattern.Infra;
using SpecificationPattern.Models;

namespace SpecificationPattern.Business
{
    public class XPaysSpecification : ISpecification<CargoModel>
    {
        public bool IsSatisfiedBy(CargoModel cargoModel)
        {
            return cargoModel.CargoType == CargoPayType.XPays;
        }
    }
}
