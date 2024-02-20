namespace OfficeTo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            ファイルToolStripMenuItem = new ToolStripMenuItem();
            開くOToolStripMenuItem = new ToolStripMenuItem();
            zipで保存ToolStripMenuItem = new ToolStripMenuItem();
            zipで保存ToolStripMenuItem1 = new ToolStripMenuItem();
            画像ToolStripMenuItem = new ToolStripMenuItem();
            動画ToolStripMenuItem = new ToolStripMenuItem();
            テキストToolStripMenuItem = new ToolStripMenuItem();
            その他ToolStripMenuItem = new ToolStripMenuItem();
            ヘルプToolStripMenuItem = new ToolStripMenuItem();
            バージョン情報ToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ファイルToolStripMenuItem, ヘルプToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // ファイルToolStripMenuItem
            // 
            ファイルToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 開くOToolStripMenuItem, zipで保存ToolStripMenuItem, zipで保存ToolStripMenuItem1 });
            ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem";
            ファイルToolStripMenuItem.Size = new Size(79, 29);
            ファイルToolStripMenuItem.Text = "ファイル";
            // 
            // 開くOToolStripMenuItem
            // 
            開くOToolStripMenuItem.Name = "開くOToolStripMenuItem";
            開くOToolStripMenuItem.Size = new Size(270, 34);
            開くOToolStripMenuItem.Text = "開く(O)";
            開くOToolStripMenuItem.Click += 開くOToolStripMenuItem_Click;
            // 
            // zipで保存ToolStripMenuItem
            // 
            zipで保存ToolStripMenuItem.Name = "zipで保存ToolStripMenuItem";
            zipで保存ToolStripMenuItem.Size = new Size(270, 34);
            zipで保存ToolStripMenuItem.Text = "Zipで全て保存";
            zipで保存ToolStripMenuItem.Click += zipで保存ToolStripMenuItem_Click;
            // 
            // zipで保存ToolStripMenuItem1
            // 
            zipで保存ToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { 画像ToolStripMenuItem, 動画ToolStripMenuItem, テキストToolStripMenuItem, その他ToolStripMenuItem });
            zipで保存ToolStripMenuItem1.Name = "zipで保存ToolStripMenuItem1";
            zipで保存ToolStripMenuItem1.Size = new Size(270, 34);
            zipで保存ToolStripMenuItem1.Text = "Zipで保存";
            // 
            // 画像ToolStripMenuItem
            // 
            画像ToolStripMenuItem.Name = "画像ToolStripMenuItem";
            画像ToolStripMenuItem.Size = new Size(168, 34);
            画像ToolStripMenuItem.Text = "画像";
            // 
            // 動画ToolStripMenuItem
            // 
            動画ToolStripMenuItem.Name = "動画ToolStripMenuItem";
            動画ToolStripMenuItem.Size = new Size(168, 34);
            動画ToolStripMenuItem.Text = "動画";
            // 
            // テキストToolStripMenuItem
            // 
            テキストToolStripMenuItem.Name = "テキストToolStripMenuItem";
            テキストToolStripMenuItem.Size = new Size(168, 34);
            テキストToolStripMenuItem.Text = "テキスト";
            // 
            // その他ToolStripMenuItem
            // 
            その他ToolStripMenuItem.Name = "その他ToolStripMenuItem";
            その他ToolStripMenuItem.Size = new Size(168, 34);
            その他ToolStripMenuItem.Text = "その他";
            // 
            // ヘルプToolStripMenuItem
            // 
            ヘルプToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { バージョン情報ToolStripMenuItem });
            ヘルプToolStripMenuItem.Name = "ヘルプToolStripMenuItem";
            ヘルプToolStripMenuItem.Size = new Size(72, 29);
            ヘルプToolStripMenuItem.Text = "ヘルプ";
            // 
            // バージョン情報ToolStripMenuItem
            // 
            バージョン情報ToolStripMenuItem.Name = "バージョン情報ToolStripMenuItem";
            バージョン情報ToolStripMenuItem.Size = new Size(216, 34);
            バージョン情報ToolStripMenuItem.Text = "バージョン情報";
            バージョン情報ToolStripMenuItem.Click += バージョン情報ToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 48);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "OfficeTo";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem ファイルToolStripMenuItem;
        private ToolStripMenuItem 開くOToolStripMenuItem;
        private ToolStripMenuItem zipで保存ToolStripMenuItem;
        private ToolStripMenuItem zipで保存ToolStripMenuItem1;
        private ToolStripMenuItem 画像ToolStripMenuItem;
        private ToolStripMenuItem 動画ToolStripMenuItem;
        private ToolStripMenuItem テキストToolStripMenuItem;
        private ToolStripMenuItem その他ToolStripMenuItem;
        private ToolStripMenuItem ヘルプToolStripMenuItem;
        private ToolStripMenuItem バージョン情報ToolStripMenuItem;
        private Label label1;
    }
}
