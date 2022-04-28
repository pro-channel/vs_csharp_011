
namespace exe_runner
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonNotepad = new System.Windows.Forms.Button();
            this.buttonIe = new System.Windows.Forms.Button();
            this.buttonEdge = new System.Windows.Forms.Button();
            this.buttonPopup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonNotepad
            // 
            this.buttonNotepad.Location = new System.Drawing.Point(79, 91);
            this.buttonNotepad.Name = "buttonNotepad";
            this.buttonNotepad.Size = new System.Drawing.Size(75, 23);
            this.buttonNotepad.TabIndex = 0;
            this.buttonNotepad.Text = "Notepad";
            this.buttonNotepad.UseVisualStyleBackColor = true;
            this.buttonNotepad.Click += new System.EventHandler(this.buttonNotepad_Click);
            // 
            // buttonIe
            // 
            this.buttonIe.Location = new System.Drawing.Point(184, 91);
            this.buttonIe.Name = "buttonIe";
            this.buttonIe.Size = new System.Drawing.Size(75, 23);
            this.buttonIe.TabIndex = 1;
            this.buttonIe.Text = "IE";
            this.buttonIe.UseVisualStyleBackColor = true;
            this.buttonIe.Click += new System.EventHandler(this.buttonIe_Click);
            // 
            // buttonEdge
            // 
            this.buttonEdge.Location = new System.Drawing.Point(289, 91);
            this.buttonEdge.Name = "buttonEdge";
            this.buttonEdge.Size = new System.Drawing.Size(75, 23);
            this.buttonEdge.TabIndex = 2;
            this.buttonEdge.Text = "edge";
            this.buttonEdge.UseVisualStyleBackColor = true;
            this.buttonEdge.Click += new System.EventHandler(this.buttonEdge_Click);
            // 
            // buttonPopup
            // 
            this.buttonPopup.Location = new System.Drawing.Point(394, 91);
            this.buttonPopup.Name = "buttonPopup";
            this.buttonPopup.Size = new System.Drawing.Size(75, 23);
            this.buttonPopup.TabIndex = 3;
            this.buttonPopup.Text = "popup";
            this.buttonPopup.UseVisualStyleBackColor = true;
            this.buttonPopup.Click += new System.EventHandler(this.buttonPopup_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 223);
            this.Controls.Add(this.buttonPopup);
            this.Controls.Add(this.buttonEdge);
            this.Controls.Add(this.buttonIe);
            this.Controls.Add(this.buttonNotepad);
            this.Name = "Form1";
            this.Text = "exe_runner";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonNotepad;
        private System.Windows.Forms.Button buttonIe;
        private System.Windows.Forms.Button buttonEdge;
        private System.Windows.Forms.Button buttonPopup;
    }
}

