namespace SpecificationPattern.Infra
{
    ///veya(|) operatörünü sağlayacak Specification sınıfı. Çoklu Specification işlemlerini tek sınıftan oluşturabilmek adına params keyword ünü kullandım.
    ///IsSatisfiedBy metodunda ise uyan bir koşulun olması halinde true dönüyor. Tüm koşullar sağlanmadıysa false dönüyor.
    public class OrSpecification<T> : ISpecification<T>
    {
        private readonly ISpecification<T>[] _specifications;

        public OrSpecification(params ISpecification<T>[] specifications)
        {
            _specifications = specifications;
        }

        public bool IsSatisfiedBy(T item)
        {
            foreach (var specification in _specifications)
            {
                if (specification.IsSatisfiedBy(item))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
