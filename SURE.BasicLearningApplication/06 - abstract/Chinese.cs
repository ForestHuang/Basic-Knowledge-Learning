using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SURE.BasicLearningApplication._06___abstract
{
    public class Chinese : BasePeople
    {
        public override int Age()
        {
            throw new NotImplementedException();
        }

        public override string Name()
        {
            throw new NotImplementedException();
        }

        public override string Sex()
        {
            throw new NotImplementedException();
        }
    }
}
