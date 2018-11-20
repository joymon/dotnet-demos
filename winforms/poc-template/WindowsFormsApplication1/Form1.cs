using DotNet.Helpers.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DownloadInParallel(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            DownloadInParallel(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DownloadInParallel(Convert.ToInt32(NumberOfDownloadsNumericUpDown.Value));
        }

        private void DownloadInParallel(int numberOfThreads)
        {
            Parallel.For(0, numberOfThreads, (index) =>
            {
                Task.Run(() =>
                {
                    DownloadBlob(index, SATextBox.Text, BlobContainerTextBox.Text);
                });
            });
        }

        private static void DownloadBlob(int destinationFolder, string storageAccountName, string blobContainerToDownloadFrom)
        {

            MessageBox.Show("Download completed");
        }
        #region UPload

        private void DeleteLogFileFrom(string filePath)
        {

            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }


        private void BrowseFolderButton_Click(object sender, EventArgs e)
        {
            SourceFolderBrowserDialog.ShowDialog();
            SourceFolderTextBox.Text = SourceFolderBrowserDialog.SelectedPath;
        }
        private void GenerateAzCopyButton_Click(object sender, EventArgs e)
        {
        }
        private async void UploadUsingAzCopyButton_Click(object sender, EventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Exception - {ex}");
            }
            finally
            {
                UploadUsingAzCopyButton.Enabled = true;
            }
        }
        private async void UploadUsingAzCopySDKbutton_Click(object sender, EventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Exception - {ex}");
            }
            finally
            {
                UploadUsingAzCopySDKbutton.Enabled = true;
            }
        }
        private void InitializeFileWatcher(string logPath)
        {
            LogFileSystemWatcher.Path = SourceFolderTextBox.Text;
            LogFileSystemWatcher.NotifyFilter = NotifyFilters.LastAccess |
                         NotifyFilters.LastWrite |
                         NotifyFilters.FileName |
                         NotifyFilters.DirectoryName | NotifyFilters.Size;
        }
        #endregion

        private void LogFileSystemWatcher_Changed(object sender, FileSystemEventArgs e)
        {
            LogsTextBox.Text = File.ReadAllText(e.FullPath);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TextBoxTraceListener _textBoxListener = new TextBoxTraceListener(LogsTextBox);
            Trace.Listeners.Add(_textBoxListener);
            ParallelOperationsnumericUpDown.Value = 8 * Environment.ProcessorCount;
            BlockSizelabel.Text = BlockSizetrackBar.Value.ToString();
            Trace.WriteLine("Application started");
        }

        private async void UploadFilesUsingAzCopySDKbutton_Click(object sender, EventArgs e)
        {
            try
            {
                UploadFilesUsingAzCopySDKbutton.Enabled = false;
                Stopwatch sw = new Stopwatch();
                sw.Start();
                //Task.WaitAll(tasks);
                sw.Stop();
                MessageBox.Show($"Uploaded files using AzCopy SDK - Time taken - {sw.Elapsed}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Exception - {ex}");
            }
            finally
            {
                UploadFilesUsingAzCopySDKbutton.Enabled = true;
            }
        }

        private void BlockSizetrackBar_Scroll(object sender, EventArgs e)
        {
            BlockSizelabel.Text = BlockSizetrackBar.Value.ToString() ;
        }
    }
}