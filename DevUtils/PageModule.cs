using System.Drawing;
using System.Windows.Forms;

namespace DevUtilsAPI
{
    public abstract class PageModule
    {
        public abstract void GeneratePage();

        protected virtual void PlaceToPanel(Control[] controls, int height = 400)
        {
            Panel parent = new Panel();
            parent.Location = Point.Empty;
            parent.Size = new Size(450, height);

            parent.Controls.AddRange(controls);

            parent.Location = new Point(UIs.Interface.Width / 2 - parent.Width / 2, UIs.Interface.Height / 2 - parent.Height / 2);
            parent.Anchor = AnchorStyles.None;
            UIs.Interface.Controls.Add(parent);
        }
    }
}
