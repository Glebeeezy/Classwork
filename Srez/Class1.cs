using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Srez
{
    internal class MyString
    {
        private string _string;

        public string Reverse()
        {
            _string.Reverse();
            return _string;
        }

        public MyString(string str)
        {
                _string = str;
        }

        public MyString(char[] chars)
        {
            string str = new string(chars);
            _string = str;
        }

        public MyString(string[] strings)
        {
            string str = "";
            for (int i = 0; i < strings.Length; i++)
            {
                str += strings[i];
            }
            _string = str;
        }
    }
}
