// See https://aka.ms/new-console-template for more information

 class Program
{
    public static void Main(string[] args)
    {
        //interfaceler newlenemez!
        //IPersonManager customerManager = new CustomerManager();
        //customerManager.Add();

        //IPersonManager employeeManager = new EmployeeManager();
        //employeeManager.Add();

        ProjectManager projectManager = new ProjectManager();
        //projectManager.Add(customerManager);
        projectManager.Add(new InternManager());
    }
}

// class PersonManager
// {
//     //implemented operation
//     public void Add()
//     {
//         Console.WriteLine("Eklendi");
//     }
// }
interface IPersonManager
{
    //unimplemented operation
    void Add();
    void Update();

}
//inherits- class , implements- interface
//javada interface implements, class extends
class CustomerManager : IPersonManager
{
    public void Add()
    {
        //müşteri ekleme kodları
        Console.WriteLine("Müşteri eklendi");
    }

    public void Update()
    {
        Console.WriteLine("Müşteri güncellendi");
    }
}
class EmployeeManager : IPersonManager
{
    public void Add()
    {
        //personel ekleme kodları
        Console.WriteLine("Personel eklendi");
    }

    public void Update()
    {
        Console.WriteLine("Personel güncellendi");
    }
}

class InternManager: IPersonManager
{
    public void Add()
    {
        Console.WriteLine("Stajyer eklendi");
    }

    public void Update()
    {
        Console.WriteLine("Stajyer güncellendi");
    }
}
class ProjectManager
{
    public void Add(IPersonManager personManager)
    {
        personManager.Add();
    }
}