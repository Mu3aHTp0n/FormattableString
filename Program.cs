using System;
using System.Reflection;

namespace FormattableString
{
    internal class Program
    {
        static void Main()
        {
            Type t = typeof(System.FormattableString);
            Console.WriteLine("Методы:");
            foreach (MethodInfo method in t.GetMethods())
            {
                Console.WriteLine($"Name: {method.Name}");
                Console.WriteLine($"IsAbstract: {method.IsAbstract}");
                Console.WriteLine($"IsFamily: {method.IsFamily}");
                Console.WriteLine($"IsFamilyAndAssembly: {method.IsFamilyAndAssembly}");
                Console.WriteLine($"IsFamilyOrAssembly: {method.IsFamilyOrAssembly}");
                Console.WriteLine($"IsAssembly: {method.IsAssembly}");
                Console.WriteLine($"IsPrivate: {method.IsPrivate}");
                Console.WriteLine($"IsPublic: {method.IsPublic}");
                Console.WriteLine($"IsConstructor: {method.IsConstructor}");
                Console.WriteLine($"IsStatic: {method.IsStatic}");
                Console.WriteLine($"IsVirtual: {method.IsVirtual}");
                Console.WriteLine($"ReturnType: {method.ReturnType.Name}");
                Console.WriteLine();
            }

            Console.WriteLine("Конструкторы:");
            foreach (ConstructorInfo constructor in t.GetConstructors())
            {
                Console.WriteLine($"IsFamily: {constructor.IsFamily}");
                Console.WriteLine($"IsFamilyAndAssembly: {constructor.IsFamilyAndAssembly}");
                Console.WriteLine($"IsFamilyOrAssembly: {constructor.IsFamilyOrAssembly}");
                Console.WriteLine($"IsAssembly: {constructor.IsAssembly}");
                Console.WriteLine($"IsPrivate: {constructor.IsPrivate}");
                Console.WriteLine($"IsPublic: {constructor.IsPublic}");
                Console.WriteLine();
            }

            Console.WriteLine("Поля:");
            foreach (FieldInfo field in t.GetFields())
            {
                Console.WriteLine($"Name: {field.Name}");
                Console.WriteLine($"IsFamily: {field.IsFamily}");
                Console.WriteLine($"IsFamilyAndAssembly: {field.IsFamilyAndAssembly}");
                Console.WriteLine($"IsFamilyOrAssembly: {field.IsFamilyOrAssembly}");
                Console.WriteLine($"IsAssembly: {field.IsAssembly}");
                Console.WriteLine($"IsPrivate: {field.IsPrivate}");
                Console.WriteLine($"IsPublic: {field.IsPublic}");
                Console.WriteLine($"IsStatic: {field.IsStatic}");
                Console.WriteLine();
            }

            Console.WriteLine("Свойства:");
            foreach (PropertyInfo property in t.GetProperties())
            {
                Console.WriteLine($"Name: {property.Name}");
                Console.WriteLine($"Attributes: {property.Attributes}");
                Console.WriteLine($"CanRead: {property.CanRead} ");
                Console.WriteLine($"CanWrite: {property.CanWrite}");
                Console.WriteLine($"GetMethod: {property.GetMethod}");
                Console.WriteLine($"SetMethod: {property.SetMethod}");
                Console.WriteLine($"PropertyType: {property.PropertyType.Name}");
                Console.WriteLine();
            }
        }
    }
}
 


    