using System;
using System.Collections.Generic;

namespace myApp
{
    public class Another
    {
        private List<string> list = new List<string>();
        private Dictionary<string, string> dict = new Dictionary<string, string>();
        public static int getNumber()
        {
            return 10;
        }

        public void addToList(string str)
        {
            this.list.Add(str);
        }

        public List<string> GetList()
        {
            return this.list;
        }

        public void addToDict(string key, string value)
        {
            this.dict.Add(key, value);
        }

        public Dictionary<string, string> getDict()
        {
            return this.dict;
        }

    }
}