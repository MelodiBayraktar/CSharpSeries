// See https://aka.ms/new-console-template for more information

 class Program
{
    public static void Main(string[] args)
    {
        List<string> sehirler = new List<string>();
        sehirler.Add("Ankara");
        Console.WriteLine(sehirler.Count);
        
        MyList<string> sehirler2 = new MyList<string>();
        sehirler2.Add("İstanbul");
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
     }

     public int Count
     {
         get { return _array.Length; }
     }
}
