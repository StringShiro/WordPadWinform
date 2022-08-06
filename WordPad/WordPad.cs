using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordPad
{
    public partial class WordPad : Form
    {
        public WordPad()
        {
            InitializeComponent();
        }

        private void WordPad_Load(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        //in đậm font
        void BoldText(RichTextBox Richtxtbox)
        {
            //truyền data của richtextbox vào newFont và bôi đậm
            Font newFont = new Font(Richtxtbox.SelectionFont.FontFamily.Name, Richtxtbox.SelectionFont.Size, FontStyle.Bold);
            Richtxtbox.SelectionFont = newFont;
        }

        private void toolStrip_Bold_Click(object sender, EventArgs e)
        {
            BoldText(Richtxtbox);
        }

        //in nghiêng font
        void ItalicText(RichTextBox Richtxtbox)
        {
            //truyền data của richtextbox vào newFont và in nghiêng
            Font newFont = new Font(Richtxtbox.SelectionFont.FontFamily.Name, Richtxtbox.SelectionFont.Size, FontStyle.Italic);
            Richtxtbox.SelectionFont = newFont;
        }

        private void toolStrip_Italic_Click(object sender, EventArgs e)
        {
            ItalicText(Richtxtbox);
        }


        //tạo gạch chân cho font
        void UnderlineText(RichTextBox Richtxtbox)
        {
            //truyền data của richtextbox vào newFont và gạch chân
            Font newFont = new Font(Richtxtbox.SelectionFont.FontFamily.Name, Richtxtbox.SelectionFont.Size, FontStyle.Underline);
            Richtxtbox.SelectionFont = newFont;
        }

        private void toolStrip_Underline_Click(object sender, EventArgs e)
        {
            UnderlineText(Richtxtbox);
        }

        //Thay đổi kích thước font
        void ChangedSize(RichTextBox Richtxtbox, int size) {
            Font newFont = new Font(Richtxtbox.SelectionFont.FontFamily.Name, size, Richtxtbox.SelectionFont.Style);
            Richtxtbox.SelectionFont = newFont;
        }

        private void Numeric_ChangeFontSize_ValueChanged(object sender, EventArgs e)
        {
            ChangedSize(Richtxtbox, (int) Numeric_ChangeFontSize.Value);
        }

        //set event cùng tới toolstrip right, left, center alignment
        private void TSMenuItem_Bold_Click(object sender, EventArgs e)
        {
            BoldText(Richtxtbox);
        }

        private void TSMenuItem_Italic_Click(object sender, EventArgs e)
        {
            ItalicText(Richtxtbox);
        }

        private void TSMenuItem_Underline_Click(object sender, EventArgs e)
        {
            UnderlineText(Richtxtbox);
        }

        //tạo bảng hiện Font
        private void toolStripDropDown_SelectFont_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            if(fd.ShowDialog() == DialogResult.OK) {
                Richtxtbox.Font = fd.Font;
            }
        }
        private void TSMenuItem_Font_Click(object sender, EventArgs e)
        {
            toolStripDropDown_SelectFont_Click(sender, e);
        }

        //tạo bảng hiện màu
        private void toolStrip_Color_Click(object sender, EventArgs e)
        {
            ColorDialog col = new ColorDialog();
            col.ShowDialog();
            Richtxtbox.SelectionColor = col.Color;
        }

        private void TSMenuItem_Color_Click(object sender, EventArgs e)
        {
            toolStrip_Color_Click(sender, e);
        }

        private void imageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //PictureBox pb1 = new PictureBox();
            //OpenFileDialog of = new OpenFileDialog();
            //of.Title = "Open my new file";
            //of.Filter = "Text File (*.png) |*v.gif | All Files (*.*) | *.*";
            //if (of.ShowDialog() == DialogResult.OK)
            //{
            //    Richtxtbox.LoadFile(of.FileName, RichTextBoxStreamType.I);
            //}
            //this.Text = of.FileName;
            //pb1.ImageLocation = "../desktop.png";
            //pb1.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void TSMenuItem_Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Title = "Open my new file";
            of.Filter = "Text File (*.txt) |*v.txt | All Files (*.*) | *.*";
            if(of.ShowDialog() == DialogResult.OK)
            {
                Richtxtbox.LoadFile(of.FileName, RichTextBoxStreamType.PlainText);
            }
            this.Text = of.FileName;
        }

        private void TSMenuItem_Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog of = new SaveFileDialog();
            of.Title = "Save";
            of.Filter = "Text File (*.txt) |*v.txt | All Files (*.*) | *.*";
            if (of.ShowDialog() == DialogResult.OK)
            {
                Richtxtbox.SaveFile(of.FileName, RichTextBoxStreamType.PlainText);
            }
            this.Text = of.FileName;
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Richtxtbox.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Richtxtbox.Paste();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Richtxtbox.Cut();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Richtxtbox.Undo();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Richtxtbox.SelectAll();
        }

        private void Richtxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TSMenuItem_FindAndReplace_Click(object sender, EventArgs e)
        {

        }

        private void TSMenuItem_Find_Click(object sender, EventArgs e)
        {
            int index = 0;
            var temp = Richtxtbox.Text;
            Richtxtbox.Text = "";
            Richtxtbox.Text = temp;

            while (index < Richtxtbox.Text.LastIndexOf(txt_Find.Text))
            {
                Richtxtbox.Find(txt_Find.Text, index, Richtxtbox.TextLength, RichTextBoxFinds.None);
                Richtxtbox.SelectionBackColor = Color.Yellow;

                index = Richtxtbox.Text.IndexOf(txt_Find.Text, index) + 1;
            }
        }

        private void txt_Find_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Find_Click(object sender, EventArgs e)
        {
            TSMenuItem_Find_Click(sender, e);
        }
        public static void QuickReplace(RichTextBox rtb, String word, String word2)
        {
            rtb.Text = rtb.Text.Replace(word, word2);
        }
        private void TSMenuItem_Replace_Click(object sender, EventArgs e)
        {
            QuickReplace( Richtxtbox,Richtxtbox.Text, txt_Find.Text);
        }
    }
}
