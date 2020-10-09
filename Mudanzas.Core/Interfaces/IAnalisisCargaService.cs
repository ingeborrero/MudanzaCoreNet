using Mudanzas.Domain.Entities;

namespace Mudanzas.Core.Interfaces
{
    public interface IAnalisisCargaService
    {
        OutputResult EjecutarAnalisis(InputMain pEntrada);
    }
}
