using SolverMaintApp.Frontend.BussinesLogic;
using SolverMaintApp.Frontend.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SolverMaintApp.Frontend.UserControls
{
    public partial class UcFichaTecnica : UserControl
    {
        int positionItem = 0;
        List<FichaTecnicaModel> lstFichaTecnicaModels = new List<FichaTecnicaModel>();
        public UcFichaTecnica()
        {
            InitializeComponent();
        }

        private void UcFichaTecnica_Load(object sender, EventArgs e)
        {
            var json = new FichaTecnicaBL().getFichaTecnica();

            lstFichaTecnicaModels = new FichaTecnicaBL().parseFichaTecnica(json);

            var rst = new FichaTecnicaBL().findFichaTecnica(lstFichaTecnicaModels, 0);

            fichaTecnicaToTools(rst);
        }

        private void fichaTecnicaToolStripBtnNext_Click(object sender, EventArgs e)
        {
            if (positionItem < lstFichaTecnicaModels.Count - 1)
            {
                positionItem += 1;

                var rst = new FichaTecnicaBL().findFichaTecnica(lstFichaTecnicaModels, positionItem);
                fichaTecnicaToTools(rst);
            }
        }

        private void fichaTecnicaToolStripBtnPrevius_Click(object sender, EventArgs e)
        {
            if (positionItem > 0)
            {
                positionItem -= 1;
                var rst = new FichaTecnicaBL().findFichaTecnica(lstFichaTecnicaModels, positionItem);
                fichaTecnicaToTools(rst);
            }
        }

        private void fichaTecnicaToolStripBtnAllPrevius_Click(object sender, EventArgs e)
        {
            if (positionItem > 0)
            {
                positionItem = 0;
                var rst = new FichaTecnicaBL().findFichaTecnica(lstFichaTecnicaModels, positionItem);
                fichaTecnicaToTools(rst);
            }
        }

        private void fichaTecnicaToolStripBtnAllNext_Click(object sender, EventArgs e)
        {
            if (positionItem != lstFichaTecnicaModels.Count - 1)
            {
                positionItem = lstFichaTecnicaModels.Count - 1;
                var rst = new FichaTecnicaBL().findFichaTecnica(lstFichaTecnicaModels, positionItem);
                fichaTecnicaToTools(rst);
            }
        }
        #region Code

        private void fichaTecnicaToTools(FichaTecnicaModel fichaTecnicaModel)
        {
            fichaTecnicaToolStripDesItem.Text = fichaTecnicaModel.Name;

            txtCodGrupo.Text = fichaTecnicaModel.CodGrupo;
            txtDescription.Text = fichaTecnicaModel.Description;
            txtCodigo.Text = fichaTecnicaModel.Codigo;
            txtCodLocal.Text = fichaTecnicaModel.CodLocal;
            txtModelo.Text = fichaTecnicaModel.Modelo;
            txtNroSerie.Text = fichaTecnicaModel.NroSerie;

            dateFecFab.Value = fichaTecnicaModel.FecFab;
            dateFecPtaServ.Value = fichaTecnicaModel.FecPtaServ;

            txtNOverhaul.Text = fichaTecnicaModel.NOverhaul;
            txtPrioridad.Text = fichaTecnicaModel.Prioridad;
            dateFecBaja.Value = fichaTecnicaModel.FecBaja;

            pcbFichaTecnica.LoadAsync($@"{fichaTecnicaModel.ImgItem}");

            txtUbiCodigo.Text = fichaTecnicaModel.Ubicacion?.Codigo;
            txtUbiUnidad.Text = fichaTecnicaModel.Ubicacion?.Unidad;
            txtUbiArea.Text = fichaTecnicaModel.Ubicacion?.Area;
            txtUbiSeccion.Text = fichaTecnicaModel.Ubicacion?.Seccion;

        }

        #endregion
    }
}
