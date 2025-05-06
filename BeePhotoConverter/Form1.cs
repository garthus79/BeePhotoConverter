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
using ImageMagick;
using ImageMagick.Drawing; // Optional, for some drawing ops
//using Magick.NET.SystemDrawing; // Needed for ToBitmap()


namespace BeePhotoConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void btnChooseSource_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "HEIF/HEIC Images|*.heif;*.heic|All Files|*.*";
            openFileDialog.Title = "Select a HEIF Image";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                lstSource.Items.Clear(); // Clear previous selections
                lstSource.Enabled = true; // Enable the list box
                foreach (string file in openFileDialog.FileNames)
                {
                    // Add the selected file to the list
                    lstSource.Items.Add(file);
                }
            }
        }

        private void lstSource_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lstSource.SelectedItem == null) return;

            string filePath = lstSource.SelectedItem.ToString();

            try
            {
                using (var image = new MagickImage(filePath))
                {
                    Bitmap bmp = image.ToBitmap(); // Now works with x64 or x86 version
                    pctPreview.Image?.Dispose();
                    pctPreview.Image = new Bitmap(bmp);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load image:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            //Clear any previous results
            lstResults.Items.Clear();

            //Initialize the progress bar
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.Visible = true;
            progressBar1.MarqueeAnimationSpeed = 30; // Set the speed of the marquee animation
            Application.DoEvents(); //Update the UI immediately

            // Check if any files are selected
            foreach (var item in lstSource.Items)
            {
                string heifPath = item.ToString();
                string jpegPath = Path.ChangeExtension(heifPath, ".jpg");

                // Check if alternate path is selected
                if (!string.IsNullOrEmpty(txtAlternatePath.Text))
                {
                    string alternatePath = Path.Combine(txtAlternatePath.Text, Path.GetFileName(jpegPath));
                    jpegPath = alternatePath;

                    //Save the alternate path to a file for future use
                    string projectPath = Path.GetDirectoryName(Application.ExecutablePath);
                    string filePath = Path.Combine(projectPath, "LastUsedPath.txt");
                    string content = txtAlternatePath.Text;
                    File.WriteAllText(filePath, content);
                }

                try
                {
                    using (var image = new MagickImage(heifPath))
                    {
                        // Collect all non-empty profiles  
                        var profiles = image.ProfileNames
                                            .Select(name => image.GetProfile(name))
                                            .Where(profile => profile != null && profile.ToByteArray().Length > 0)
                                            .ToList();

                        image.Format = MagickFormat.Jpeg;

                        // Reattach profiles to preserve metadata  
                        foreach (var profile in profiles)
                        {
                            image.SetProfile(profile);
                        }

                        image.Write(jpegPath);
                    }

                    lstResults.Items.Add($"✓ Converted: {Path.GetFileName(jpegPath)}");
                    Application.DoEvents();
                }
                catch (Exception ex)
                {
                    lstResults.Items.Add($"✗ Failed: {Path.GetFileName(heifPath)} ({ex.Message})");
                    Application.DoEvents();
                }
            }

            // Reset the progress bar
            progressBar1.MarqueeAnimationSpeed = 0; // Stop the marquee animation
            progressBar1.Visible = false;

        }

        private void chkAlternatePath_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAlternatePath.Checked)
            {
                //txtAlternatePath.Enabled = true;
                btnAlternatePath.Enabled = true;
                string projectPath = Path.GetDirectoryName(Application.ExecutablePath);
                string filePath = Path.Combine(projectPath, "LastUsedPath.txt");
                if (File.Exists(filePath))
                {
                    string content = File.ReadAllText(filePath);
                    txtAlternatePath.Text = content;
                }
                else
                {
                    txtAlternatePath.Text = "";
                }
            }
            else
            {
                //txtAlternatePath.Enabled = false;
                btnAlternatePath.Enabled = false;
            }
        }

        private void btnAlternatePath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "Select the destination folder for converted images";
            folderBrowserDialog.ShowNewFolderButton = true;
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtAlternatePath.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstResults.Items.Clear(); 
            lstSource.Items.Clear();
            if (pctPreview.Image != null)
            {
                pctPreview.Image.Dispose();

            }
            pctPreview.Image = null; // Clear the preview image
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (AboutForm aboutDialog = new AboutForm())
            {
                aboutDialog.ShowDialog();
            }
        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "Select the folder containing HEIF images";
            folderBrowserDialog.ShowNewFolderButton = false;
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                lstSource.Items.Clear(); // Clear previous selections
                lstSource.Enabled = true; // Enable the list box
                string[] files = Directory.GetFiles(folderBrowserDialog.SelectedPath, "*.heif");
                foreach (string file in files)
                {
                    // Add the selected file to the list
                    lstSource.Items.Add(file);
                }
            }
        }

    }
}
