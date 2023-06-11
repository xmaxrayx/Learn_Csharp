using System.Diagnostics;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        List<string> listFiles = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView.FocusedItem!=null)
            {
                // Process.Start(listFiles[listView.FocusedItem.Index]); //dosn't work with core net

                new Process { StartInfo = new ProcessStartInfo(listFiles[listView.FocusedItem.Index]) { UseShellExecute = true } }.Start();

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            listFiles.Clear();
            listView.Items.Clear();
            using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description =" sellect your path"})

            {
                if(fbd.ShowDialog() == DialogResult.OK)
                {
                    txtPath.Text = fbd.SelectedPath;
                    foreach (string items in Directory.GetFiles(fbd.SelectedPath))
                    {
                        imageList.Images.Add(System.Drawing.Icon.ExtractAssociatedIcon(items));
                        FileInfo fi= new FileInfo(items); 
                        listFiles.Add(fi.FullName);
                        listView.Items.Add(fi.Name,imageList.Images.Count-1);


                    }
                }

            }
        }

        private void txtPath_TextChanged(object sender, EventArgs e)
        {

        }
    }
}