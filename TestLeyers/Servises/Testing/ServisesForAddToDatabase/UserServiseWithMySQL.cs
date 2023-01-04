using TestLeyers.Models;

namespace TestLeyers.Servises
{
    public class UserServiseWithMySQL : IUserServise
    {
        public void Add(UserModel user)
        {
            Console.WriteLine("UserServiseWithMySQL");
        }
    }
}
