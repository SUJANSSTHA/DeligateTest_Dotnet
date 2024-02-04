using System.ComponentModel.DataAnnotations;

namespace DeligateTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //Geometry.Area(12,12)
            int length, breadth;
            Console.WriteLine("Enter length:");
            length=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter breadth:");
            breadth=Convert.ToInt32(Console.ReadLine());
            /*Console.WriteLine($"Area:{Geometry.Area(length, breadth)}");
            Geometry g = new ();
            g.ShowMessage("Testing Delegates");*/
            Delegate1 d = new(Geometry.Area);
          Console.WriteLine($"Area:{Geometry.Area(length, breadth)}");
            Geometry g = new();
            Delegate2 de = new(g.ShowMessage);
            de("Teesting Delegate");
        }
    }
    public class Geometry
    {

        public static int Area(int length, int breadth)
        {
            return length + breadth;
        }
        public static int Perimeter(int length, int breadth)
        {
            return 2*(length + breadth);
        }
        public void ShowMessage(String meg)
        {
            Console.WriteLine(@"hello, this is your messgae:{meg}");

        }

    }
    //delegate definition
    public delegate int Delegate1(int a, int b);
/*fe*/
    public delegate void Delegate2(String  meg);
}