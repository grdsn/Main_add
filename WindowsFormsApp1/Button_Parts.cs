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
    public partial class Button_Parts : Form
    {
        //OpenFileDialogクラスのインスタンスを作成
        OpenFileDialog ofd = new OpenFileDialog();
        string html_name = "";

        public Button_Parts()
        {
            InitializeComponent();
        }

        private void hmlBtn_Click(object sender, EventArgs e)
        {
            ofd.Filter = "All Files|*.html";
            ofd.FilterIndex = 2;
            ofd.Title = "開くファイルを選択してください";
            ofd.RestoreDirectory = true;
            ofd.CheckFileExists = true;
            ofd.CheckPathExists = true;

            //ダイアログを表示する
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //OKボタンがクリックされたとき、選択されたファイル名を表示する
                html_name = ofd.FileName;
            }
            onclick.Text = html_name;
        }
        public string ShowMiniForm()
        {
            Button_Parts f = new Button_Parts();
            f.ShowDialog();
            //; return false;   location.href='
            string receiveText = "<button type=\"button\" onclick=\"" + f.onclick.Text + "'\">" + f.btnName.Text + "</button>";　//HTML文
            f.Dispose();
            return receiveText; //HTML文を返す
        }

        private void AddConfirm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void JSBtn_Click(object sender, EventArgs e)
        {
            onclick.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            onclick.Enabled = true;
        }
    }
}
