using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01.Day07
{
    interface ISimpleInterface
    {
         void SimpleFunc();
    }

    interface IExampleInterface
    {
        void ExampleFunc();
    }

    interface ICustomer
    {
        void Create();
    }

    interface IAccount
    {
        void Create();
    }


    class CustomerAccount : IAccount, ICustomer
    {
        public void Create()
        {
            Console.WriteLine("Create Customer And Account");
        }
        void ICustomer.Create()
        {
            Console.WriteLine("Create Customer");        
        }

        void IAccount.Create()
        {
            Console.WriteLine("Create Account");
        }
    }
    class SimpleClass : IExampleInterface, ISimpleInterface
    {
        public void ExampleFunc()
        {
            Console.WriteLine("Example Implementstion");
        }

        public void SimpleFunc()
        {
            Console.WriteLine("SimpleFunc Implementation");
        }
    }
    class InterfacesDemo
    {
        static void Main(string[] args)
        {
            CustomerAccount obj = new CustomerAccount();
            obj.Create();
            IAccount ia = new CustomerAccount();
            ia.Create();
            ICustomer ic = new CustomerAccount();
            ic.Create();
            //SimpleClass obj = new SimpleClass();
            //obj.ExampleFunc();
            //obj.SimpleFunc();
            //IExampleInterface ex = new SimpleClass();
            //ex.ExampleFunc();

            //ISimpleInterface sim = (ISimpleInterface)ex;
            //sim.SimpleFunc();
            Console.ReadLine();
        }
    }
}
