namespace GoodCode.Library
{
    public class CompanyService
    {
        private TimeSheetBillcalculator timeSheetBillcalculator = new TimeSheetBillcalculator();
        private readonly ICompanyRepository companyRepository;

        public CompanyService(ICompanyRepository companyRepository)
        {
            this.companyRepository = companyRepository;
        }

        public void SendMailToCompanies(List<TimeSheetEntry> timeSheetEntries)
        {
            var companies = companyRepository.GetAll().ToList();
            MailSender mailSender = new MailSender();
            mailSender.SendMailToCompanies(companies, timeSheetEntries, timeSheetBillcalculator);
        }

        public double GetBillForExtraTime(List<TimeSheetEntry> timeSheetEntries, int maxHourInAWeek)
        {
            return timeSheetBillcalculator.GetBillForExtraTime(timeSheetEntries, maxHourInAWeek);
        }




    }
}
