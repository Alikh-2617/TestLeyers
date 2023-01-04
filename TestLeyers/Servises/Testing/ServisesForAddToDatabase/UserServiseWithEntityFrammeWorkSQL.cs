using TestLeyers.Models;

namespace TestLeyers.Servises.ServisesForAddToDatabase
{
    public class UserServiseWithEntityFrammeWorkSQL : IUserServise
    {
        public void Add(UserModel user)
        {
            Console.WriteLine("UserServiseWithEntityFrammeWorkSQL");
        }
    }
}
