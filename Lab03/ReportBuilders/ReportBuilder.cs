using Lab03.Interfaces;
using System.Text;

namespace Lab03.ReportBuilders
{
    public abstract class ReportBuilder : IReportBuilder
    {
        protected readonly StringBuilder _resultBuilder = new();
        public virtual string GetResult()
        {
            return _resultBuilder.ToString();
        }

        public virtual void Reset()
        {
            _resultBuilder.Length = 0;
        }

        public virtual void SetConclusion(string conclusion)
        {
            _resultBuilder.AppendLine("Final conclusion.");
            _resultBuilder.AppendLine(conclusion);
        }

        public virtual void SetGoal(string goal)
        {
            _resultBuilder.AppendLine("Goal of this Lab is.");
            _resultBuilder.AppendLine(goal);
            _resultBuilder.AppendLine("\n\n");
        }

        public virtual void SetResult(string result)
        {
            _resultBuilder.AppendLine("Result of Lab.");
            _resultBuilder.AppendLine(result);
            _resultBuilder.AppendLine("\n\n");
        }

        public virtual void SetTask(string task)
        {
            _resultBuilder.AppendLine("Task of this Lab:");
            _resultBuilder.AppendLine(task);
            _resultBuilder.AppendLine("\n\n");
        }

        public virtual void SetTheoretical(string theory)
        {
            _resultBuilder.AppendLine("Theoretical part.");
            _resultBuilder.AppendLine(theory);
            _resultBuilder.AppendLine("\n\n");
        }

        public virtual void SetTitle(int reportNumber, string name, string surname)
        {
            var uni = "National technical university";
            var kafedra = "ASOIU";
            var lab = $"Lab number {reportNumber} \nFor subject of networks";
            var owner = $"Done by {name} {surname}";

            _resultBuilder.AppendLine(uni);
            _resultBuilder.AppendLine(kafedra);
            _resultBuilder.AppendLine();
            _resultBuilder.AppendLine(lab);
            _resultBuilder.AppendLine();
            _resultBuilder.AppendLine(owner);
            _resultBuilder.AppendLine("\n\n");
        }

        public virtual void SetWorkAnalysis(string analysis)
        {
            _resultBuilder.AppendLine("Analysis of Lab.");
            _resultBuilder.AppendLine(analysis);
            _resultBuilder.AppendLine("\n\n");
        }

        public virtual void SetWorkDescr(string descr)
        {
            _resultBuilder.AppendLine("Work description of Lab.");
            _resultBuilder.AppendLine(descr);
            _resultBuilder.AppendLine("\n\n");
        }
    }
}
