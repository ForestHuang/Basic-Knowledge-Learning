using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SURE.BasicLearningApplication._05___Generic__泛型_
{
    /// <summary>
    /// 泛型、泛型方法、接口、约束、类...等
    /// </summary>
    class Generic
    {
        /*
            泛型(延迟声明，调用的时确定类型): 无需拆箱装箱，类型安全，提高效率 ；
            程序架构思想: 将一切可以推迟的推迟；
            在多个方法或者多个操作，处理动作或相关逻辑一致，只是参数类型不一样，那么我们就是用泛型将方法重用；

            逆变（in）、协变（out）只能用到委托和接口上面；
            in: 只能作为参数；
            out: 只能作为返回参；
         */

        /// <summary>
        /// GenericMethods
        /// </summary>
        private static void GenericMethod<T>(T type)
        {
            //-------------GetType、typeof 获取相关类型名称-----------
            People people = new People();
            Console.WriteLine("名称[GetType]: " + type.GetType().Name);
            Console.WriteLine("名称[typeof]: " + typeof(T).Name);
        }

        //static void Main(string[] args)
        //{
        //    Type type = typeof(People);
        //    People entity = (People)Activator.CreateInstance(type);
        //    PropertyInfo[] propertyInfos = type.GetProperties();
        //    string strField = string.Join("(),", propertyInfos.Select(s => s.Name));
        //    Console.WriteLine(strField);
        //    GenericMethod<People>(new People());
        //}
    }

    /// <summary>
    /// People
    /// </summary>
    public class People
    {
        private int peopleId;
        /// <summary>
        /// PeopleId
        /// </summary>
        public int PeopleId
        {
            get { return peopleId; }
            set { peopleId = value; }
        }

        private string peopleName;
        /// <summary>
        /// 名称
        /// </summary>
        public string PeopleName
        {
            get { return peopleName; }
            set { peopleName = value; }
        }

        /// <summary>
        /// 地址
        /// </summary>
        public string PeopleAddress { get; set; }

        /// <summary>
        /// 年龄
        /// </summary>
        public int PeopleAge { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public string PeopleSex { get; set; }

    }
}
