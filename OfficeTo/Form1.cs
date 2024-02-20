using Microsoft.VisualBasic;
using System.IO;

namespace OfficeTo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void zipで保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void バージョン情報ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OfficeTo\nバージョン:0.1.1\n© source21 All rights reserved\n", "バージョン情報", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void 開くOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofDialog = new OpenFileDialog();
            ofDialog.Filter = "MicrosoftOfficeファイル(*.docx;*.pptx;*.xlsx|*.docx;*pptx;*.xlsx";

            // デフォルトのフォルダを指定する
            ofDialog.InitialDirectory = @"C:";

            //ダイアログのタイトルを指定する
            ofDialog.Title = "ダイアログのタイトル";

            //ダイアログを表示する
            if (ofDialog.ShowDialog() == DialogResult.OK)
            {
                string filepath = ofDialog.FileName;
                Console.WriteLine(ofDialog.FileName);
                using (var f = File.Open(filepath, FileMode.OpenOrCreate)) {
                    label1.Text = f.Name;
                }
            }
            else
            {
                Console.WriteLine("キャンセルされました");
            }

            // オブジェクトを破棄する
            ofDialog.Dispose();
        }
    }
}
