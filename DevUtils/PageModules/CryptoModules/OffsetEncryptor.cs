using DevUtilsAPI;
using FlatUI;
using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace DevUtils.PageModules.CryptoModules
{
    internal class OffsetEncryptor : PageModule
    {
        FlatTextBox Password;

        FlatTextBox origin;
        FlatTextBox Result;
        FlatButton Encrypt;

        FlatButton LoadFile;
        FlatButton SaveFile;

        Encoding encoding = Encoding.Unicode;

        public override void GeneratePage()
        {
            Password = UIs.CreateFlatTextbox("1930003", new Point(5, 5), new Size(200, 30), AnchorStyles.None);
            Password.BackColor = Color.Orange;
            var enchoType = UIs.CreateFlatComboBox("Select output format", new Point(205, 5), new Size(250, 30), AnchorStyles.None);
            enchoType.DataSource = new[]
            {
                Encoding.UTF8,
                Encoding.Unicode,
            };

            enchoType.SelectedValueChanged += delegate { encoding = enchoType.SelectedValue as Encoding; };

            origin = UIs.CreateFlatTextbox("Enter your text", new Point(5, 5 + Password.Height + 15), new Size(450, 100), AnchorStyles.None, true);
            Result = UIs.CreateFlatTextbox("", new Point(5, 10 + origin.Height + Password.Height + 15), new Size(450, 100), AnchorStyles.None, true);

            LoadFile = UIs.CreateFlatButton("Load text from File", new Point(5, 15 + origin.Height + Password.Height + 15 + Result.Height), new Size(220, 50), AnchorStyles.None);
            LoadFile.Click += LoadFile_Click;

            SaveFile = UIs.CreateFlatButton("Save result to File", new Point(230, 15 + origin.Height + Password.Height + 15 + Result.Height), new Size(220, 50), AnchorStyles.None);
            SaveFile.Click += SaveFile_Click;

            Encrypt = UIs.CreateFlatButton("Encrypt/Decrypt", new Point(455 / 2 - 250 / 2, 170 + 170 + 10 + 10), new Size(250, 30), AnchorStyles.None);
            Encrypt.Click += XorCrypto;

            Control[] collection = new Control[]
            {
                Password,origin,Result,LoadFile,SaveFile,Encrypt,enchoType
            };
            PlaceToPanel(collection);
        }

        private void SaveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog operation = new SaveFileDialog();
            operation.RestoreDirectory = true;

            if (operation.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllBytes(operation.FileName, encoding.GetBytes(Result.Text));
            }
        }

        private void LoadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog operation = new OpenFileDialog();
            var result = operation.ShowDialog();

            if (result == DialogResult.OK)
            {
                origin.Text = encoding.GetString(File.ReadAllBytes(operation.FileName));
            }
        }

        void XorCrypto(object sender, EventArgs e)
        {
            var bytes = encoding.GetBytes(origin.Text);

            for (int i = 0; i < bytes.Length; i++)
            {
                bytes[i] = (byte)(bytes[i] ^ int.Parse(Password.Text));
            }

            Result.Text = encoding.GetString(bytes);
        }
    }
}