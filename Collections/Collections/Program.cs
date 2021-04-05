using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {

                  // Array List //

            ArrayList list = new ArrayList();

            Course c1 = new Course();
            Course c2 = new Course();
            Course c3 = new Course();

            list.Add(c1);
            list.Insert(1, c2);

            int i = list.IndexOf(c1);
       //     Console.WriteLine("Index of c1 is :"+i);

            int j = list.IndexOf(c2);
        //    Console.WriteLine("Index of c2 is :" + j);

            bool a = list.Contains(c1);
        //   Console.WriteLine("c1 is contain in this list "+a);

            bool b = list.Contains(c3);
        //    Console.WriteLine("c3 is contain in this list "+b);


                   //Hashtable//

            Hashtable ages = new Hashtable();
            ages["Sabbir"] = 28;
            ages["Rahim"] = 21;
            ages["Karim"] = 25;

           // Console.WriteLine("Age of Sabbir " + ages["Sabbir"]);

           // we can't use for loop in Hashtable. We need Foeratch loop


      /*      foreach (DictionaryEntry age in ages)
            {
                Console.WriteLine(age.Value);
            }

            foreach (DictionaryEntry age in ages)
            {
                Console.WriteLine(age.Key);
            }
       */
            foreach (DictionaryEntry age in ages)
            {
                string c = (string)age.Key;
                int d = (int)age.Value;
                Console.WriteLine("{0} => {1}",c,d);
            }

            // Boxing

            int k = 10;

            object box = k;

            Console.WriteLine(k.GetType());

            Course c5 = new Course();
            box = c5;
            Console.WriteLine(c5.GetType());

            // UnBoxing

            c5 = (Course) box;

            // Sorted List [ print sequenly]

            SortedList s1 = new SortedList();

            s1["en-us"] = "United stste";
            s1["en-uk"] = "United kingdom";
            s1["bn"] = "Bangla";
            s1["in"] = "India";
            s1["ar"] = "Arabic";

            foreach (DictionaryEntry s in s1)
            {
                string e = (string)s.Key;
                string f = (string)s.Value;
                Console.WriteLine("{0} => {1}", e, f);
            }

        }
    }
}
