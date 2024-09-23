using System;


class Program
{
    static void Main(string[] args)
    {
        // Client code
        ReportGenerator reportGenerator = new ReportGenerator(new PdfReportGenerator());
        reportGenerator.GenerateReport();

        reportGenerator = new ReportGenerator(new ExcelReportGenerator());
        reportGenerator.GenerateReport();

        reportGenerator = new ReportGenerator(new WordReportGenerator());
        reportGenerator.GenerateReport();

        Console.ReadKey();

    }
}