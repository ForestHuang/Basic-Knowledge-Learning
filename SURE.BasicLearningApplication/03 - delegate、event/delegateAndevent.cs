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
        // ------------ 委托 -----------------
        private delegate string HollWordDelegate(string name);

        private static string HollWordMethod(string name)
        {
            Console.WriteLine($"{name}");
            return name;
        }

        static void Main(string[] args)
        {
            HollWordDelegate hollWord = new HollWordDelegate(HollWordMethod);
            hollWord.Invoke("senlin.huang");
            Console.WriteLine();
        }
    }
}
