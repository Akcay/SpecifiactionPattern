namespace SpecificationPattern.Infra
{

    ///Tüm Specification sınıflarının arayüzü. IsSatisfiedBy metodu ile koşulların sağlanıp sağlanmadığını dönüyor.
    public interface ISpecification<T>
    {
        bool IsSatisfiedBy(T item);
    }
}
