using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace popup_text_window
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            // 引数取得
            string[] cmds = System.Environment.GetCommandLineArgs();

            // 引数チェック
            if (cmds.Length > 1 && !string.IsNullOrEmpty(cmds[1])) {
                // 引数が設定されている場合はタイトルとテキストへ設定する
                this.Text = cmds[1];
                this.label1.Text = cmds[1];
            }

            // 画面起動後にLabelを中央位置に移動
            this.Load += (e, a) => this.label1.Location = new Point(this.Width / 2 - this.label1.Width / 2, this.Height / 2 - this.label1.Height / 2);
        }
    }
}
