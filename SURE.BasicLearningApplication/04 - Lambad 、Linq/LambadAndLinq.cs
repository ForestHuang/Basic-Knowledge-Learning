using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SURE.BasicLearningApplication._04___Lambad__Linq
{
    class LambadAndLinq
    {
        /*
            Lambad 表达式
            本质：匿名方法，Lambad就是个方法匿名方法；
            系统自带委托: Action,Func
        */

        //创建有参有返回委托
        private delegate string LambadDelegate(string name);

        static void Main(string[] args)
        {
            LambadDelegate lambad = (x) =>
            {
                Console.WriteLine(x);
                return x;
            };

            var result = lambad.Invoke("senlin.huang");
            Console.WriteLine(result);
        }
    }
}
