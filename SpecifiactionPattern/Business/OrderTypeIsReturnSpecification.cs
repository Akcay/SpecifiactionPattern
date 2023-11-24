using SpecificationPattern.Enums;
using SpecificationPattern.Infra;
using SpecificationPattern.Models;

namespace SpecificationPattern.Business
{

    public class OrderTypeIsReturnSpecification : ISpecification<CargoModel>
    {
        public bool IsSatisfiedBy(CargoModel cargoModel)
        {
            return cargoModel.OrderType == OrderType.Return;
        }
    }
}
