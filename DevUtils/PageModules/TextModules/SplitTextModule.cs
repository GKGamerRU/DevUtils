using FlatUI;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DevUtilsAPI
{
    internal class SplitTextModule : PageModule
    {
        FlatTextBox splitter;
        FlatTextBox origin;
        FlatTextBox Result;

        FlatButton Decrypt;

        public override void GeneratePage()
        {
            splitter = UIs.CreateFlatTextbox("Enter char. Example ','", new Point(5, 5), new Size(450, 30), AnchorStyles.None);
            splitter.BackColor = Color.Orange;

            origin = UIs.CreateFlatTextbox("Enter your text", new Point(5, 5 + splitter.Height + 15), new Size(450, 100), AnchorStyles.None, true);
            Result = UIs.CreateFlatTextbox("", new Point(5, 10 + origin.Height + splitter.Height + 15), new Size(450, 100), AnchorStyles.None, true);

            Decrypt = UIs.CreateFlatButton("Show Decrypted", new Point(455 / 2 - 250 / 2, 170 + 170 + 10 + 10 - 65), new Size(250, 30), AnchorStyles.None);
            Decrypt.Click += Decrypt_Click;

            Control[] collection = new Control[]
            {
                splitter,origin,Result,Decrypt
            };
            PlaceToPanel(collection);
        }

        private void Decrypt_Click(object sender, EventArgs e)
        {
            Result.Text = string.Join(Environment.NewLine, origin.Text.Split(new string[] { splitter.Text }, StringSplitOptions.RemoveEmptyEntries).Select(n => n.Trim()));
        }
    }
}
