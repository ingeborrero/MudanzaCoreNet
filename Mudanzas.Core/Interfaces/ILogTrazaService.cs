using Mudanzas.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mudanzas.Core.Interfaces
{   
    public interface ILogTrazaService
    {
        Int64 GrabarLogTraza(string cedula, DateTime fecha);
        List<RegistroTraza> ObtenerLogTraza();
    }
}
