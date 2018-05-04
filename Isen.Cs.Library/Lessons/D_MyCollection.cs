
using System;

namespace Isen.Cs.Library.Lessons
{
    public class D_MyCollection
    {
        public static void Run()
        {
            IMyCollection myCollection = new MyCollection();
            /*myCollection.Add("Bonjour");
            myCollection.Add("tout");
            myCollection.Add("le");
            myCollection.Add("monde");
            foreach (var item in myCollection.Values)
            {
                Console.Write(item);
            }
            Console.WriteLine();*/

            myCollection.Add("10");
            myCollection.Add("20");
            myCollection.Add("30");
            myCollection.Add("40");
            myCollection.InsertAt(2, "25");
            myCollection.InsertAt(0, "5");
            myCollection.InsertAt(6, "45");
            foreach (var item in myCollection.Values)
            {
                Console.Write(item);
                Console.WriteLine();
            }
            Console.WriteLine();
            
        }
    }
}