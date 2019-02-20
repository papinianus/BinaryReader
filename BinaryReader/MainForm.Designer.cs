namespace BinaryReader
{
    partial class MainForm
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
            this.DataBox = new System.Windows.Forms.TextBox();
            this.SelectFile = new System.Windows.Forms.Button();
            this.SelectedFile = new System.Windows.Forms.TextBox();
            this.FileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // DataBox
            // 
            this.DataBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataBox.Location = new System.Drawing.Point(3, 32);
            this.DataBox.Multiline = true;
            this.DataBox.Name = "DataBox";
            this.DataBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataBox.Size = new System.Drawing.Size(589, 512);
            this.DataBox.TabIndex = 0;
            // 
            // SelectFile
            // 
            this.SelectFile.Location = new System.Drawing.Point(3, 3);
            this.SelectFile.Name = "SelectFile";
            this.SelectFile.Size = new System.Drawing.Size(75, 25);
            this.SelectFile.TabIndex = 1;
            this.SelectFile.Text = "ファイル選択";
            this.SelectFile.UseVisualStyleBackColor = true;
            this.SelectFile.Click += new System.EventHandler(this.SelectFileButtonClick);
            // 
            // SelectedFile
            // 
            this.SelectedFile.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedFile.Location = new System.Drawing.Point(84, 5);
            this.SelectedFile.Name = "SelectedFile";
            this.SelectedFile.Size = new System.Drawing.Size(508, 23);
            this.SelectedFile.TabIndex = 2;
            // 
            // FileDialog
            // 
            this.FileDialog.FileName = "openFileDialog1";
            this.FileDialog.Filter = "テキストファイル|*.txt";
            this.FileDialog.Title = "読み込むファイルを選択してください";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 546);
            this.Controls.Add(this.SelectedFile);
            this.Controls.Add(this.SelectFile);
            this.Controls.Add(this.DataBox);
            this.Name = "MainForm";
            this.Text = "BinaryReader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DataBox;
        private System.Windows.Forms.Button SelectFile;
        private System.Windows.Forms.TextBox SelectedFile;
        private System.Windows.Forms.OpenFileDialog FileDialog;
    }
}

