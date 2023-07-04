using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExamples
{
    class Computer
    {
        // protected lets classes based off of this class to access it
        // we want to protect our data and not use public all the time
        protected string _name = "Unknown";

        // externally, properties act just like fields
        // getters and setters also allow us to manipulate data or check validity
        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

    }
}
