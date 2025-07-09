using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevUtils.PageModules;
using DevUtils.PageModules.VisualModules;

namespace DevUtilsAPI
{
    class Core
    {
        public static Dictionary<string, PageModule> Pages = new Dictionary<string, PageModule>()
        {
            {"#Visual Functions" , null},
            {"Image Convertor" , new ImageConvertor()},

            {"#Other Functions" , null},
            {"Text Utils" , new TextUtilsPage()},

            {"!Multi-Line to Single-Line" , new MultiLineToSingle()},
            {"!Encrypt & Decrypt" , new Encryptor_Decryptor()},
            {"!Split Text" , new SplitTextModule()},
        };

        public static void Start()
        {
            UIs.ClearPanel(); new WelcomePage().GeneratePage();

            foreach (var Page in Pages)
            {
                if (Page.Key[0] == '!') continue;
                if (Page.Key[0] == '#')
                {
                    var OpLabel = new Label();
                    OpLabel.Text = Page.Key.Remove(0,1);
                    OpLabel.Size = new System.Drawing.Size(195, 30);
                    OpLabel.Font = new System.Drawing.Font("Segoe UI", 12);
                    OpLabel.ForeColor = System.Drawing.Color.DarkGray;
                    UIs.PanelOfButtons.Controls.Add(OpLabel);
                    continue;
                }

                FlatUI.FlatButton OpButton = new FlatUI.FlatButton();
                OpButton.Size = new System.Drawing.Size(195, 30);
                OpButton.Text = Page.Key;
                OpButton.Font = new System.Drawing.Font("Segoe UI", 12);
                OpButton.ForeColor = System.Drawing.Color.DimGray;

                OpButton.Click += new EventHandler(delegate { UIs.ClearPanel(); Page.Value.GeneratePage(); });
                UIs.PanelOfButtons.Controls.Add(OpButton);
            }
        }
    }
}