using Builder.Pattern;
using Builder.Pattern.AssemblyBuilder;
using Builder.Pattern.Builder;
using Builder.Product;
using System;

namespace Builder {

    class Program {

        static void Main(string[] args) {

            var builder = new ConcreteBuilder();
            var assemblyBuilder = new AssemblyBuilder();

            Foreman foreman = new Foreman(builder, assemblyBuilder);
            if (foreman.Construct() != null) {
                Console.WriteLine("__Продукт готовий__");
            }

            Console.ReadKey();
        }
    }
}