using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork11
{
    internal sealed class CustomDictionary
    {
        private string[] _keyArray = new string[4];

        private string[] _valueArray = new string[4];

        public void Add(string key, string value)
        {
            for (int i = 0; i < _keyArray.Length; i++)
            {
                if (_keyArray[i] == null)
                {
                    _keyArray[i] = key;
                    _valueArray[i] = value;
                    break;
                }
            }
        }
     
        public bool Contains(string key)
        {
            for (int i = 0; i < _keyArray.Length; i++)
            {
                if (_keyArray[i] == key)
                {
                    return true;
                }           
            }
            return false;
        }
    }
}
