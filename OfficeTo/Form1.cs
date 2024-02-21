using System.IO.Compression;

namespace OfficeTo
{
    public partial class Form1 : Form
    {
        static string filepath = @"C:";
        static string fileextension = ".docx";
        public Form1()
        {
            InitializeComponent();
            SaveAllZip.Enabled = false;
        }

        private void zipで保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sa = new SaveFileDialog();
            sa.Title = "Zipで保存";
            sa.InitialDirectory = @"C:\";
            sa.FileName = @"zip.zip";
            sa.Filter = "zip(*.zip)|*.zip";
            sa.FilterIndex = 1;

            //オープンファイルダイアログを表示する
            DialogResult result = sa.ShowDialog();

            if (result == DialogResult.OK)
            {
                //「保存」ボタンが押された時の処理
                string exfileName = sa.FileName;  //こんな感じで指定されたファイルのパスが取得できる
                ZipFile.ExtractToDirectory(filepath, exfileName);
            }
            else if (result == DialogResult.Cancel)
            {
                //「キャンセル」ボタンまたは「×」ボタンが選択された時の処理
                Console.WriteLine("キャンセルされました");
            }

        }

        private void バージョン情報ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OfficeTo\nバージョン:0.1.1\n© 2024 source21 All rights reserved\n", "バージョン情報", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void 開くOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofDialog = new OpenFileDialog();
            ofDialog.Filter = "MicrosoftOfficeファイル(*.docx;*.pptx;*.xlsx|*.docx;*pptx;*.xlsx";

            // デフォルトのフォルダを指定する
            ofDialog.InitialDirectory = @"C:";

            //ダイアログのタイトルを指定する
            ofDialog.Title = "ファイルを開く";

            //ダイアログを表示する
            if (ofDialog.ShowDialog() == DialogResult.OK)
            {
                SaveAllZip.Enabled = true;
                filepath = ofDialog.FileName;
                fileextension = Path.GetExtension(filepath);
                if (fileextension == ".docx")
                {
                    format.Text = "Word(.docx)";
                }
                else if (fileextension == ".pptx")
                {
                    format.Text = "PowerPoint(.pptx)";
                }
                else if (fileextension == ".xlsx")
                {
                    format.Text = "Excel(.xlsx)";
                }
            }
            else
            {
                Console.WriteLine("キャンセルされました");
            }

            // オブジェクトを破棄する
            ofDialog.Dispose();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
