using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceFortuneTeller
{
    class Service
    {
        //Properties
        //services have costs
        //I want this to be overrideable
        public virtual decimal Price { get; set; }

        //all services have a name
        public virtual string Name { get; set; }

        //Let's make a property to store some result.  Let;s just say it a single result and it's a string
        public virtual string Result { get; set; }

    }
}
