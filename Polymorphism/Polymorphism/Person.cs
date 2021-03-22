using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Person
    {
       /* string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        } */

        public string Name { get; set; } //auto property

        // shortcut -> prop -> tab || double tab ;
        public string Id { get; private set; }

        public string Dob { get; set; }

        public Person(){
        }

        public Person(string name , string id , string dob){

            Name = name;
            Id = id;
            Dob = dob;
         }

       /* public void ShowInfo()
        {
            Console.WriteLine("Name : "+Name);
            Console.WriteLine("ID   : "+Id);
            Console.WriteLine("Dob  : "+Dob);
        } */

        /* 
           method overloading :
           same class , same name , different parameter ;
         
           method overrideing :
           different class(polymorphisum relationship) , same signature , 
        */

        // new vs override

       /* public void ShowInfo()
        {
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("ID   : " + Id);
            Console.WriteLine("Dob  : " + Dob);
        } */
        virtual public void ShowInfo()
        {
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("ID   : " + Id);
            Console.WriteLine("Dob  : " + Dob);
        }

    }
}
