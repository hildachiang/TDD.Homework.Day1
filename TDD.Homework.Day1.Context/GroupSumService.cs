using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.Homework.Day1.Context
{
    public class GroupSumService
    {
        private IGroupSum _groupSum;

        public GroupSumService(IGroupSum groupSum)
        {
            this._groupSum = groupSum;
        }

        public List<int> GetSummary(int groupCount, string groupColumn)
        {
            var dataSrc = this._groupSum.GetData();
            var result = new List<int>();
            var data = dataSrc.GroupBy(d => (int)d.GetPropValue("id") % groupCount).Select(gp => new { z = gp.Key, x = gp.ToList() }).ToList();
            for (int i = 0, iSize = data.Max(d => d.x.Count); i < iSize; i++)
            {
                result.Add(data.Sum(d => d.x.ElementAtOrDefault(i) == null ? 0 : (int)d.x.ElementAtOrDefault(i).GetPropValue(groupColumn)));
            }
            return result;
        }
    }
}
