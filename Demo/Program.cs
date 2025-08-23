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
            // */
            //Hashtable PhoneNote = new Hashtable()
            //{
            //    //{"pola", 123 },
            //    //{"dd", 147 },
            //    //{"ee", 125 }

            //     //Indexer 

            //    ["mona"]=123,
            //    ["moeena"]=47,
            //    ["mosssna"]=41
            //};





            ////phone note of type hashtable has size 3

            ////Key EMp name 
            ////Value Phone number
            ////to add elements

            ////PhoneNote.Add("martin", 123);
            ////PhoneNote.Add("reda", 147);
            ////PhoneNote.Add("faiz", 125);

            ////foreach (object item in PhoneNote)
            ////    Console.WriteLine(item);
            //foreach (object item in PhoneNote)
            //    Console.WriteLine(item);

            ////print spisfaiy data => Dictionary entry 

            #endregion

            #region Generic Collection [ Dictionary ]
            #region EX 01
            //key value Pair 

            //Dictionary<string, int> phoneNote = new Dictionary<string, int>()
            //{
            //    {"hossam" , 1111 },
            //    {"red" , 222 },
            //    {"ssw" , 2222 }
            //};

            #region Indexer 
            ////Get value 
            //Console.WriteLine(phoneNote["hossam"]);
            ////Set value 
            //phoneNote["red"] = 1000;
            ////Add Value 
            //phoneNote["martin"] = 2000;
            #endregion

            #region Try to Get 
            ////phoneNote.Add("hossam", 1478);
            //// TryGetValue()
            //bool result = phoneNote.TryGetValue("martin" , out int num);
            //Console.WriteLine( num);
            //Console.WriteLine( result);
            #endregion

            #region Pass Array To Dictionary
            //KeyValuePair<string, int>[] Array =
            //{
            //    new ("Martin",123),
            //    new ("hio",147),
            //};
            //phoneNote = new Dictionary<string, int>(Array);
            //phoneNote.Add("mic", 1789);
            #endregion
            //foreach (KeyValuePair<string , int> item in phoneNote)
            //    Console.WriteLine( $" Name : {item.Key}|Number : {item.Value}");
            #endregion

            #region Ex 02
            //Employee E1 = new Employee(10, "martin", 5000);
            //Employee E2 = new Employee(10, "reda", 4000);
            //Employee E3 = new Employee(10, "pola", 7000);
            //Dictionary<Employee, string> empolyees = new Dictionary<Employee, string>()
            //{
            //    [E1] = "1st",
            //    [E2] = "2st",
            //    [E3] = "2st",
            //};
            //Employee E4 = new Employee(20, "ewss", 14785);
            //empolyees.Add(E4, "4St");
            ////foreach(var item in empolyees)

            ////    Console.WriteLine( item);
            #endregion
            #endregion

            #region Genaric Collection [Sorted Dictionary]
            #region Ex01
            //SortedDictionary<string, int> phoneNote = new SortedDictionary<string, int>(new StringCompare)
            //{
            //    ["ahmed "] = 111,
            //    ["menna "] = 417,
            //    ["ramy "] = 4789,
            //    ["Bassent "] = 471,
            //    ["tarek "] = 974,
            //};
            ////by defualt sot asc 
            ////Sort Desc
            //foreach (var item in phoneNote)
            //    Console.WriteLine( item);
            #endregion

            #region Ex02
            //Employee E1 = new Employee(10, "martin", 5000);
            //Employee E2 = new Employee(10, "reda", 4000);
            //Employee E3 = new Employee(10, "pola", 7000);

            //SortedDictionary<Employee, string> sortedEmps = new SortedDictionary<Employee, string>()
            //{
            //    [E1]="1st",
            //    [E2]="2st",
            //    [E3]="3st",
            //};
            //foreach (var item in sortedEmps)
            //    Console.WriteLine( item);
            #endregion
            #endregion

            #region Generic Collection [Sorted list]
            SortedList<string, int> SortedList = new SortedList<string, int>()
            {
                ["salma"]=222,
                ["mai"]=444,
                ["ali"]=555,
                ["aya"]=666,
            };
            //acsses any element using index
            Console.WriteLine(SortedList.GetValueAtIndex(0));//ali
            Console.WriteLine(SortedList.GetKeyAtIndex(0));//ali after sorting
            foreach(var item in SortedList)
                Console.WriteLine( item);
            #endregion
        }
    }
}
