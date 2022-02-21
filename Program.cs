using System;
using static Sharp12.Tasks;

namespace Sharp12
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(Reverse("sometimes i think about killing myself"));
            Console.WriteLine(IsFormattableImplemented("formidable"));
            Console.WriteLine(AsFormattableImplemented("formidable"));
            BadCode("C:/Users/ArtSt/RiderProjects/Sharp12/retard.c");
            BadCode("meth");
        }
    }
}