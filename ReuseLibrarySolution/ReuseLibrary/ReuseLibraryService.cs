using System;
using System.Collections.Generic;

/*
      This is a simple service which returns a list of type string containing the numbers 1 to a Max Number (long value provided by the user)
      in string form. If the number is less than one then the service returns null.
      If the number is divisible by 3 the word Fizz is added to the list. If the number is divisible by 5 the word Buzz is 
      added to the list. If the number is divisible by 3 and 5 then the value "Fizz,Buzz" is added to the list. 
      Otherwise, then the number in string form is added to the list.

*/

namespace ReuseLibrary
{
    public class ReuseLibraryService
    {
        public List<string> ReuseLibraryMethod(long maxNumber)
        {
            List<string> theList = new List<string>();

            if (maxNumber > 0)
            {

                for (int i = 1; i <= maxNumber; i++)
                {
                    if (i % 3 == 0 && i % 5 == 0)
                    {
                        theList.Add("FizzBuzz");
                    }

                    else if (i % 3 == 0)
                    {
                        theList.Add("Fizz");
                    }

                    else if (i % 5 == 0)
                    {
                        theList.Add("Buzz");
                    }

                    else
                    {
                        theList.Add(i.ToString());
                    }

                }
            }

            else
            {
                return null;
            }

            return theList;
        }
    }
}
