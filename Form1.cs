using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace SetLockScreenForAllUser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void setLockScreen(string imgPath)
        {
            RegistryKey key = Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\PersonalizationCSP");

            key.SetValue("LockScreenImagePath", @imgPath, RegistryValueKind.String);
            key.SetValue("LockScreenImageUrl", @imgPath, RegistryValueKind.String);
            key.SetValue("LockScreenImageStatus", 1, RegistryValueKind.DWord);
            key.Close();

            MessageBox.Show("Lockscreen set to "+ @imgPath +". Please restart your computer to see changes.", "Universal Lockscreen Setter");
        }

        private string getImagePath()
        {
            string path = "";

            OpenFileDialog getPath = new OpenFileDialog();
            getPath.Title = "Select your lockscreen:";
            getPath.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";

            if (getPath.ShowDialog() == DialogResult.OK)
            {
                path = getPath.FileName;
            }

            return path;
        }

        private void SelectBtn_Click(object sender, EventArgs e)
        {
            ImageView.ImageLocation = getImagePath();
            SetLockScreenBtn.Visible = true;
        }

        private void SetLockScreenBtn_Click(object sender, EventArgs e)
        {
            setLockScreen(ImageView.ImageLocation);
            ImageView.ImageLocation = "";
            SetLockScreenBtn.Visible = false;
        }
    }
}
