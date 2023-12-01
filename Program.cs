using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Sistema
{
    class Program
    {
        static void Main(string[] args)
        {
            Login login = new Login();
            login.Logar();
        }
    }
}