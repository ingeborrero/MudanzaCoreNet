using Mudanzas.Infraestructure.Interfaces;
using StackExchange.Redis;

namespace Mudanzas.Infraestructure
{
    public class LogTrazaRepository: ILogTrazaRepository
    {
        private readonly IConnectionMultiplexer _connectionMultiplexer;
        public LogTrazaRepository(IConnectionMultiplexer connectionMultiplexer)
        {
            _connectionMultiplexer = connectionMultiplexer;
        }

        public string GetKeysRedis(string key)
        {
            var db = _connectionMultiplexer.GetDatabase();
            return db.StringGet(key);
        }

        public bool SetKeysRedis(string key, string value)
        {
            var db = _connectionMultiplexer.GetDatabase();
            return db.StringSet(key, value);
        }
    }
}
