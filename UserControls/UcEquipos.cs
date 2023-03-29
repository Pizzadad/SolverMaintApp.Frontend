using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;

namespace SolverMaintApp.Frontend.UserControls
{
    public partial class UcEquipos : UserControl
    {
        public UcEquipos()
        {
            InitializeComponent();
        }

        private void UcEquipos_Load(object sender, EventArgs e)
        {
            try
            {
                treeView1.Nodes.Clear();
                var json = File.ReadAllText(@"D:\Proyectos Personales\Project Net\SolverMaintApp.Frontend\SolverMaintApp.Frontend\Resources\JsonTest\depa3.json");
                JsonToTreeView.JsonToTreeWithImage(treeView1, imageList1, json, "Node");
                treeView1.ExpandAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"ERROR");
            }
        }
    }
}
