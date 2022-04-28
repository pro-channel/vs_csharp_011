using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace exe_runner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// notepadボタンクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNotepad_Click(object sender, EventArgs e)
        {
            ProcessStartInfo info = new ProcessStartInfo("notepad", "C:/code/test.txt");
            Process.Start(info);
        }

        /// <summary>
        /// IEボタンクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonIe_Click(object sender, EventArgs e)
        {
            ProcessStartInfo info = new ProcessStartInfo("iexplore", "https://www.youtube.com/c/%E3%83%97%E3%83%AD%E3%81%A1%E3%82%83%E3%82%93");
            Process.Start(info);
        }

        /// <summary>
        /// edgeボタンクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEdge_Click(object sender, EventArgs e)
        {
            ProcessStartInfo info = new ProcessStartInfo("microsoft-edge:https://www.youtube.com/c/%E3%83%97%E3%83%AD%E3%81%A1%E3%82%83%E3%82%93");
            Process.Start(info);
        }

        /// <summary>
        /// popupボタンクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPopup_Click(object sender, EventArgs e)
        {
            ProcessStartInfo info = new ProcessStartInfo("popup_text_window", "プロちゃん表示試験");
            Process.Start(info);

        }
    }
}
