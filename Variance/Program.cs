using System;
using System.Collections.Generic;

namespace Variance
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IEnumerable<IBar> fooBar = GetBar();

            // Uncomment to see compiler error
            //IEnumerable<FooBar> f = GetBar();

            // Why does this not generate a compiler error; instead of waiting until runtime?
            foreach (FooBar element in fooBar)
            {
                Console.WriteLine(element.DoBar());
            }

            Console.ReadKey();
        }

        public static IEnumerable<IBar> GetBar()
        {
            // Return two different implementations of IBar
            return new List<IBar> { new FooBar(), new FooBar(), new MyBar(), new MyBar() };
        }
    }

    public interface IFoo
    {
        string DoFoo();
    }

    public interface IBar
    {
        string DoBar();
    }

    public class FooBar : IFoo, IBar
    {
        public string DoFoo() => "FooBar";

        public string DoBar() => "FooBar";
    }

    public class MyBar : IBar
    {
        public string DoBar() => "MyBar";
    }
}
