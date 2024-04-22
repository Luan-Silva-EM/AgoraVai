using Projeto1;

namespace EM
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] apple = { 'a', 'p', 'p', 'l', 'e' };

            char[] reversed = apple.Reverse().ToArray();

            foreach (char chr in reversed)
            {
                Console.Write(chr + " ");
            }

            Console.WriteLine();

        }
    }
}