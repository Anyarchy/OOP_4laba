using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_4laba
{
    class Strings
    {
        private char[] array;
        private int length;

        public Strings()
        {

        }

        public Strings (char[] temp)
        {
            array = temp;
            length = temp.Length;
        }

        public Strings(Strings Copy)
        {
            length = Copy.length;
            array = Copy.array;
        }

        public char[] Array
        {
            get
            {
                return array;
            }
            set
            {
                array = value;
            }
        }

        public int Length
        {
            get
            {
                return length;
            }
            set
            {
                length = value;
            }
        }

        public static Strings operator +(Strings string1, Strings string2)
        {
            Strings CS = new Strings();
            CS.Length = string1.Length + string2.Length;
            char[] temp = new char[string1.Length + string2.Length];
            for (int i = 0; i < string1.Length; i++)
            {
                temp[i] = string1.Array[i];
            }
            for (int i = string1.Length; i < string1.Length + string2.Length; i++)
            {
                temp[i] = string2.Array[i - string1.Length];
            }
            CS.Array = temp;
            return CS;
        }

        public static Strings operator -(Strings string1, char Char)
        {
            int symbol = 0;
            for (int i = 0; i < string1.Length; i++)
            {
                if(string1.Array[i] != Char)
                {
                    symbol++;
                }
            }
            char[] temp = new char[symbol];
            symbol = 0;
            for (int i = 0; i < string1.Length; i++)
            {
                if (string1.Array[i] != Char)
                {
                    temp[symbol] = string1.Array[i];
                    symbol++;
                }
            }
            Strings CS = new Strings(temp);
            return CS;
        }

        public void PrinterText()
        {
            for (int i = 0; i < length; i++)
            {
                Console.Write(array[i]);
            }
            Console.WriteLine();
        }

    }
}
