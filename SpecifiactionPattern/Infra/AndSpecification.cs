namespace SpecificationPattern.Infra
{
    ///ve(&) operatörünü sağlayacak Specification sınıfı. Çoklu Specification işlemlerini tek sınıftan oluşturabilmek adına params keyword ünü kullandım.
    ///IsSatisfiedBy metodunda ise uymayan bir koşulun olması halinde false dönüyor. Tüm koşullar sağlanırsa true dönüyor.
    public class AndSpecification<T> : ISpecification<T>
    {
        private readonly ISpecification<T>[] _specifications;

        public AndSpecification(params ISpecification<T>[] specifications)
        {
            _specifications = specifications;
        }

        public bool IsSatisfiedBy(T item)
        {
            foreach (var specification in _specifications)
            {
                if (!specification.IsSatisfiedBy(item))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
