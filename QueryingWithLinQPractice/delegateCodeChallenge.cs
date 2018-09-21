/*Challenge Task 1 of 5

Declare a delegate named MathOperation inside the 
Program class that has an integer return type and 
takes an integer parameter named number. */


using System;

namespace Treehouse.CodeChallenges
{
    class Program
    {
        delegate int MathOperation (int number);
           
           public static void Add(int number)
           {
                return number + number;
           }
        static void Main(string[] args)
        {
           
        }
    }
}
/*
Challenge Task 2 of 5

Create a public static method named Add that matches the signature of the 
MathOperation delegate. Inside the method, return the result of number + number.
 */

namespace Treehouse.CodeChallenges
{
    class Program
    {
        delegate int MathOperation (int number);
           
           public static int Add(int number)
           {
                return number + number;
           }
        static void Main(string[] args)
        {
           
        }
    }
}
/*
Challenge Task 3 of 5

Instantiate a new MathOperation named add and point it to the Add method.
 */

namespace Treehouse.CodeChallenges
{
    class Program
    {
        delegate int MathOperation (int number);
           
           public static int Add(int number)
           {
                return number + number;
           }
        static void Main(string[] args)
        {
           MathOperation add = new MathOperation(Add);
        }
    }
}

/*
Challenge Task 4 of 5

Create another public static method named Square that matches the
 signature of the MathOperation delegate. Inside the method, return 
 the result of number * number.
 */
namespace Treehouse.CodeChallenges
{
    class Program
    {
        delegate int MathOperation (int number);
           
        public static int Add(int number)
        {
           return number + number;
        }
        public static int Square(int number)
        {
           return number * number;
        }
        static void Main(string[] args)
        {
           MathOperation add = new MathOperation(Add);
        }
    }
}
/*
Challenge Task 5 of 5

Instantiate a new MathOperation named square and point it 
to the Square method.
 */

namespace Treehouse.CodeChallenges
{
    class Program
    {
        delegate int MathOperation (int number);
           
        public static int Add(int number)
        {
           return number + number;
        }
        public static int Square(int number)
        {
           return number * number;
        }
        static void Main(string[] args)
        {
           MathOperation add = new MathOperation(Add);
           MathOperation square = new MathOperation(Square); 
        }
    }
}

