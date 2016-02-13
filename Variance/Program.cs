using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Variance
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IEnumerable<IBar> fooBar = GetBar();

            foreach(FooBar element in fooBar)
            {
                Console.WriteLine(element.DoBar());
            }

            Console.ReadKey();
        }

        public static IEnumerable<IBar> GetBar()
        {
            return new List<IBar> { new FooBar(), new FooBar(), new MyBar() };
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
