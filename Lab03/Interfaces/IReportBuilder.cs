namespace Lab03.Interfaces
{
    public interface IReportBuilder
    {
        public void Reset();
        public void SetTitle(int reportNumber, string name, string surname);
        public void SetGoal(string goal);
        public void SetTask(string task);
        public void SetTheoretical(string theory);
        public void SetWorkDescr(string descr);
        public void SetResult(string result);
        public void SetWorkAnalysis(string analysis);
        public void SetConclusion(string conclusion);
        public string GetResult();
    }
}
