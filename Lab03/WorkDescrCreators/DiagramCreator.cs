using Lab03.Interfaces;
using Lab03.WorkDescr;
using System.Text.Json;

namespace Lab03.WorkDescrCreators
{
    public class DiagramCreator : ICreateWorkDescr
    {
        public IWorkDescr CreateWorkDescr(string descr)
        {
            var res = JsonSerializer.Deserialize<Dictionary<string, int>>(descr) ?? new Dictionary<string, int>();

            return new Diagram(res);
        }
    }
}
