﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyPlaza
{
    internal class MyValidation
    {
        public static bool validLength(string txt, int min, int max)
        {
            bool valid = true;

            if (string.IsNullOrEmpty(txt))
                valid = false;

            else if (txt.Length < min || txt.Length > max)
            {

                valid = false;

            }
            return valid;
        }
        public static bool validNumber(string txt)
        {
            bool valid = true;
            for (int i = 0; i < txt.Length; i++)
            {
                if (!(char.IsNumber(txt[i])))
                    valid = false;

            }
            return valid;
        }
        public static bool validLetter(string txt)//only allows aplhabatic characters
        {
            bool valid = true;

            if (txt.Trim().Length == 0)
                valid = false;
            else
            {
                for (int i = 0; i < txt.Length; i++)
                {
                    if (!(char.IsNumber(txt[i])))
                        valid = false;
                }
            }

            return valid;
        }
        public static bool validLetterWhite(string txt)//only allows spaces
        {
            bool valid = true;

            if (txt.Trim().Length == 0)
                valid = false;
            else
            {
                for (int i = 0; i < txt.Length; i++)
                {
                    if (!(char.IsLetter(txt[i])) && !(char.IsWhiteSpace(txt[i])))
                        valid = false;
                }
            }

            return valid;
        }
        public static bool validLetterNumberWhite(string txt)//ALL
        {
            bool valid = true;

            if (txt.Trim().Length == 0)
                valid = false;
            else
            {
                for (int i = 0; i < txt.Length; i++)
                {
                    if (!(char.IsLetter(txt[i])) && !(char.IsNumber(txt[i])) && !(char.IsWhiteSpace(txt[i])))
                        valid = false;
                }
            }

            return valid;
        }
        public static bool validForename(string txt)//ALL
        {
            bool valid = true;

            if (txt.Trim().Length == 0)
                valid = false;
            else
            {
                for (int i = 0; i < txt.Length; i++)
                {
                    if (!(char.IsLetter(txt[i])) && !(char.IsWhiteSpace(txt[i])) && !(txt[i].Equals('-')))
                        valid = false;
                }
            }

            return valid;
        }
        public static bool validSurname(string txt)//ALL
        {
            bool valid = true;

            if (txt.Trim().Length == 0)
                valid = false;
            else
            {
                for (int i = 0; i < txt.Length; i++)
                {
                    if (!(char.IsLetter(txt[i])) && !(char.IsWhiteSpace(txt[i]))
                        && !(txt[i].Equals('-')) && !(txt[i].Equals('\'')))
                        valid = false;
                }
            }

            return valid;
        }
        public static String firstLetterOfWord(string txt)//npt Wrking
        {
            Char[] array = txt.ToCharArray();

            if (Char.IsLower(array[0]))
            {
                array[0] = Char.ToUpper(array[0]);
            }
            for (int i = 0; i < txt.Length; i++)
            {
                if (array[i] == ' ')
                {
                    if (Char.IsLower(array[i]))
                    {
                        array[i] = Char.ToUpper(array[i]);
                    }
                }
                else
                    array[i] = Char.ToLower(array[i]);
            }
            return new String(array);
        }
        public static String EachLetterToUpper(string txt)//npt Wrking
        {
            Char[] array = txt.ToCharArray();
            for (int i = 0; i < txt.Length; i++)
            {

                if (Char.IsLower(array[i]))
                {
                    array[i] = Char.ToUpper(array[i]);
                }
            }
            return new string(array);
        }
        public static bool validEmail(string txt)//ALL
        {
            bool valid = true;

            if (txt.Trim().Length == 0)
                valid = false;
            else
            {
                for (int i = 0; i < txt.Length; i++)
                {
                    if (!(char.IsLetter(txt[i])) && !(char.IsWhiteSpace(txt[i]))
                        && !(txt[i].Equals('-')) && !(txt[i].Equals('\'')))
                        valid = false;
                }
            }

            return valid;
        }
    }
}
  