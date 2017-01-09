using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDD.Homework.Day1.Context;

namespace TDD.Homework.Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入查詢分組單位以幾筆為一組:");
            var groupCount = Console.ReadLine();

            Console.WriteLine("請輸入查詢分組總和的欄位:");
            var groupColumn = Console.ReadLine();

            GroupSumService gsService = new GroupSumService(GetObjectType());
            var result = gsService.GetSummary(Int32.Parse(groupCount), groupColumn);
        }
        private static IGroupSum GetObjectType()
        {
            Console.WriteLine("你想取得哪個物件, 輸入A，作業所提供資料，輸入B，新增的物件");
            var objType = Console.ReadLine();
            switch (objType.ToString())
            {
                case "A":
                    return new HomeworkDao();

                case "B":
                default:
                    return new ExtraDao();
            }
        }
    }
}
