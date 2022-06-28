using Lab03.Interfaces;
using Lab03.WorkDescrCreators;

namespace Lab03.ReportBuilders
{
    public class ProgrammingReportBuilder : ReportBuilder, IWorkDescrChangable
    {
        public ICreateWorkDescr CreateWorkDescr { get; set; } = new CodeCreator();

        public override void SetWorkDescr(string descr)
        {
            _resultBuilder.AppendLine("Work description.(code)");
            var workDescr = CreateWorkDescr.CreateWorkDescr(descr);
            _resultBuilder.AppendLine(workDescr.GetFullDescr());
            _resultBuilder.AppendLine("\n\n");
        }
    }
}
