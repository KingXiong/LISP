using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISP.BL
{
    public class Checker
    {
        public static bool LISPInput(string InputLISP)
        {
            if (InputLISP.Where(x => (x == '(')).Count() != InputLISP.Where(x => (x == ')')).Count()) //Case where parenthesis count does not matched.
                return false;
            else
            { //Case where parenthesis are matched.
                string parenthesisString = String.Empty;
                string parenthesis = String.Empty;
                foreach (var i in InputLISP)
                {  //Looping through only the parenthesis
                    if (i == '(' || i == ')')
                        parenthesis += i;
                }
                //parenthesis string will now contain parenthesis characters only. 
                
                //If all parentheses are closed correctly the string will be empty.
                while (parenthesis.Length != parenthesisString.Length) 
                {//Checks to see if parenthesis 
                    parenthesisString = parenthesis;
                    parenthesis = parenthesis.Replace("()", string.Empty); //Using .Replace instead of reassigning it to fit CSV format.
                }

                return (parenthesis.Length == 0);
            }
        }
    }
}
