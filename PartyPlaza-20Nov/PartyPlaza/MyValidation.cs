using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//import emailvalidator4j.EmailValidator;

namespace PartyPlaza
{
    internal class MyValidation
    {

        public static bool validLength(string txt, int min, int max)
        {
            bool ok = true;

            if (string.IsNullOrEmpty(txt))
                ok = false;
            else if (txt.Length < min || txt.Length > max)
                ok = false;
            return ok;
        }
        public static bool validNumber(String txt)
        {
            bool ok = true;
            for (int x = 0; x < txt.Length; x++)
            {
                if (!(char.IsNumber(txt[x])))
                {
                    ok = false;
                }
            }
            return ok;
        }
        public static bool validLetter(String txt) //allows alphabetic characters 
        {
            bool ok = true;
            if (txt.Trim().Length == 0)
            {
                ok = false;
            }
            else
            {
                for (int x = 0; x < txt.Length; x++)
                {
                    if (!(char.IsLetter(txt[x])))
                        ok = false;
                }
            }
            return ok;
        }
        public static bool validLetterWhitespace(String txt)  //allows alphabe characters and whitespace
        {
            bool ok = true;

            if (txt.Trim().Length == 0)
            {
                ok = false;
            }
            else
            {
                for (int x = 0; x < txt.Length; x++)
                {
                    if (!(char.IsLetter(txt[x])) && !(char.IsWhiteSpace(txt[x])))
                        ok = false;
                }
            }
            return ok;
        }
        public static bool validLetterNumberWhitespace(String txt)  //allows alphanumeric and whitespace
        {
            bool ok = true;

            if (txt.Trim().Length == 0)
            {
                ok = false;
            }
            else
            {
                for (int x = 0; x < txt.Length; x++)
                {
                    if (!(char.IsLetter(txt[x])) && !(char.IsWhiteSpace(txt[x])) && !(char.IsNumber(txt[x])))
                        ok = false;
                }
            }
            return ok;
        }
        public static bool validForename(String txt)  // allows alphabetic, dash and whitespace
        {
            bool ok = true;
            if (txt.Trim().Length == 0)
            {
                ok = false;
            }
            else
            {
                for (int x = 0; x < txt.Length; x++)
                {
                    if (!(char.IsLetter(txt[x])) && !(char.IsWhiteSpace(txt[x])) && !(txt[x].Equals('-')))
                        ok = false;
                }
            }
            return ok;
        }
        public static bool validSurname(String txt)  //allows alphabetic, dash ad whitespace
        {
            bool ok = true;
            if (txt.Trim().Length == 0)
            {
                ok = false;
            }
            else
            {
                for (int x = 0; x < txt.Length; x++)
                {
                    if (!(char.IsLetter(txt[x])) && !(char.IsWhiteSpace(txt[x])) && !(txt[x].Equals('-'))
                            && !(txt[x].Equals('\'')))
                        ok = false;
                }
            }
            return ok;
        }

        public static bool validDogColour(String txt)  //allows alphanumeric and whitespace
        {
            bool ok = true;

            if (txt.Trim().Length == 0)
            {
                ok = false;
            }
            else
            {
                for (int x = 0; x < txt.Length; x++)
                {
                    if (!(char.IsLetter(txt[x])) && !(txt[x].Equals('-')) && !(txt[x].Equals('/'))
                        && !(txt[x].Equals('&')) && !(txt[x].Equals(' ')))
                    {
                        ok = false;
                    }
                }
            }
            return ok;
        }

        public static bool validDogDOB(String txt)
        {
            DateTime currentDate = DateTime.Now;
            DateTime dogDOB = Convert.ToDateTime(txt);

            TimeSpan t = currentDate - dogDOB;
            double NoOfDays = t.TotalDays;

            bool ok = true;

            if (txt.Trim().Length == 0)
            {
                ok = false;
            }
            else
            {
                if (NoOfDays <= 56)
                    ok = false;
            }
            return ok;
        }
                           //firstLetterEachWordToUppper
        public static String firstLetterEachWordToUppper(String word)  // npt working
        {
            Char[] array = word.ToCharArray();

            if (Char.IsLower(array[0]))
            {
                array[0] = Char.ToUpper(array[0]);
            }
            //go trough array and check for spaces. Make any lowercase letters after a space uppercase
            for (int x = 1; x < array.Length; x++)
            {
                if (array[x - 1] == ' ')
                {
                    if (Char.IsLower(array[x]))
                    {
                        array[x] = Char.ToUpper(array[x]);
                    }
                }
                else
                    array[x] = Char.ToLower(array[x]);
            }
            return new String(array);
        }
        public static String EachLetterToUpper(String word)
        {
            Char[] array = word.ToCharArray();

            for (int x = 0; x < array.Length; x++)
            {
                if (Char.IsLower(array[x]))
                {
                    array[x] = Char.ToUpper(array[x]);
                }
            }
            return new string(array);
        }
        public static bool validIntRange(int min, int max)
        {
            int num = 0;
            bool ok = true;

            do
            {
                try
                {
                    ok = true;
                    throw new MyException("The number must be between" + min + " and " + max);

                    if (num < min || num > max)
                    {
                        ok = false;
                        throw new MyException("The number must be between" + min + " and " + max);
                    }
                }
                catch (MyException e)
                {
                    throw new MyException("The number must be between" + min + " and " + max);
                    ok = false;
                }
            } while (!ok);

            return ok;
        }
        /*
         import emailvalidator4j.EmailValidator

         public class ValidateEmail 
         {
            public static void main (String[] args) 
                {
                    EmailValidator validator = new EmailValidator();
                        
                    if (validator->isValid(args[0]) 
                        {
                            System.out.println("Valid email");
                        } 
                    else 
                        {
                            System.out.println("Invalid email");
                        }
                }
            }
         */
    }
}
