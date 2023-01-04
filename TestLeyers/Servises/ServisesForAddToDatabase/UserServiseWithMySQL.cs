using TestLeyers.Models;

namespace TestLeyers.Servises
{
    public class UserServiseWithMySQL : IUserServise
    {
        public string Add(UserModel user)
        {
            return "UserServiseWithMySQL";
        }
    }
}
