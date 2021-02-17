using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictonary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictonary<string> isimler = new MyDictonary<string>();
            isimler.Add("irem");
            isimler.Add("begüm");
            isimler.Add("zeynep");

            Console.WriteLine(isimler.Count);

        }



        class MyDictonary<T>
        {
            T[] _array;
            T[] tempArray;

            public MyDictonary()
            {
                _array = new T[0];


            }

            public void Add(T item)
            {
                tempArray = _array;
                _array = new T[_array.Length + 1];

                for (int i = 0; i < tempArray.Length; i++)
                {
                    _array[i] = tempArray[i];
                }

                _array[_array.Length - 1] = item;
            }


            public int Count
            {
                get { return _array.Length; }

            }



        }


    }
}

