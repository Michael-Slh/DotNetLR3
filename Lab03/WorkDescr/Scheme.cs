using Lab03.Interfaces;
using System.Text;

namespace Lab03.WorkDescr
{
    public class Scheme : IWorkDescr
    {
        List<string> _pcs;

        public Scheme(List<string> pcs)
        {
            _pcs = pcs;
        }

        public string GetFullDescr()
        {
            var resBuilder = new StringBuilder();
            for (var i = 0; i < _pcs.Count; i++)
            {
                resBuilder.Append(_pcs[i]);
                if (i == _pcs.Count - 1) continue;
                resBuilder.Append("--------->");
            }
            return resBuilder.ToString();
        }
    }
}
