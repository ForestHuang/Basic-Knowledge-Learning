using SURE.Common;
using System;
using System.Reflection;

namespace SURE.BasicLearningApplication._02___Reflection
{
    class AssemblyReflection
    {
        /**
         *  C#写的代码最终生成dll文件，也就是程序集。
         *
         *  dll = (IL + metedata:元数据)
         *
         *  .Net中获取运行时类型信息的方式，.Net的应用程序由几个部分：‘程序集(Assembly)’、‘模块(Module)’、‘类型(class)’组成，而反射提供一种编程的方式，
         *  让程序员可以在程序运行期获得这几个组成部分的相关信息
         *  
         *  反射：通过程序集（dll、exe）运行时动态的创建类型实例，即使这个对象的类型在编译时还不知道，以及获取相关信息每一个类型（包括类、委托、方法、构造器、属性等等）;
         *  还可以获取特性，通过AOP面向切面编程
         *  动态: 接触依赖降低耦合可扩展，不需要事先引用
         *  好处：灵活、可扩展性、动态
         *  反射的局限性：
         *  反射破坏单例模式，使单例失效，一样的多次创建对象；
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

            //--------------GetModules 获取Module 找出当前dll所有的模块
            Console.WriteLine(">>------------------------程序集全部模块------------------------->>");
            foreach (Module module in assembly.GetModules())
            {
                Console.WriteLine($" ModuleName: {module.Name}");
            }

            Console.WriteLine("\n>>------------------------程序集全部类型------------------------->>");
            foreach (var type in types)
            {
                Console.WriteLine($" ClassName: {type.Name} ,ClassFullName: {type.FullName}");
            }

            Console.WriteLine("\n>>------------------------创建当前类型------------------------->>");
            //创建对象实例，默认调用无参构造也可调用有参构造:CreateInstance(Type type, params object[] args);
            object obj = Activator.CreateInstance(types[0]);

            //当前类型的全部方法
            var methods = types[0].GetMethods();
            Console.WriteLine("\n>>------------------------当前类型的所有方法------------------------->>");
            foreach (var typeMethod in methods)
            {
                Console.WriteLine($" MethodName: {typeMethod.Name} ,ReturnType: {typeMethod.ReturnType}");
            }

            //调用方法
            Console.WriteLine("\n>>------------------------调用HelloMethod方法------------------------->>");
            var method = types[0].GetMethod("HelloMethod");
            var result = method.Invoke(obj, null);
            Console.WriteLine(result);

            //设置属性
            Console.WriteLine("\n>>------------------------设定属性值------------------------->>");
            foreach (PropertyInfo propertyInfo in types[0].GetProperties())
            {
                Console.WriteLine($"属性名: {propertyInfo.Name}");
                if (propertyInfo.Name == "PeopleName")
                {
                    propertyInfo.SetValue(obj, "senlin.huang");
                }
            }

            var methodsTwo = types[0].GetMethods(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
            foreach (var mothod in methodsTwo)
            {
                Console.WriteLine(mothod.Name);
            }
        }

        //入口
        static void Main(string[] args)
        {
            ReflectionMethod();
        }
    }
}
