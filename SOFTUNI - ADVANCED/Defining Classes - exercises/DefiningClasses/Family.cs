using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> familyMambers;

        public Family()
        {
            this.familyMambers = new List<Person>();
        }

        public void AddMember(Person member)
        {
            familyMambers.Add(member);
        }

        public Person GetOldestMember()
        {
            int maxAge = this.familyMambers.Max(member => member.Age);
            return familyMambers.First(member => member.Age == maxAge);
        }

        }
    }
}
