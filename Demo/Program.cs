using System.Collections;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Non-Generic Collection [HashTable]
            /*
             * Hash Table => Key value pair 
             * -Key must be unique
             * -Key cannot be null
             * -value Can Be null 
             * 
             */
            Hashtable PhoneNote = new Hashtable()
            {
                //{"pola", 123 },
                //{"dd", 147 },
                //{"ee", 125 }

                 //Indexer 

                ["mona"]=123,
                ["moeena"]=47,
                ["mosssna"]=41
            };

           



            //phone note of type hashtable has size 3

            //Key EMp name 
            //Value Phone number
            //to add elements

            //PhoneNote.Add("martin", 123);
            //PhoneNote.Add("reda", 147);
            //PhoneNote.Add("faiz", 125);

            //foreach (object item in PhoneNote)
            //    Console.WriteLine(item);
            foreach (object item in PhoneNote)
                Console.WriteLine(item);

            //print spisfaiy data => Dictionary entry 

            #endregion
        }
    }
}
