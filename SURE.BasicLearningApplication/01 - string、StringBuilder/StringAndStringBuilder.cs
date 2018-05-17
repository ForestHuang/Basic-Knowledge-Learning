using System.Diagnostics;
using System.Text;

namespace SURE.BasicLearningApplication._01___string_StringBuilder
{
    /**
        string（引用类型） 和 StringBuilder 的区别 ？
        string 声明赋值之后需要再次赋值或者重复操作的时候，并不是在原基础上修改值，而是重新的去创建个字符串对象以及重新分配空间，并且重新指向这个值；
        如此重复这个操作的话，导致系统开销非常大，以及效率也很低；
        引用类型存储在堆上面的，声明是在栈上面创建空间存储内存地址这个地址指向堆上面的值；
        总结：一旦创建了string该对象，就不能修改该对象的值(只能重新创建以及指向这个新对象)；

        StringBuilder 声明创建之后再次操作时并不像前者重新创建对象，而是在原基础上翻倍增加，所以减少了创建以及系统回收，效率比string高很多；
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

        //入口
        //static void Main(string[] args)
        //{
        //    //实际证明string效率要比stringbuilder低
        //    DifferenceMethod();
        //}
    }
}
