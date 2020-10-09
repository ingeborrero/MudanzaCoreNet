namespace Mudanzas.Infraestructure.Interfaces
{
    public interface ILogTrazaRepository
    {
        string GetKeysRedis(string key);

        bool SetKeysRedis(string key, string value);
    }
}
