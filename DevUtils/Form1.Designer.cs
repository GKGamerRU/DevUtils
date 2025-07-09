namespace DevUtils
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.flatLabel1 = new FlatUI.FlatLabel();
            this.OptionsTools = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.flatLabel1);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(686, 44);
            this.panel1.TabIndex = 0;
            // 
            // flatLabel1
            // 
            this.flatLabel1.AutoSize = true;
            this.flatLabel1.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatLabel1.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.flatLabel1.ForeColor = System.Drawing.Color.DimGray;
            this.flatLabel1.Location = new System.Drawing.Point(3, 9);
            this.flatLabel1.Name = "flatLabel1";
            this.flatLabel1.Size = new System.Drawing.Size(92, 30);
            this.flatLabel1.TabIndex = 0;
            this.flatLabel1.Text = "DevUtils";
            this.flatLabel1.Click += new System.EventHandler(this.flatLabel1_Click);
            // 
            // OptionsTools
            // 
            this.OptionsTools.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.OptionsTools.AutoScroll = true;
            this.OptionsTools.BackColor = System.Drawing.Color.WhiteSmoke;
            this.OptionsTools.Location = new System.Drawing.Point(-1, 49);
            this.OptionsTools.Name = "OptionsTools";
            this.OptionsTools.Padding = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.OptionsTools.Size = new System.Drawing.Size(234, 398);
            this.OptionsTools.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Location = new System.Drawing.Point(239, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(440, 398);
            this.panel2.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 451);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.OptionsTools);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(700, 490);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DevUtils";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel OptionsTools;
        private System.Windows.Forms.Panel panel2;
        private FlatUI.FlatLabel flatLabel1;
    }
}

