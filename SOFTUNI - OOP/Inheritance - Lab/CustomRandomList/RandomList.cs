using System;
using System.Collections.Generic;
using System.Text;

namespace CustomRandomList
{
    internal class RandomList : List<string>
    {
        List<string> list = new List<string>();
        public string RandomString()
        {
            list.Remove(RandomString());
            return list.ToString();
     
        }
        private Random random;
        public void CustomRandomList()
        {

        }
        public string RemoveRandomElemenr()
        {
            int index = random.Next(0, Count);
            string el = this[index];
            this.RemoveAt(index);
            return el;
        }
    }
}
