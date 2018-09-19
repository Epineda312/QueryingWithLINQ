/*Create a public method in the NumberAnalysis class called 
NumbersGreaterThanFive that returns an IEnumerable<int>.

Inside the method, use LINQ query syntax to return only the 
numbers in the _numbers field that are greater than 5.  */

using System.Linq;
using System.Collections.Generic;

namespace Treehouse.CodeChallenges
{
    public class NumberAnalysis
    {
        private List<int> _numbers;
        public NumberAnalysis()
        {
            _numbers = new List<int> { 2, 4, 6, 8, 10 };
        }
        public IEnumerable<int> NumbersGreaterThanFive()
        {
        	var numbersGreaterThanFive = from number in _numbers 
                						 where number > 5 
                					     select number;
            
            return numbersGreaterThanFive;
        }
    }
}
/*
Default code

using System.Linq;
using System.Collections.Generic;

namespace Treehouse.CodeChallenges
{
    public class NumberAnalysis
    {
        private List<int> _numbers;
        public NumberAnalysis()
        {
            _numbers = new List<int> { 2, 4, 6, 8, 10 };
        }
    }
} */