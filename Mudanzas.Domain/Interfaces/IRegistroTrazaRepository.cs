using Mudanzas.Domain.Entities;

namespace Mudanzas.Domain.Interfaces
{
    public interface IRegistroTrazaRepository
    {
        RegistroTraza Agregar(RegistroTraza registroTraza);
    }
}
