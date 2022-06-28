using Lab03.Interfaces;

namespace Lab03.WorkDescr
{
    public class Code : IWorkDescr
    {
        private readonly string _res;
        public Code(string res)
        {
            _res = res;
        }
        public string GetFullDescr()
        {
            return _res;
        }
    }
}
