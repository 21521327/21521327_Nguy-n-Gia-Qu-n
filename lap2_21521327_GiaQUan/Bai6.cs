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

namespace lap2_21521327_GiaQUan
{
    public partial class Bai6 : Form
    {
        public Bai6()
        {
            InitializeComponent();
            foreach (DriveInfo path in DriveInfo.GetDrives())
            {
                TreeNode tn = new TreeNode();
                tn.Name = path.Name;
                tn.Text = path.VolumeLabel;
                tv_file.Nodes.Add(tn);
            }
        }

        private void tv_file_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                string path = tv_file.SelectedNode.Name;
                if (ChkFile(path) == false)
                {
                    TreeNode tn = tv_file.SelectedNode;
                    string[] dPath = Directory.GetDirectories(tn.Name);
                    string[] fPath = Directory.GetFiles(tn.Name);
                    foreach (string subdirec in dPath)
                    {
                        bool nodeExisted = false;
                        foreach (TreeNode chktn in tn.Nodes)
                        {
                            if (string.Equals(tn.Name, subdirec) == true)
                                nodeExisted = true;
                        }
                        if (nodeExisted == false)
                        {
                            DirectoryInfo di = new DirectoryInfo(subdirec);
                            TreeNode tn1 = new TreeNode();
                            tn1.Text = di.Name;
                            tn1.Name = subdirec;
                            tn.Nodes.Add(tn1);
                        }
                    }
                    foreach (string files in fPath)
                    {
                        bool nodeExisted = false;
                        foreach (TreeNode chktn in tn.Nodes)
                        {
                            if (string.Equals(tn.Name, files) == true)
                                nodeExisted = true;
                        }
                        if (nodeExisted == false)
                        {
                            DirectoryInfo di = new DirectoryInfo(files);
                            TreeNode tn1 = new TreeNode();
                            tn1.Text = di.Name;
                            tn1.Name = files;
                            tn.Nodes.Add(tn1);
                        }
                    }
                    tn.Expand();
                }
                else
                {
                    if (path.Contains(".txt"))
                    {
                        gb_text_pnj.Controls.Clear();
                        RichTextBox rtb = new RichTextBox();
                        rtb.Dock = DockStyle.Fill;
                        gb_text_pnj.Controls.Add(rtb);
                        FileStream fs = new FileStream(path, FileMode.Open);
                        StreamReader sr = new StreamReader(fs);
                        rtb.Text = sr.ReadToEnd();
                        fs.Close();
                    }
                    else if (path.Contains(".png") || path.Contains(".jpg"))
                    {
                        gb_text_pnj.Controls.Clear();
                        PictureBox pic = new PictureBox();
                        pic.ImageLocation = path;
                        pic.Dock = DockStyle.Fill;
                        pic.SizeMode = PictureBoxSizeMode.StretchImage;
                        gb_text_pnj.Controls.Add(pic);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool ChkFile(string path)
        {
            FileAttributes fa = File.GetAttributes(path);
            if (fa.HasFlag(FileAttributes.Directory) == true)
                return false;
            return true;
        }
    }
}
