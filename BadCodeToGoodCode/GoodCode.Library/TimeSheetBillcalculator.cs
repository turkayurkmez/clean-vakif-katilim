namespace GoodCode.Library
{
    public class TimeSheetBillcalculator
    {
        public double GetBillForExtraTime(List<TimeSheetEntry> timeSheetEntries, int maxHourInAWeek)
        {
            double totalWorkedHours = 0;
            double extraPayment = 15;
            double normalPayment = 10;

            for (int i = 0; i < timeSheetEntries.Count; i++)
            {
                totalWorkedHours += timeSheetEntries[i].HoursWorked;
            }

            if (totalWorkedHours > maxHourInAWeek)
            {
                var paymentForMoreThanHourOfAWeek = (totalWorkedHours - maxHourInAWeek) * extraPayment;
                var paymentIncludeNormalTime = maxHourInAWeek * normalPayment;
                return paymentForMoreThanHourOfAWeek + paymentIncludeNormalTime;
            }
            else
            {
                return totalWorkedHours * normalPayment;

            }
        }

        public double CalculateBillForCompany(List<TimeSheetEntry> timeSheetEntries, Company companyInfo)
        {
            double totalWorkedHours = 0;

            for (int i = 0; i < timeSheetEntries.Count; i++)
            {
                if (timeSheetEntries[i].WorkDone.ToLower().Contains(companyInfo.Name))
                {
                    totalWorkedHours += timeSheetEntries[i].HoursWorked;
                }
            }
            return totalWorkedHours;


        }
    }
}
