using System;

namespace Mudanzas.Domain.Entities
{
    public class RegistroTraza
    {
        public Int64 Id { get; set; }
        public string CedulaEjecutor { get; set; }
        public DateTime FechaEjecucion { get; set; }
    }
}
