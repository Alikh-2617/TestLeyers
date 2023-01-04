using TestLeyers.Models;

namespace TestLeyers.Servises.LayersServises_controller.Database
{
    public interface ISendUsers
    {
        List<UserModel> GetUsers();
    }
}
