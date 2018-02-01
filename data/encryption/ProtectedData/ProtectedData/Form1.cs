using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProtectedDataTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ProtectButton_Click(object sender, EventArgs e)
        {
            byte[] protectedArray= ProtectedData.Protect(Encoding.UTF8.GetBytes(UnprotectedTextBox.Text),null,DataProtectionScope.CurrentUser);
            //ProtectedTextBox.Text = Encoding.UTF8.GetString(protectedArray);
        
            File.WriteAllBytes(GetFilePath(), protectedArray);
            SetProtectedDataIntoTextBoxes(File.ReadAllBytes(GetFilePath()));
        }

        private void SetProtectedDataIntoTextBoxes(byte[] protectedByteArray)
        {
            ProtectedASCIITextBox.Text = Encoding.ASCII.GetString(protectedByteArray);
            ProtectedASCIITextBox.Text = string.Join(" ", protectedByteArray.Select(x=>char.ConvertFromUtf32(x)));
            ProtectedDataAsUnicodeTextBox.Text = Encoding.Unicode.GetString(protectedByteArray);
            ProtectedTextBox.Text = string.Join(" ", protectedByteArray.Select(x => x.ToString("X2")));
        }

        private void UnProtectButton_Click(object sender, EventArgs e)
        {
            byte[] protectedArray = ProtectedData.Protect(Encoding.UTF8.GetBytes(UnprotectedTextBox.Text), null, DataProtectionScope.CurrentUser);
            ProtectedTextBox.Text = Encoding.UTF8.GetString(protectedArray);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FilePathLabel.Text = GetFilePath();
        }

        private string GetFilePath()
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "protected.txt");
        }
    }
}
