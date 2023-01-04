using TestLeyers.Models;
using TestLeyers.Servises.LayersServises_controller.Database;

namespace TestLeyers.Servises.ServisesForAddToDatabase
{
    public class GetUserFromEntityFrammeWorkSQL : ISendUsers
    {
        public List<UserModel> GetUsers()
        {
            return new List<UserModel>();
        }
    }
}
