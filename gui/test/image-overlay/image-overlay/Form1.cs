namespace image_overlay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "All Files (*.*)|*.*";
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = true;

            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                string sFileName = choofdlog.FileName;
                string[] arrAllFiles = choofdlog.FileNames; //used when Multiselect = true           
            }
            */
            OpenFileDialog openFileDialogImage = new OpenFileDialog();

            //openFileDialogImage.InitialDirectory = "c:\\";
            openFileDialogImage.Filter = "png files (*.png)|*.png|All files (*.*)|*.*";
            openFileDialogImage.FilterIndex = 2;
            openFileDialogImage.RestoreDirectory = true;

            if (openFileDialogImage.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string fileImagePath = openFileDialogImage.FileName;
                labelImagePath.Text = fileImagePath;
                //

                System.Drawing.Image img = System.Drawing.Image.FromFile(fileImagePath);
                //MessageBox.Show("Width: " + img.Width + ", Height: " + img.Height);



                //Console.WriteLine(fileName);

                //to open the file
                /*
                try
                {
                    Stream myStream = null;
                    if ((myStream = openFileDialogImage.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            // Insert code to read the stream here.
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
                 * */
            }




        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}