using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SURE.BasicLearningApplication._02___Reflection
{
    class AssemblyReflection
    {
        /**
            C#写的代码最终生成dll文件，也就是程序集。

            dll = (IL + metedata:元数据)

            .Net中获取运行时类型信息的方式，.Net的应用程序由几个部分：‘程序集(Assembly)’、‘模块(Module)’、‘类型(class)’组成，而反射提供一种编程的方式，
            让程序员可以在程序运行期获得这几个组成部分的相关信息
            
            反射：通过程序集（dll、exe）运行时动态的创建类型实例，即使这个对象的类型在编译时还不知道，以及获取相关信息每一个类型（包括类、委托、方法、构造器、属性等等）;
            
            反射破坏单例模式，使单例失效，一样的多次创建对象；
        **/

        //Reflection 反射
        public static void ReflectionMethod()
        {
            string dllPath = @"D:\项目文件\Basic Knowledge Learning\Basic-Knowledge-Learning\DataModel\bin\Debug\SURE.DataEntity.dll";
            //--------------LoadFrom 不会自动加载子程序集-----------------
            //var assembly = Assembly.Load(dllPath);

            //--------------LoadFrom 会自动加载子程序集-----------------
            var assembly = Assembly.LoadFrom(dllPath);
            //var assembly = Assembly.LoadFile(dllPath);

            //--------------GetTypes 获取全部类型 or GetType 指定回去类型
            var types = assembly.GetTypes();
            //var type = assembly.GetType("SURE.DataEntity.Reflection.People");

            Console.WriteLine("------------------------程序集全部类型-------------------------");
            foreach (var type in types)
            {
                Console.WriteLine($"类名: {type.Name} ,完整路径: {type.FullName} ");

                //全部方法
                var typeMethhods = type.GetMethods(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
                foreach (var typeMethhod in typeMethhods)
                {
                    Console.WriteLine($"方法名: {typeMethhod.Name}");
                }
            }
        }

        //入口
        static void Main(string[] args)
        {
            ReflectionMethod();
        }
    }
}
