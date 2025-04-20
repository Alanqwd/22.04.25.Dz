using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._04._25.Dz
{
    public static class WorkAbility
    {
        private static readonly int MinAge = 18;
        private static readonly int MaxAge = 70;

        public static bool InfoPerson(Person person)
        {
            return person.Age > MinAge && person.Age < MaxAge;
        }
    }
}
