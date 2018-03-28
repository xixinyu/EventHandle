using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningFor.ClassLibrary
{

    public  class TransferInfoEvetargs
    {
        public TransferInfoEvetargs(string info)
        {
            this.Info = info;

        }
        public string Info {get;private  set;}
    }
}
