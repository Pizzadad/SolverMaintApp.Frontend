using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SolverMaintApp.Frontend.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolverMaintApp.Frontend.BussinesLogic
{
    internal class FichaTecnicaBL
    {

        public string getFichaTecnica()
        {
            var json = File.ReadAllText(@"D:\Proyectos Personales\Project Net\SolverMaintApp.Frontend\SolverMaintApp.Frontend\Resources\JsonTest\FichaTecnica.json");
            return json;
        }

        public List<FichaTecnicaModel> parseFichaTecnica(string Json)
        {
            List<FichaTecnicaModel> lstFichaTecnicaModel = new List<FichaTecnicaModel>();

            lstFichaTecnicaModel = JsonConvert.DeserializeObject<List<FichaTecnicaModel>>(Json, new IsoDateTimeConverter { DateTimeFormat = "dd-MM-yyyy" });

            return lstFichaTecnicaModel;
        }

        public FichaTecnicaModel findFichaTecnica(List<FichaTecnicaModel> lstFichaTecnicaModels, int position)
        {
            FichaTecnicaModel fichaTecnicaModel = lstFichaTecnicaModels[position];
            return fichaTecnicaModel;
        }
       
    }
}
