using System;
using System.Drawing;
using DevUtilsAPI;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;

namespace DevUtils.PageModules.VisualModules
{
    internal class ImageConvertor : PageModule
    {
        Bitmap Bitmap { get; set; }
        ImageFormat Format { get; set; }
        public override void GeneratePage()
        {
            var imageSelect = UIs.CreateFlatButton("Select Image File", new Point(5, 5), new Size(340, 30), AnchorStyles.None);
            imageSelect.Click += ImageSelect_Click;

            var imageType = UIs.CreateFlatComboBox("Select output format", new Point(350, 5), new Size(95, 30), AnchorStyles.None);
            imageType.DataSource = new[]
            {
                ImageFormat.Png,
                ImageFormat.Jpeg,
                ImageFormat.Gif,
                ImageFormat.Bmp,
                ImageFormat.Tiff,
                ImageFormat.Icon,
                ImageFormat.Wmf
            };
            imageType.SelectedValueChanged += delegate { Format = imageType.SelectedValue as ImageFormat; };

            var imageSave = UIs.CreateFlatButton("Select Image File", new Point(5, 35), new Size(450, 30), AnchorStyles.None);
            imageSave.Click += ImageSave_Click;

            Control[] collection = new Control[]
            {
                imageSelect,imageType,imageSave
            };
            PlaceToPanel(collection, imageSave.Height + imageSave.Top);
        }

        private void ImageSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Image (*.png; *.jpeg; *.gif; *.bmp; *.tiff; *.ico; *.wmf)|*.png; *.jpeg; *.gif; *.bmp; *.tiff; *.ico; *.wmf|All files (*.*)|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                if (Format == ImageFormat.Icon) {
                    SaveAsIco(Bitmap, dlg.FileName);
                }
                else
                {
                    Bitmap.Save(dlg.FileName, Format);
                }
            }
            dlg.Dispose();
            IconConverter converter = new IconConverter();
        }

        private void ImageSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image (*.png; *.jpeg; *.gif; *.bmp; *.tiff; *.ico; *.wmf)|*.png; *.jpeg; *.gif; *.bmp; *.tiff; *.ico; *.wmf|All files (*.*)|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Bitmap = new Bitmap(dlg.FileName);
            }
            dlg.Dispose();
        }


        // Импорт функции для освобождения хэндла иконки
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern bool DestroyIcon(IntPtr handle);

        public void SaveAsIco(Bitmap bitmap, string filePath)
        {
            IntPtr hIcon = bitmap.GetHicon(); // Получаем хэндл иконки
            try
            {
                using (Icon icon = Icon.FromHandle(hIcon))
                {
                    // Сохраняем иконку в файл
                    using (FileStream fs = new FileStream(filePath, FileMode.Create))
                    {
                        icon.Save(fs);
                    }
                }
            }
            finally
            {
                DestroyIcon(hIcon); // Важно: освобождаем хэндл
            }
        }
    }
}
