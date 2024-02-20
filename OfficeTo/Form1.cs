using System.IO.Compression;

namespace OfficeTo
{
    public partial class Form1 : Form
    {
        static string filepath = @"C:";
        public Form1()
        {
            InitializeComponent();
        }

        private void zipで保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sa = new SaveFileDialog();
            sa.Title = "ファイルを保存する";
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
            ofDialog.Title = "ダイアログのタイトル";

            //ダイアログを表示する
            if (ofDialog.ShowDialog() == DialogResult.OK)
            {
                filepath = ofDialog.FileName;
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
