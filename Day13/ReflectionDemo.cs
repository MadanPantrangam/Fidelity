using Day01.Day03;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Day01.Day13
{
    class MathReflectionExample
    {
        public double AddFunc(double v1, double v2) => v1 + v2;
        public double SubFunc(double v1, double v2) => v1 - v2;
        public double MulFunc(double v1, double v2) => v1 * v2;
        public double DivFunc(double v1, double v2) => v1 / v2;
    }
    class ReflectionDemo
    {
        static void Main(string[] args)
        {
            // displayAllTypes();
            //lateBinding();
            readFromExternalAssembly();
            Console.ReadLine();
        }

        private static void readFromExternalAssembly()
        {
            var assembly = Assembly.LoadFile(@"C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\v4.7.2\mscorlib.dll");
            var types = assembly.GetTypes();
            foreach (var type in types)
            {
                if (type.IsValueType)
                {
                    if (type.IsEnum)
                    {
                        Console.WriteLine($"{type.Name} is Enum");
                    }
                    else
                    {
                        Console.WriteLine(type.Name);
                    }
                }
            }
        }

        private static void lateBinding()
        {
           Type type= SelectedClassFromAssembly();
            invokeMethod(type);
        }

        private static void invokeMethod(Type type)
        {
            string methodName = HelperClass.GetString("Enter Method Name from List of above");
            MethodInfo selectedMethod = type.GetMethod(methodName);
            object objInstance = Activator.CreateInstance(type);
            ParameterInfo[] allparameters = selectedMethod.GetParameters();
            object[] parameters = new object[allparameters.Length];
            for (int i = 0; i < allparameters.Length; i++)
            {
                Console.WriteLine("Enter Value of {0} of the Type {1}",allparameters[i].Name,allparameters[i].ParameterType.Name);
                parameters[i] = Convert.ChangeType(Console.ReadLine(), allparameters[i].ParameterType);
            }

            object result = selectedMethod.Invoke(objInstance, parameters);
            Console.WriteLine("The VAlue is"+result);

        }

        private static Type SelectedClassFromAssembly()
        {
            string clsName = HelperClass.GetString("Enter Full Name of Class That You Want to see:");
            Type type = Type.GetType(clsName);
            var methods = type.GetMethods();
            foreach (var method in methods)
            {
                Console.WriteLine($"{method.Name} - Return Type: {method.ReturnType.Name}");
                if (method.GetParameters().Length != 0)
                {
                    foreach (var pm in method.GetParameters())
                    {
                        Console.WriteLine($"{pm.Name} - it's DataType:{pm.ParameterType.Name}");
                    }
                }
            }
            return type;
        }

        private static void displayAllTypes()
        {
            Assembly CurrentEx = Assembly.GetExecutingAssembly();
            var classes = CurrentEx.GetTypes();
            HashSet<string> nameSpaces = new HashSet<string>();

            foreach (var cls in classes)
            {
                nameSpaces.Add(cls.Namespace);
                if (cls.IsInterface)
                {
                    Console.WriteLine($"{cls.Name} is an Interface");
                }
                else if (cls.IsGenericType)
                {
                    Console.WriteLine($"{cls.Name} is a Generic");
                }
                else
                {
                    Console.WriteLine(cls.Name);
                }
            }
            Console.WriteLine("The list of NameSpaces with us:");
            foreach (var item in nameSpaces)
            {
                Console.WriteLine(item);
            }
        }
    }
}
