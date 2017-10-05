using System;
using System.Windows.Forms;

namespace FcNet.FormStyleJson.Sample
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            ThemeEngine.ApplyTheme(this);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
