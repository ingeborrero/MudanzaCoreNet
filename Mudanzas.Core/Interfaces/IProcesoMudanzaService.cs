using Mudanzas.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mudanzas.Core.Interfaces
{
    public interface IProcesoMudanzaService
    {
        OutputResult ProcesarDatos(string pArchivo64, string cedula);
    }
}
