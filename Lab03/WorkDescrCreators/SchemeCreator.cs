using Lab03.Interfaces;
using Lab03.WorkDescr;
using System.Text.Json;

namespace Lab03.WorkDescrCreators
{
    public class SchemeCreator : ICreateWorkDescr
    {
        public IWorkDescr CreateWorkDescr(string descr)
        {
            var list = JsonSerializer.Deserialize<List<string>>(descr) ?? new List<string>();

            return new Scheme(list.OrderBy(x => x).ToList());
        }
    }
}
