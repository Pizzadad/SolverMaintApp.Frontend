using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolverMaintApp.Frontend.Entities
{
    internal class FichaTecnicaModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? CodGrupo { get; set; }
        public string? Description { get; set; }
        public string? Codigo { get; set; }
        public string? CodLocal { get; set; }
        public string? Supervisor { get; set; }
        public string? Marca { get; set; }
        public string? Modelo { get; set; }
        public string? NroSerie { get; set; }
        public DateTime FecFab { get; set; }
        public DateTime FecPtaServ { get; set; }
        public string? Parametro1 { get; set; }
        public string? Parametro2 { get; set; }
        public string? Esquema { get; set; }

        public string? NOverhaul { get; set; }
        public DateTime FecBaja { get; set; }
        public string? Prioridad { get; set; }

        public string? Status1 { get; set; }
        public string? Status2 { get; set; }

        public decimal? ManoObra { get; set; }
        public decimal? Repuestos { get; set; }
        public decimal? Terceros { get; set; }
        public decimal? CostoTotal { get; set; }

        public string? ImgItem { get; set; }

        public UbicacionItem? Ubicacion { get; set; }
        
    }

    class UbicacionItem
    {
        public int Id { get; set; }

        public string? Codigo { get; set; }
        public string? Unidad { get; set; }
        public string? Area { get; set; }
        public string? Seccion { get; set; }
    }
}
