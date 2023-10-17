namespace GoodCode.Library
{
    public interface ICompanyRepository
    {
        IEnumerable<Company> GetAll();
    }

    public class CompanyRepository : ICompanyRepository
    {
        public IEnumerable<Company> GetAll()
        {
            return new List<Company> {
                new Company { Name = "acme", HourlyPrice = 150 },
                new Company { Name = "abc", HourlyPrice = 125 }
            };
        }
    }
}
