using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SURE.BasicLearningApplication._06___abstract
{
    /// <summary>
    /// 基类 -- 人
    /// </summary>
    public abstract class BasePeople
    {
        /*
            抽象类: 父类没有方法体，未实现（没有具体实现），由子类继承并且实现，抽象方法必须在抽象类中
            抽象类: is a 
            接口: can do
            虚方法: 应对多态，虚方法必须包含完整实现，
        */

        public abstract string Name();

        public abstract string Sex();

        public abstract int Age();
    }
}
