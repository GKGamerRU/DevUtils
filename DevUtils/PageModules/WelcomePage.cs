using System.Windows.Forms;

namespace DevUtilsAPI
{
    class WelcomePage : PageModule
    {
        public override void GeneratePage()
        {
            Label Welcome = new Label();
            UIs.Interface.Controls.Add(Welcome);
            Welcome.AutoSize = true;
            Welcome.Text = "Welcome to DevUtils";
            Welcome.Font = new System.Drawing.Font("Segoe UI", 16);
            Welcome.Location = new System.Drawing.Point(UIs.Interface.Width / 2 - Welcome.Width / 2, UIs.Interface.Height / 2 - Welcome.Height / 2);
            Welcome.Anchor = AnchorStyles.None;
        }
    }
}
