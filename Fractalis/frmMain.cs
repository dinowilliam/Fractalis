using Fractalis.Domain;
using Fractalis.Domain.Base;
using Fractalis.Domain.Contracts;

namespace Fractalis
{
    public partial class frmMain : Form
    {        
        private IFractal fractalToRun;
        private readonly BaseApplication _baseApplication;
        private Dictionary<string, IFractal> fractalsList;

        public frmMain(){

            InitializeComponent();

            _baseApplication = new BaseApplication();
            _baseApplication.StartupPath = Application.StartupPath;

            fractalsList = new Dictionary<string, IFractal> {
                { "Julia Set",  new JuliaSet(_baseApplication) },
                { "Multi Julia Set",  new MultiJuliaSet(_baseApplication) },
            };

            cmbFractalList.DataSource = fractalsList.Select(f => f.Key).ToList();

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            fractalsList.TryGetValue(cmbFractalList.SelectedItem.ToString(), out fractalToRun);

            fractalToRun.c = new BaseComplex(Convert.ToDouble(nudCRealPart.Value), Convert.ToDouble(nudCImaginaryPart.Value));

            if (fractalToRun.IsMultiFractal){
                lblMultiFractalValue.Visible = fractalToRun.IsMultiFractal;
                nudMultiFractalValue.Visible = fractalToRun.IsMultiFractal;
                fractalToRun.N = Convert.ToInt32(nudMultiFractalValue.Value);
            }

            fractalToRun.Render(new Bitmap(1920, 1080), Convert.ToInt32(nudZoom.Value), 0, 0, chkInverted.Checked);            
        }

        private void tmrImage_Tick(object sender, EventArgs e)
        {
            if(fractalToRun != null && fractalToRun.Image != null)
                pcbFractal.BackgroundImage = fractalToRun.Image;            
        }

        private void btnSave_Click(object sender, EventArgs e){

            fractalToRun.Save();
        }
    }
}