using System;
using TenCats.Chapter11;

namespace TenCats
{
    class Program
    {
        static void Main(string[] args)
        {
            //8. Create ten Cat objects, give them names formated like this: 
            //CatN where N is the number of the object and calls the method
            //SayMeow for each of the cats. 
            //For the implementation of the program use the already
            //created classes in the Chapter11 namespace


            Cat[] catsArr = new Cat[10];

            for (int i = 0; i < catsArr.Length; i++)
            {
                catsArr[i] = new Cat("Cat" + Sequence.GetNextValue(), "");
            }

            for (int i = 0; i < catsArr.Length; i++)
            {
                catsArr[i].SayMeow();
            }
        }
    }
}
