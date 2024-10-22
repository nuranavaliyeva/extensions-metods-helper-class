using System.Security.Cryptography.X509Certificates;

namespace Static_class__Extensions_methods___Exception__Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 4;
            Console.WriteLine(num.IsEven());
            int num2 = 6;
            Console.WriteLine(num.IsOdd());
            string word = "1nurana";
            Console.WriteLine(word.HasDigit());
            string Password = "nuraNa123";
            Console.WriteLine(Password.CheckPassword());
            string word2 = "nurana";
            Console.WriteLine(word2.Capitalize());
            
        }
    }
}
