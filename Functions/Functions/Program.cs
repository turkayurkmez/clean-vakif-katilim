// See https://aka.ms/new-console-template for more information
using Functions;

Console.WriteLine("Hello, World!");

//Bir fonksiyon sadece bir iş yapmalıdır!

try
{
    ReportGenerator reportGenerator = new ReportGenerator("C:\\x.xlsx");
    var report = reportGenerator.CreateReport();
    Console.WriteLine(report.Title);
}
catch (Exception e)
{

    throw e;
}



int add(int x, int y)
{
    return x + y;
}


/*
 * DRY: Don't repeat yourself
 * 
 *  1. En az koddan oluşmalı (mümkün olduğu kadar)
 *  2. parametresi ne kadar az o kadar iyi
 *  3. Birim zamanda sadece bir iş yapmalı.
 */