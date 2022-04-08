using Fractalis.Domain;

namespace Fractalis
{
    public partial class frmMain : Form
    {
        Bitmap bitmap;
        JuliaSet juliaSet;

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {            
            bitmap = new Bitmap(600, 600);
            juliaSet = new JuliaSet(bitmap);
            
            juliaSet.Render(bitmap);
            
        }

        private void tmrImage_Tick(object sender, EventArgs e)
        {
            if(juliaSet != null && juliaSet.Image != null)
                pictureBox1.BackgroundImage = juliaSet.Image;            
        }
    }
}