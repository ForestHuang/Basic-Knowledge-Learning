using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SURE.BasicLearningApplication._03___delegate_event
{
    /// <summary>
    /// 事件、委托
    /// </summary>
    class delegateAndevent
    {
        /*
            委托: 关键字delegate ,没有方法体，可有参有返回，或者无参无返回，还可以结合Lambad使用；
        */

        //------------------ 委托 -----------------
        private delegate string HollWordDelegate(string name);

        private static string HollWordMethod(string name)
        {
            Console.WriteLine($"{name}");
            return name;
        }

        //static void Main(string[] args)
        //{
        //    HollWordDelegate hollWord = new HollWordDelegate(HollWordMethod);
        //    hollWord.Invoke("senlin.huang");
        //    Console.WriteLine();
        //}
    }
}
