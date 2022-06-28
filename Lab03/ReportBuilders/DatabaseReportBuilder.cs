using Lab03.Interfaces;
using Lab03.WorkDescrCreators;

namespace Lab03.ReportBuilders
{
    public class DatabaseReportBuilder : ReportBuilder, IWorkDescrChangable
    {
        public ICreateWorkDescr CreateWorkDescr { get; set; } = new DiagramCreator();

        public override void SetWorkDescr(string descr)
        {
            _resultBuilder.AppendLine("Work description.(diagram)");
            var workDescr = CreateWorkDescr.CreateWorkDescr(descr);
            _resultBuilder.AppendLine(workDescr.GetFullDescr());
            _resultBuilder.AppendLine("\n\n");
        }
    }
}
