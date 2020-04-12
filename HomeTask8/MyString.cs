using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask8
{
    class MyString
    {
        char[] сharArray;
        string str;
        public int Lenght
        {
            get
            {
                return сharArray.Length;
            }
        }
        public char NotAutomaticProperty { get; set; }
        public MyString()
        {
            сharArray = new char[0];
        }
        public MyString(char[] charArray)
        {
            this.сharArray = charArray;

        }

        public bool Contains(char value1, char[] value2)
        {
            foreach (var i in value2)
            {
                if (value1 == value2[i])
                {
                    return true;
                }
            }
            return false;
        }

        public int IndexOf(char[] value, char value2)
        {
            int index = -1;
            for (int i = 0; i < value.Length; i++)
            {
                if (value[i] == value2)
                {
                    index = i;
                    return index;
                }
            }
            return index;

        }
        public string plusMethod(char[] a, char[] b)
        {
            char[] newAr = new char[a.Length + b.Length];
            int i = 0;
            for(; i < a.Length; i++)
            {
                newAr[i] = a[i];
            }
            for(int j = 0; j < b.Length; j++)
            {
                newAr[i + j] = b[j];
            }
            return new string(newAr);
            
        }
        public char this[int index]
        {
            get
            {
                return сharArray[index];
            }
        }

    }
}
