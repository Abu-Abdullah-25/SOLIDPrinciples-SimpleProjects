public class ReportGenerator
{
    private IReport _ReportGenerator;


    public ReportGenerator(IReport reportGenerator)
    {
        // Direct dependency on interface or abstract class (High-level module)
        _ReportGenerator = reportGenerator;

    }

    public void GenerateReport()
    {
        _ReportGenerator.Generate();
    }



}
