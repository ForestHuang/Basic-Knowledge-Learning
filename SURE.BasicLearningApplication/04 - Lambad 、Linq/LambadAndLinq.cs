using SURE.Common;
using SURE.DataEntity.Reflection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SURE.BasicLearningApplication._04___Lambad__Linq
{
    class LambadAndLinq
    {
        /*
        *   Lambad 表达式，运算符 => 读作 goes to
            Lambad 表达式本质就是个匿名方法或者说是个匿名函数；
            .net框架自带委托: Action:无参无返回 、Func:无参有返回


            ---------------扩展方法--------------
            扩展方法:静态类静态方法第一个参数前加this，父类基础上扩展，子类也可以继承到；
            好处: 在不修改源代码的前提下，为对象注册新的行为；
        */

        //创建委托 delegate
        //委托: 就相当于一个方法的容器，讲一个方法作为参数代入委托中，实现调用，一般我们结合Lambad、匿名方法使用；
        private delegate int LambadMethodDelegate(int count);

        /// <summary>
        /// 委托Lambad
        /// </summary>
        private static void LambadMethod()
        {
            //------------------委托【delegate】---------------------
            LambadMethodDelegate lambadDelegate = (x) =>
            {
                int sum = 0;
                for (int i = 0; i <= x; i++)
                {
                    sum += i;
                }
                return sum;
            };
            var result = lambadDelegate.Invoke(10000);
            Console.WriteLine($"[LambadMethodDelegate]结果: {result}");

            //------------------委托【Action: 支持 0-16个参数】---------------------
            Action action = () =>
            {
                int sum = 0;
                for (int i = 0; i <= 10000; i++)
                {
                    sum += i;
                }
                Console.WriteLine($"[Action]结果: {result}");
            };
            action.Invoke();

            //------------------委托【Func: 0-16参数和一个返回值】---------------------
            Func<int> func = () =>
            {
                int sum = 0;
                for (int i = 0; i <= 10000; i++)
                {
                    sum += i;
                }
                return sum;
            };
            var resultFunc = func.Invoke();
            Console.WriteLine($"[Func]结果: {resultFunc}");
        }

        /// <summary>
        /// Linq
        /// </summary>
        private static void LinqMethod()
        {
            string serverHost = "mongodb://sure:HUANGsl@localhost/Sure_mongodbStudy";
            string databaseName = "Sure_mongodbStudy";
            string collectionName = "People";
            MongodbHelper<People> mongodb = new MongodbHelper<People>(serverHost, databaseName, collectionName);
            Expression<Func<People, bool>> func = i => i.PeopleId > 0;
            List<People> list = null;
            list = mongodb.FindAll(func);

            list = mongodb.FindAll(func).Skip(10 * (1 - 1)).Take(10).ToList();
            list.ForEach((x) => { Console.WriteLine(x.PeopleAddress); });
            list = mongodb.FindAll(func).Where(i => i.PeopleAge <= 10).ToList();

        }

        static void Main(string[] args)
        {
            LinqMethod();
            LambadMethod();
        }

    }
}
