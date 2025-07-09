using System;
using System.Windows.Forms;
using FlatUI;
using System.Drawing;

namespace DevUtilsAPI
{
    class MultiLineToSingle : PageModule
    {
        FlatTextBox origin;
        FlatTextBox Result;
        FlatButton Calculate;

        public override void GeneratePage()
        {
            origin = UIs.CreateFlatTextbox("Enter your text", new Point(5, 5), new Size(450, 170), AnchorStyles.None,true);
            Result = UIs.CreateFlatTextbox("", new Point(5, 10 + 170), new Size(450, 170), AnchorStyles.None,true);

            Calculate = UIs.CreateFlatButton("Convert", new Point(455 / 2 - 200 / 2, 170 + 170 + 10 + 10), new Size(200, 30), AnchorStyles.None);
            Calculate.Click += Calculate_Click;

            Control[] collection = new Control[]
            {
                origin,Result,Calculate
            };
            PlaceToPanel(collection);
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            Result.Text = DevUtilsAPI.str.MultiToSingleLine(origin.Text);
        }
    }
}
