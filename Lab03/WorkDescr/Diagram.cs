using Lab03.Interfaces;
using System.Text;

namespace Lab03.WorkDescr
{
    public class Diagram : IWorkDescr
    {
        private Dictionary<string, int> _diagram;
        private readonly int _precision = 50;

        public Diagram(Dictionary<string, int> diagram)
        {
            _diagram = diagram;
        }

        public Diagram(Dictionary<string, int> diagram, int precision)
        {
            _diagram = diagram;
            _precision = precision;
        }

        public string GetFullDescr()
        {
            var biggestAmount = _diagram.Select(x => x.Key.Length).Max();
            var res = _diagram.Select(x => new { x.Key, Amount = x.Value / 100.0 * _precision, x.Value });

            var resBuilder = new StringBuilder();

            foreach (var item in res)
            {
                resBuilder.Append(item.Key);
                resBuilder.Append(':');
                resBuilder.Append(String.Concat(Enumerable.Repeat(' ', biggestAmount - item.Key.Length)));
                resBuilder.Append(String.Concat(Enumerable.Repeat("#", (int)item.Amount)));
                resBuilder.Append(' ');
                resBuilder.Append(item.Value);
                resBuilder.Append("%\n");
            }

            return resBuilder.ToString();
        }
    }
}
