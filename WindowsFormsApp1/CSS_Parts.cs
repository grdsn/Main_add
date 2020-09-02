using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CSS_Parts : Form
    {
        string css_name = "";
        //OpenFileDialogクラスのインスタンスを作成
        OpenFileDialog ofd = new OpenFileDialog();
        // htmlを生成するかどうか
        //Boolean returnFrg = false;

        public static string text_return;
        public CSS_Parts()
        {
            InitializeComponent();
        }
        private void CSS_Parts_Load(object sender, EventArgs e)
        {

        }

        private void choiseCSS_Click(object sender, EventArgs e)
        {
            //ファイルの選択
            ofd.Filter = "すべてのファイル(*.*)|*.css";
            ofd.FilterIndex = 2;
            ofd.Title = "開くファイルを選択してください";
            ofd.RestoreDirectory = true;
            ofd.CheckFileExists = true;
            ofd.CheckPathExists = true;

            //ダイアログを表示する
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //OKボタンがクリックされたとき、選択されたファイル名を表示する
                css_name = ofd.FileName;
            }
            cssFile.Text = css_name;

        }

        public string ShowMiniForm()
        {
            CSS_Parts f = new CSS_Parts();
            f.ShowDialog();
            /*
            if (returnFrg) {
                string result = re_html();
                f.Dispose();
                return result;
            }
            else
            {
            */
            f.Dispose();
            string receiveText = "<link rel=\"styesheet\" href=\"" + f.cssFile.Text + "\">";
            return receiveText;
            //return "";
            //}
        }

        private string re_html()
        {
            string receiveText = "<link rel=\"styesheet\" href=\"" + cssFile.Text + "\">";
            return receiveText;
        }

        private void AddConfirm_Click(object sender, EventArgs e)
        {
            //returnFrg = true;
            Close();　//画面を閉じ反映させる
        }

    }
}
