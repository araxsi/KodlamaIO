using System;
using System.Collections.Generic;
using System.Text;

namespace Day4_GenericsIntro
{
    class MyList<T>//oluşturulan tipe göre çalışabilir bir liste oluşturulabilmektedir.
    {
        T[] items;
        //constructor
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item) //Yukarıda item tipinde itemlar aldığına dikkat edilmesi gerekmektedir.

        {
            T[] tempArray = items;
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item;
        }
    }
}
