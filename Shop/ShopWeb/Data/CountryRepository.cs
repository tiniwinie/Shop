namespace ShopWeb.Data
{
    using Entities;
    public class CountryRepository : GenericRepository<Country>, ICountryRepository
    {
        public CountryRepository(DataContext context) : base(context)
        {

        }
    }
}
