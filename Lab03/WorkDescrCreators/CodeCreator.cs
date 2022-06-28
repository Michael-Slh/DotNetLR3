using Lab03.Interfaces;
using Lab03.WorkDescr;
using System.Text;

namespace Lab03.WorkDescrCreators
{
    public class CodeCreator : ICreateWorkDescr
    {
        public IWorkDescr CreateWorkDescr(string descr)
        {
            if (string.IsNullOrEmpty(descr)) return new Code(string.Empty);

            var resBuilder = new StringBuilder();

            var nesting = 0;
            foreach (var symb in descr)
            {
                if (symb == '{')
                {
                    nesting++;
                    resBuilder.Append(symb);
                    resBuilder.Append('\n');
                    resBuilder.Append(string.Concat(Enumerable.Repeat(' ', nesting * 4)));
                }
                else if (symb == '}')
                {
                    nesting--;
                    resBuilder.Length -= 4;
                    resBuilder.Append(symb);
                    resBuilder.Append('\n');
                    resBuilder.Append(string.Concat(Enumerable.Repeat(' ', nesting * 4)));
                }
                else if (symb == ';')
                {
                    resBuilder.Append(symb);
                    resBuilder.Append('\n');
                    resBuilder.Append(string.Concat(Enumerable.Repeat(' ', nesting * 4)));
                }
                else
                {
                    resBuilder.Append(symb);
                }
            }
            return new Code(resBuilder.ToString());
        }
    }
}
