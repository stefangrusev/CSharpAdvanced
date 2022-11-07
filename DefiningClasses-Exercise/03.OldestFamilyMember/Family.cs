using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Family
    {
        public Family()
        {
            Members = new List<Person>();
        }

        public List<Person> Members
        {
            get; set;
        }


        public void AddMember(Person member)
        {
            this.Members.Add(member);
        }
        public Person GetTheOldestMember()
        {
            int theOldest = Members.Max(m => m.Age);
            return Members.First(m => m.Age == theOldest);
        }
    }
}
