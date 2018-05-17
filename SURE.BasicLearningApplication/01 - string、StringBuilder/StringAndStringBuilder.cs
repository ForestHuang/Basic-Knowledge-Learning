using System.Diagnostics;
using System.Text;

namespace SURE.BasicLearningApplication._01___string_StringBuilder
{
    /**
        string 和 StringBuilder 的区别 ？
        string 声明之后再次赋值的时候，并不是在原基础上修改值，而是重新的去创建个空间
     **/
    class StringAndStringBuilder
    {
        //string 、 StringBuilder
        public static void DifferenceMethod()
        {
            //--------------------------------string---------------------------------------
            //string Stopwatch 
            string str = "";
            Stopwatch stringStopwatch = new Stopwatch();
            stringStopwatch.Start();
            for (int i = 1; i <= 100000; i++)
            {
                str += $"{i}";
            }
            stringStopwatch.Stop();
            System.Console.WriteLine($"string -- 运行时间(毫秒): {stringStopwatch.ElapsedMilliseconds}");

            System.Console.WriteLine();
            //--------------------------------StringBuilder---------------------------------------
            //StringBuilder Stopwatch 
            StringBuilder stringBuilder = new StringBuilder();
            Stopwatch stringBuilderStopwatch = new Stopwatch();
            stringBuilderStopwatch.Start();
            for (int i = 1; i <= 100000; i++)
            {
                stringBuilder.Append($"{i}");
            }
            stringBuilderStopwatch.Stop();
            System.Console.WriteLine($"StringBuilder -- 运行时间(毫秒): {stringBuilderStopwatch.ElapsedMilliseconds}");
        }

        static void Main(string[] args)
        {
            DifferenceMethod();
        }
    }
}
