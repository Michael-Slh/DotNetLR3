using Lab03.Interfaces;
using Lab03.ReportBuilders;

class Program
{
    static void Main()
    {
        Realize();
    }

    public static void Realize()
    {
        var finished = false;
        while (!finished)
        {
            Console.WriteLine("0-3");
            string? opt = Console.ReadLine();
            if (opt is null || !int.TryParse(opt, out int result) || result < 0 || result > 3)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong option. Try again.");
                Console.ForegroundColor = ConsoleColor.Gray;
                continue;
            }
            string report;
            switch (result)
            {
                case 1:
                    Console.WriteLine("Programming report. \n");
                    report = GetProgrammingReport();
                    Console.WriteLine(report);
                    break;
                case 2:
                    Console.WriteLine("Database report. \n");
                    report = GetDatabaseReport();
                    Console.WriteLine(report);
                    break;
                case 3:
                    Console.WriteLine("Networks report. \n");
                    report = GetNetworksReport();
                    Console.WriteLine(report);
                    break;
                case 0:
                    finished = true;
                    break;
            }
            Console.Write("Press any button to continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }

    public static string GetProgrammingReport()
    {
        IReportBuilder reportBuilder = new ProgrammingReportBuilder();

        reportBuilder.SetTitle(1, "Michael", "Salikhov");
        reportBuilder.SetGoal("Some programming goal.");
        reportBuilder.SetTask("Some programming task.");
        reportBuilder.SetTheoretical("Some programming theory.");
        reportBuilder.SetWorkDescr("using Lab03.Interfaces;namespace Lab03.WorkDescr{public class Code : IWorkDescr{private readonly string _res;public Code(string res){_res = res;}public string GetFullDescr(){return _res;}}}");
        reportBuilder.SetResult("Some programming results.");
        reportBuilder.SetWorkAnalysis("Some programming work analysis.");
        reportBuilder.SetConclusion("Some work conclusion for programming.");
        return reportBuilder.GetResult();
    }

    public static string GetDatabaseReport()
    {
        IReportBuilder reportBuilder = new DatabaseReportBuilder();

        reportBuilder.SetTitle(4, "Max", "Chaliy");
        reportBuilder.SetGoal("Some database goal.");
        reportBuilder.SetTask("Some database task.");
        reportBuilder.SetTheoretical("Some database theory.");
        reportBuilder.SetWorkDescr("{\"Many-to-many\":47,\"One-to-one\":81,\"Many-to-one\":14}");
        reportBuilder.SetResult("Some database results.");
        reportBuilder.SetWorkAnalysis("Some database work analysis.");
        reportBuilder.SetConclusion("Some work conclusion for database.");
        return reportBuilder.GetResult();
    }

    public static string GetNetworksReport()
    {
        IReportBuilder reportBuilder = new NetworksReportBuilder();

        reportBuilder.SetTitle(5, "Katherine", "Salikhova");
        reportBuilder.SetGoal("Some networks goal.");
        reportBuilder.SetTask("Some networks task.");
        reportBuilder.SetTheoretical("Some networks theory.");
        reportBuilder.SetWorkDescr("[\"PC8\",\"PC3\",\"PC1\"]");
        reportBuilder.SetResult("Some networks results.");
        reportBuilder.SetWorkAnalysis("Some networks work analysis.");
        reportBuilder.SetConclusion("Some work conclusion for networks.");
        return reportBuilder.GetResult();
    }
}
