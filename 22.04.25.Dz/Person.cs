using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._04._25.Dz
{
   public enum EyeColor
    {
        Brown,
        Green,
        Blue
    }

    public class Person
    {
        public string FullName { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public EyeColor EyeColor { get; set; }

        public Person(string fullName, string gender, int age, EyeColor eyeColor)
        {
            FullName = fullName;
            Gender = gender;
            Age = age;
            EyeColor = eyeColor;
        }


        public static EyeColor operator +(Person p1, Person p2)
        {
            if (p1.EyeColor == EyeColor.Brown || p2.EyeColor == EyeColor.Brown)
            {
                return EyeColor.Brown;
            }
            else if (p1.EyeColor == EyeColor.Green && p2.EyeColor == EyeColor.Green)
            {
                return EyeColor.Green;
            }
            else if ((p1.EyeColor == EyeColor.Green && p2.EyeColor == EyeColor.Blue) ||
                     (p1.EyeColor == EyeColor.Blue && p2.EyeColor == EyeColor.Green))
            {
                return EyeColor.Blue;
            }
            else 
            {
                return EyeColor.Blue;
            }
        }

        public override string ToString()
        {
            return $"{FullName}, Пол: {Gender}, Возраст: {Age}, Цвет глаз: {EyeColor}";
        }
    }

 
}
