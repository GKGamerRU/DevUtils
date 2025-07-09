using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using FlatUI;

namespace DevUtilsAPI
{
    class Encryptor_Decryptor : PageModule
    {
        FlatTextBox Password;

        FlatTextBox origin;
        FlatTextBox Result;
        FlatButton Encrypt;
        FlatButton Decrypt;

        FlatButton LoadFile;
        FlatButton SaveFile;

        public override void GeneratePage()
        {
            Password = UIs.CreateFlatTextbox("Enter your Password (32 characters)", new Point(5, 5),new Size(450,30), AnchorStyles.None);
            Password.BackColor = Color.Orange;
            
            origin = UIs.CreateFlatTextbox("Enter your text", new Point(5, 5 + Password.Height + 15), new Size(450, 100), AnchorStyles.None, true);
            Result = UIs.CreateFlatTextbox("", new Point(5, 10 + origin.Height + Password.Height + 15), new Size(450, 100), AnchorStyles.None,true);

            LoadFile = UIs.CreateFlatButton("Load text from File", new Point(5, 15 + origin.Height + Password.Height + 15 + Result.Height), new Size(220, 50), AnchorStyles.None);
            LoadFile.Click += LoadFile_Click;

            SaveFile = UIs.CreateFlatButton("Save result to File", new Point(230, 15 + origin.Height + Password.Height + 15 + Result.Height), new Size(220, 50), AnchorStyles.None);
            SaveFile.Click += SaveFile_Click;

            Encrypt = UIs.CreateFlatButton("Show Encrypted", new Point(455 / 2 - 250 / 2, 170 + 170 + 10 + 10), new Size(250, 30), AnchorStyles.None);
            Encrypt.Click += Calculate_Click;

            Decrypt = UIs.CreateFlatButton("Show Decrypted", new Point(455 / 2 - 250 / 2, 170 + 170 + 10 + 10 - 35), new Size(250, 30), AnchorStyles.None);
            Decrypt.Click += Decrypt_Click;

            Control[] collection = new Control[]
            {
                Password,origin,Result,LoadFile,SaveFile,Encrypt,Decrypt
            };
            PlaceToPanel(collection);
        }

        private void SaveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog operation = new SaveFileDialog();
            operation.RestoreDirectory = true;

            if (operation.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(operation.FileName, Result.Text);
            }
        }

        private void LoadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog operation = new OpenFileDialog();
            var result = operation.ShowDialog();

            if (result == DialogResult.OK)
            {
                origin.Text = File.ReadAllText(operation.FileName);
            }
        }

        private void Decrypt_Click(object sender, EventArgs e)
        {
            Result.Text = DevUtilsAPI.Crypto.DecryptString(Password.Text, origin.Text);
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            Result.Text = DevUtilsAPI.Crypto.EncryptString(Password.Text, origin.Text);
        }
    }
}
