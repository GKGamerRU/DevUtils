using FlatUI;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DevUtilsAPI
{
    internal static class UIs
    {
        public static Panel Interface;
        public static FlowLayoutPanel PanelOfButtons;
        private static readonly Font button = new Font("Cascadian Mono", 10, FontStyle.Bold);

        public static void ClearPanel()
        {
            foreach (Control control in Interface.Controls)
            {
                control.Dispose();
            }

            Interface.Controls.Clear(); 
        }

        public static FlatComboBox CreateFlatComboBox(string text, Point location, Size scale, AnchorStyles anchor = AnchorStyles.Left | AnchorStyles.Top, bool autoSize = false, EventHandler onClick = null)
        {
            FlatComboBox control = new FlatComboBox();
            control.Text = text;
            control.Font = button;
            if (!autoSize) control.Size = scale;

            control.Location = location;
            control.Anchor = anchor;
            if (onClick != null) control.Click += onClick;
            return control;
        }

        public static FlatButton CreateFlatButton(string text, Point location, Size scale, AnchorStyles anchor = AnchorStyles.Left | AnchorStyles.Top, bool autoSize = false, EventHandler onClick = null)
        {
            FlatButton control = new FlatButton();
            control.Text = text;
            control.Font = button;
            control.ForeColor = Color.White;
            if (!autoSize) control.Size = scale;

            control.Location = location;
            control.Anchor = anchor;
            if (onClick != null) control.Click += onClick;
            return control;
        }

        public static FlatTextBox CreateFlatTextbox(string text, Point location, Size scale, AnchorStyles anchor = AnchorStyles.Left | AnchorStyles.Top, bool Multiline = false, bool autoSize = false)
        {
            FlatTextBox control = new FlatTextBox();
            control.Multiline = Multiline;
            control.Text = text;
            if (!autoSize) control.Size = scale;

            control.Location = location;
            control.Anchor = anchor;
            return control;
        }
    }
}
