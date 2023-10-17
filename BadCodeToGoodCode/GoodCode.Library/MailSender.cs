namespace GoodCode.Library
{
    public class MailSender
    {
        public void SendMailToCompanies(List<Company> companies, List<TimeSheetEntry> timeSheetEntries, TimeSheetBillcalculator timeSheetBillcalculator)
        {

            companies.ForEach(company =>
            {
                var totalWorked = timeSheetBillcalculator.CalculateBillForCompany(timeSheetEntries, company);
                sendMail(company, totalWorked);
            });
        }

        private void sendMail(Company company, double totalWorkedHours)
        {
            Console.WriteLine($"Simulating Sending email to {company.Name}");
            Console.WriteLine("Your bill is $" + (totalWorkedHours * company.HourlyPrice) + " for the hours worked.");
        }
    }
}
