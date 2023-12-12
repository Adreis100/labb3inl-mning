using labb3;
using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace labb3
{
    public class Program
    {
        static void Main(string[] args)
        {
            string Firstname = "Adreis";
            string Lastname = "Bibo";
            Gender Gender = Gender.Man;
            Hair Hair = new Hair { HairColor = "svart", HairLenght = "40 CM" };
            DateTime Birthday = new DateTime(2022, 04, 15);
            string Eyecolor = "Blue";     

            Person person = new Person (Gender, Hair, Birthday, Eyecolor, Firstname, Lastname);

            Console.WriteLine(person.ToString());
            

            
        }
    }
}