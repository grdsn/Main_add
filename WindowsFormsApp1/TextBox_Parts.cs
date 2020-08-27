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
    public partial class TextBox_Parts : Form
    {
        public TextBox_Parts()
        {
            InitializeComponent();
        }
        private void TextBox_Parts_Load(object sender, EventArgs e)
        {

        }
        public string ShowMiniForm()
        {
            TextBox_Parts f = new TextBox_Parts();
            f.ShowDialog();
            string receiveText = "<input type=\"text\" name=\"\" value=\"" + value.Text + "\">";　//HTML文
            f.Dispose();
            return receiveText; //HTML文を返す

        }
    }
}
