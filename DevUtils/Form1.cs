using DevUtilsAPI;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DevUtils
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DevUtilsAPI.UIs.Interface = panel2;
            DevUtilsAPI.UIs.PanelOfButtons = OptionsTools;
            FlatUI.Helpers.FlatColor = Color.Silver;
            DevUtilsAPI.Core.Start();
        }

        readonly WelcomePage welcomePage = new WelcomePage();
        private void flatLabel1_Click(object sender, EventArgs e)
        {
            UIs.ClearPanel(); welcomePage.GeneratePage();
        }
    }
}
