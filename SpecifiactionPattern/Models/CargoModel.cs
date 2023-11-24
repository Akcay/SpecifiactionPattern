using SpecificationPattern.Enums;

namespace SpecificationPattern.Models
{
    public class CargoModel
    {
        public OrderType OrderType { get; set; }
        public int CargoFee { get; set; }
        public CargoPayType CargoType { get; set; }
    }
}