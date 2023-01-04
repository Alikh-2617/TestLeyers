namespace TestLeyers.Servises.Container
{
    public class IocContainer
    {
        public IUserServise GetUserServis()
        {
            return new UserServiseWithMySQL();   
        }
    }
}
    