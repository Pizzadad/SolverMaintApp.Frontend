using SolverMaintApp.Frontend.Helpers;
using SolverMaintApp.Frontend.UserControls;

namespace SolverMaintApp.Frontend
{
    public partial class Form1 : Form
    {
        static Form1 _obj;
        FullScreen fullScreen;
        public static Form1 Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Form1();
                }
                return _obj;
            }
        }
        public Form1()
        {
            InitializeComponent();
            fullScreen = new FullScreen(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _obj = this;
        }

        private void fichaTecnicaToolStripButton_Click(object sender, EventArgs e)
        {
            lblTitle.Text = fichaTecnicaToolStripButton.Text;

            panelUserControler.Controls.Clear();

            UcFichaTecnica ucFichaTecnica = new UcFichaTecnica();
            ucFichaTecnica.Dock = DockStyle.Fill;
            panelUserControler.Controls.Add(ucFichaTecnica);
        }

        private void equiposToolStripButton_Click(object sender, EventArgs e)
        {
            lblTitle.Text = equiposToolStripButton.Text;

            panelUserControler.Controls.Clear();
            UcEquipos ucEquipos = new UcEquipos();
            ucEquipos.Dock = DockStyle.Fill;

            panelUserControler.Controls.Add(ucEquipos);
        }
    }
}