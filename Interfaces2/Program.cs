using System;

namespace Interfaces2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Interfaceler New yapilamaz
          //  IPersonManager customerManager = new CustomerManager();
           // customerManager.Add();

           // IPersonManager employeeManager = new EmployeeManager();
          //  employeeManager.Update();

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new CustomerManager());

        }
    }
    interface IPersonManager
    {
        void Add();
        void Update();
    }
    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Musteri Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Musteri guncellendi");
        }
    }
    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Personel Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("personel guncellendi");
        }
    }
    class ProjectManager
    {
        public void Add(IPersonManager  personManager)
        {
            
            personManager.Add();
        }
       
    }
}
