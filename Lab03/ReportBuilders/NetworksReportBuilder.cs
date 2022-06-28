using Lab03.Interfaces;
using Lab03.WorkDescrCreators;

namespace Lab03.ReportBuilders
{
    public class NetworksReportBuilder : ReportBuilder, IWorkDescrChangable
    {
        public ICreateWorkDescr CreateWorkDescr { get; set; } = new SchemeCreator();

        public override void SetWorkDescr(string descr)
        {
            _resultBuilder.AppendLine("Work description.(scheme)");
            var workDescr = CreateWorkDescr.CreateWorkDescr(descr);
            _resultBuilder.AppendLine(workDescr.GetFullDescr());
            _resultBuilder.AppendLine("\n\n");
        }
    }
}
