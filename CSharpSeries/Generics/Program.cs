﻿// See https://aka.ms/new-console-template for more information

 class Program
{
    public static void Main(string[] args)
    {
        List<string> sehirler = new List<string>();
        sehirler.Add("Ankara");
        sehirler.Add("İstanbul");
        sehirler.Add("Muğla");
        sehirler.Add("Sivas");

        Console.WriteLine(sehirler.Count);
        
        MyList<string> sehirler2 = new MyList<string>();
        sehirler2.Add("İstanbul");
        sehirler2.Add("Ankara");
        sehirler2.Add("Muğla");
        
        Console.WriteLine(sehirler2.Count);
    }
}

class MyList<T>//generic class
{
     T[] _array;

     T[] _tempArray;
     public MyList()
     {
         _array = new T[0];
     }

     public void Add(T item)
     {
         _tempArray = _array;
         _array = new T[_array.Length + 1];
         for (int i = 0; i < _tempArray.Length; i++)
         {
             _array[i] = _tempArray[i];
         }

         _array[_array.Length - 1] = item;
     }

     public int Count
     {
         get { return _array.Length; }
     }
}
