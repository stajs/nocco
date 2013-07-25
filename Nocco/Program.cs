// The entrance point for the program.  Just run Nocco!

namespace Nocco
{
    class Program
    {
        static void Main(string[] args)
        {
			  args = new string[] { "*.cs"};
            Nocco.Generate(args);
        }
    }
}
