using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExamples
{
    class Computer
    {

        // Automatically set to private if not set
        // private allow only the Computer class to use this field
        // internal allow only classes of the same namespace or same type to use it
        // protected allow any classes that are
        //   based on this class to have access to that field
        public string name;

    }
}
