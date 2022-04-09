using Fractalis.Domain;
using Fractalis.Domain.Contracts;

namespace Fractalis
{
    public partial class frmMain : Form
    {        
        IFractal fractalToRun;

        Dictionary<string, IFractal> fractalsList = new Dictionary<string, IFractal> {
            { "Julia Set",  new JuliaSet(new Bitmap(1920, 1080)) }        
        };

        public frmMain()
        {
            InitializeComponent();

            cmbFractalList.DataSource = fractalsList.Select(f => f.Key).ToList();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            fractalsList.TryGetValue(cmbFractalList.SelectedItem.ToString(), out fractalToRun);

            fractalToRun.Render(new Bitmap(1920, 1080), Convert.ToInt32(nudZoom.Value), 0, 0, chkInverted.Checked);            
        }

        private void tmrImage_Tick(object sender, EventArgs e)
        {
            if(fractalToRun != null && fractalToRun.Image != null)
                pcbFractal.BackgroundImage = fractalToRun.Image;            
        }

        private void btnSave_Click(object sender, EventArgs e){

            string[] files = Directory.GetFiles(Application.StartupPath, "julia-set*.png");

            string fileName = files.Count() > 0 ? "julia-set" + (files.Count() + 1) + ".png" : "julia-set1.png";

            fractalToRun.Image.Save(fileName);
        }
    }
}