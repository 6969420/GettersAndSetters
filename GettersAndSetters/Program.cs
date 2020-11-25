using System;

namespace GettersAndSetters
{
    class Program
    {
        class Person
        {
             string name;
             int age;
             string gender;
             string idCode;

            public Person(string _name, string _gender, int _age, string _idCode)
            {
                name = _name;
                Gender = _gender;
                age = _age;
                IdCode = _idCode;
            }

            public string Name
            {
                get { return name; }
                set
                {
                    name = value;
                }
                    
                
            }
            public string Gender
            {
                get { return name; }
                set
                {
                    if(value == "male" || value == "female")
                    {
                        gender = value;
                    }else
                    {
                        gender = "undefined retard";
                    }
                }
            }
            public string IdCode
            {
                get { return idCode; }
                set
                {
                    if(value.Length == 11)
                    {
                        idCode = value;
                    }else
                    {
                        idCode = "undefined juri";
                    }
                }
            }

            public void ChangeName(string newName)
            {
                name = newName;
            }
            public void ChangeIdCode(string newCode)
            {
                IdCode = newCode;
            }
                

        }      
        static void Main(string[] args)
        {
            Person newPerson = new Person("Charlotte Linlin", "gmale", 42, "3256841465");
            Console.WriteLine(newPerson.Name);
            Console.WriteLine(newPerson.Gender);
            Console.WriteLine(newPerson.IdCode);
            newPerson.ChangeName("Charlotte Hoven");
            newPerson.ChangeIdCode("12345");
            //Console.WriteLine(newPerson.age);
            //newPerson.Name = "Charlotte Linlin";
            //newPerson.gender = "female";
            //newPerson.age = 32;
            Console.WriteLine(newPerson.Name);
            Console.WriteLine(newPerson.IdCode);
            //Console.WriteLine(newPerson.Gender);
            //Console.WriteLine(newPerson.Age);

        }
    }
}
