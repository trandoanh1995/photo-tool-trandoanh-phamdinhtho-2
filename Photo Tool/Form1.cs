using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Photo_Tool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Open File";
            dlg.Filter= " jpg files{ *.jpg| *.jpg|All file (*.*)|*.*}";

            if (dlg.ShowDialog() == DialogResult.OK) //kiểu liệt kê
                try
                {
                    pbxphoto.Image = new Bitmap(dlg.OpenFile());
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show("Unable to load files:" + ex.Message);
                    pbxphoto.Image = null;
                }
            dlg.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pbxphoto.Top = (this.Height - pbxphoto.Height) / 2;
            pbxphoto.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void menuImage_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ProcessImageClick(e);
        }
        private void ProcessImageClick(ToolStripItemClickedEventArgs e)
        {
            ToolStripItem item = e.ClickedItem;
            string enumVal = item.Tag as string;
            if (enumVal != null)
            {
                pbxphoto.SizeMode = (PictureBoxSizeMode)
                Enum.Parse(typeof(PictureBoxSizeMode),enumVal);
            }
        }

        private void menuImage_DropDownOpening(object sender, EventArgs e)
        {
            ProcessImageOpening(sender as ToolStripDropDownItem);
        }
        private void ProcessImageOpening(ToolStripDropDownItem parent)
        {
            if (parent != null)
            {
                string enumVal = pbxphoto.SizeMode.ToString();
                foreach (ToolStripMenuItem item in parent.DropDownItems)
                {
                    item.Enabled = (pbxphoto.Image != null);
                    item.Checked = item.Tag.Equals(enumVal);
                }
            }
        }

        private void pbxphoto_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ctxMenuPhoto_Opening(object sender, CancelEventArgs e)
        {

        }

        private void menuImageScale_Click(object sender, EventArgs e)
        {

        }
    }
}
