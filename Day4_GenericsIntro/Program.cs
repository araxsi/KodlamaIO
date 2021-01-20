using System;

namespace Day4_GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> names = new MyList<string>();
            names.Add("Emre");
            MyList<int> ProductId = new MyList<int>();
            ProductId.Add(3);

        }
    }
}
