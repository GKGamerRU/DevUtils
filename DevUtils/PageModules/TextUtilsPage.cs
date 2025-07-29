using DevUtilsAPI;
using System.Drawing;
using System.Windows.Forms;

namespace DevUtils.PageModules
{
    internal class TextUtilsPage : PageModule
    {
        public override void GeneratePage()
        {
            var label = new Label();
            label.Text = "Text Utils";
            label.Font = new Font("Cascadian", 18);
            label.Size = new Size(450, 50);
            label.Location = new Point(0, 0);
            label.TextAlign = ContentAlignment.MiddleCenter;

            var Calculate = UIs.CreateFlatButton("Multi-Line to Single-Line", new Point(455 / 2 - 300 / 2, 60), new Size(300, 30), AnchorStyles.None);
            Calculate.Click += delegate { UIs.ClearPanel(); Core.Pages["!Multi-Line to Single-Line"].GeneratePage(); };

            var Calculate2 = UIs.CreateFlatButton("Aes Encrypt & Decrypt", new Point(455 / 2 - 300 / 2, 100), new Size(300, 30), AnchorStyles.None);
            Calculate2.Click += delegate { UIs.ClearPanel(); Core.Pages["!Encrypt & Decrypt"].GeneratePage(); };

            var Calculate3 = UIs.CreateFlatButton("Offset Encryption|Decryption", new Point(455 / 2 - 300 / 2, 140), new Size(300, 30), AnchorStyles.None);
            Calculate3.Click += delegate { UIs.ClearPanel(); Core.Pages["!OffsetCrypto"].GeneratePage(); };

            var Calculate4 = UIs.CreateFlatButton("Split Text", new Point(455 / 2 - 300 / 2, 180), new Size(300, 30), AnchorStyles.None);
            Calculate4.Click += delegate { UIs.ClearPanel(); Core.Pages["!Split Text"].GeneratePage(); };

            Control[] collection = new Control[]
            {
                Calculate, Calculate2, Calculate3, Calculate4, label
            };
            PlaceToPanel(collection);
        }
    }
}
