using GoodCode.Library;

namespace GoodCode
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TimeSheetEntry> timeSheetEntries = loadWorkEntries();
            CompanyRepository companyRepository = new CompanyRepository();
            CompanyService companyService = new CompanyService(companyRepository);
            companyService.SendMailToCompanies(timeSheetEntries);
            var paymentForExtra = companyService.GetBillForExtraTime(timeSheetEntries, maxHourInAWeek: 40);
            Console.WriteLine($"You will get paid ${paymentForExtra} for your work.");
            Console.WriteLine();
            Console.Write("Press any key to exit application...");
            Console.ReadKey();
        }
        private static List<TimeSheetEntry> loadWorkEntries()
        {

            List<TimeSheetEntry> timeSheetEntries = new List<TimeSheetEntry>();
            string answer = string.Empty;
            do
            {
                Console.Write("Enter what you did: ");
                string workDescription = Console.ReadLine();
                double timeForWork = getTimeForWorkFromUser();

                TimeSheetEntry timeSheetEntry = new TimeSheetEntry
                {
                    HoursWorked = timeForWork,
                    WorkDone = workDescription
                };
                timeSheetEntries.Add(timeSheetEntry);
                Console.Write("Do you want to enter more time (yes/no): ");
                answer = Console.ReadLine();

            } while (answer.ToLower() == UserAnswer.Yes);





            return timeSheetEntries;
        }

        private static double getTimeForWorkFromUser()
        {
            double timeForWork;
            string rawTimeWorked = string.Empty;
            bool isParsedToDouble = false;

            do
            {
                Console.Write("How long did you do it for: ");
                rawTimeWorked = Console.ReadLine();
                isParsedToDouble = double.TryParse(rawTimeWorked, out timeForWork);
                if (!isParsedToDouble)
                {
                    Console.WriteLine("Invalid input!");
                }

            } while (!isParsedToDouble);

            return timeForWork;
        }
    }



    public class UserAnswer
    {
        public const string Yes = "yes";
        public const string No = "no";


    }


}