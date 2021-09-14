using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01.Day06
{
    abstract class SuperAbstract 
    {
        public void NormalFun()
        {
            Console.WriteLine("Normal Function Of Abstract Class");
        }

        public virtual void VirtualFunc()
        {
            Console.WriteLine("Virtual function Of Abstract Class");
        }
        public abstract void SueprFunc();
    }

    class SuperImplementor : SuperAbstract
    {
        public override void SueprFunc()
        {
            Console.WriteLine("Super Function Of Super Implementor Class");
        }
    }
    class AbstractExample
    {
        static void Main(string[] args)
        {
            SuperAbstract obj = new SuperImplementor();
            obj.NormalFun();
            obj.SueprFunc();
            obj.VirtualFunc();
            Console.ReadLine();
        }
    }
}
