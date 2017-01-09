using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.Homework.Day1.Context
{
    public class ExtraDao : IGroupSum
    {
        public List<object> GetData()
        {
            var result = Context.GetExtraData();
            return result;
        }
    }
}
