namespace Functions
{

    public class Report
    {
        public string Title { get; set; }
    }
    public class ReportGenerator
    {
        /*
         * 1. Bu sınıfın instance'i belirtilen bir Excel dosyasındaki verileri okuyarak, raport nesnesi üretir.
         */


        //One job at a time
        public Report CreateReport()
        {
            return new Report { Title = "No Name" };
        }

        public string FilePath { get; set; }

        private bool exceFileIsExists(string path) => File.Exists(path);



        private bool isFormatAvailable(string path)
        {

            return Convert.ToBoolean(new Random().Next(0, 2));

        }

        private bool isValidated(string path) =>
            !exceFileIsExists(path) &&
            !isFormatAvailable(path);



        public ReportGenerator(string path)
        {
            validateFile(path);
            FilePath = path;
        }

        private void validateFile(string path)
        {
            if (!isValidated(path))
            {
                throw new FileNotFoundException();
            }
        }
    }
}
