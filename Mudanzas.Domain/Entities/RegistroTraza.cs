using System;

namespace Mudanzas.Domain.Entities
{
    public class RegistroTraza
    {
        public int Id { get; set; }
        public string CedulaEjecutor { get; set; }
        public DateTime FechaEjecucion { get; set; }
    }
}
