using ReaLTaiizor.Controls;
using SecondFileFinder.Models;
using SecondFileFinder.Services;
using System.IO;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;

namespace SecondFileFinder
{
    public partial class mainPage : Form
    {
       
        private string selectedFolder = "";
        CancellationTokenSource? cts;
        public mainPage()
        {
            InitializeComponent();
        }

        private void dgvResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void btnSccan_Click(object sender, EventArgs e)
        {


            ProgressBar1.Minimum = 0;
            ProgressBar1.Value = 0;
            ProgressBar1.Maximum = Directory.EnumerateFiles(selectedFolder, "*.*", SearchOption.AllDirectories).Count();
            dgvResults.Rows.Clear();

            if (btnSccan.Text == "Cancel") {
                cts?.Cancel();
                return;
            }

            cts = new CancellationTokenSource();
            btnSccan.Text = "Cancel";
            btnSccan.BackColor = Color.Orange;
            btnSccan.ForeColor = Color.Black;

            FileScanner scanner = new FileScanner();
            Progress<int> progress = new Progress<int>(value =>
            {
                ProgressBar1.Value = value;
                lblStatus.Text = $"Scanning : {value} / {ProgressBar1.Maximum}";
            });
            List<DuplicateFile> results = await scanner.Scan(selectedFolder, progress);

            try
            {

                foreach (DuplicateFile item in results)
                {

                    dgvResults.Rows.Add(
                        item.Filename,
                        item.Folder,
                        Math.Round(item.Size / 1024.0 / 1024.0, 2) + "MB", "Same Size");
                }
            }
            catch (ObjectDisposedException) {
            
            }
            finally {
                btnSccan.Text = "FindFile";
                btnSccan.BackColor = Color.Black;
                btnSccan.ForeColor = Color.Orange;

                cts.Dispose();
                cts = null;

            }


            }
            
        

        private void btnSelect_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                selectedFolder = dialog.SelectedPath;
                lblStatus.Text = selectedFolder;
            }
        }

        private void mainPage_Load(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


    }
}
