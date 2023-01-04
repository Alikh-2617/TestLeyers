using TestLeyers.Servises.LayersServises_controller.Database;
using TestLeyers.Servises.ServisesForAddToDatabase;

namespace TestLeyers.Servises.Container
{
    public class IocContainer
    {
        // här bör return en Interface Model till Controller 

        // eller vi kan använda ninject packeg och inte använda den file

        public IUserServise SetUserServis()
        {
            return new UserServiseWithMySQL();   
        }

        public ISendUsers GetUserServise()
        {
            return new GetUserFromMySQL();
        }
    }
}
    