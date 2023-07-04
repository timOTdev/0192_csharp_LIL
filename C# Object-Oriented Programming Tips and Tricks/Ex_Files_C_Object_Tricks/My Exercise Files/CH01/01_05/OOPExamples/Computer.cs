using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExamples
{
    class Computer
    {

        protected string _name = "Unknown";

        public bool isOn { get; private set; }

        public string name
        {
            get
            {
                return _name;
            }
            // setting the set to private means you can't change it
            private set
            {
                _name = value;
            }
        }

        // This is a constructor
        // Let's us set the computer name upon instantiation
        // Using this lets computer know that the left side is a property
        // and the right side is the parameter being supplied
        public Computer(string name)
        {
            this.name = name;
        }

        // These two public methods lets us safely change properties
        // Making protected means only that classes
        // based off of computer can change property
        protected void TurnOn()
        {
            isOn = true;
        }

        protected void TurnOff()
        {
            isOn = false;
        }

        public void TogglePower()
        {
            if (isOn)
            {
                TurnOff();
            }
            else
            {
                TurnOn();
            }
        }
    }
}
