using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    interface IOne
    {
        void ONE(); // Pure Abstract Method Signature
    }

    interface ITwo
    {
        void TWO();
    }

    interface IThree : IOne
    {
        void THREE();
    }

    interface IFour
    {
        void FOUR();
    }

    interface IFive : IThree
    {
        void FIVE();
    }

    interface IEVEN : ITwo, IFour { }

    class ODDEVEN: IEVEN, IFive // Must Implement all the abstract method, in Derived class
    {
        public void ONE() // Implementation of the Abstract Method
        {
            Console.WriteLine("This is ONE");
        }

        public void TWO() // Implementation of the Abstract Method
        {
            Console.WriteLine("This is TWO");
        }

        public void THREE() // Implementation of the Abstract Method
        {
            Console.WriteLine("This is THREE");
        }

        public void FOUR() // Implementation of the Abstract Method
        {
            Console.WriteLine("This is FOUR");
        }

        public void FIVE() // Implementation of the Abstract Method
        {
            Console.WriteLine("This is FIVE");
        }
    }

}
