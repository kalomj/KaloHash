using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

using System.Security.Cryptography;

namespace KaloHash
{
    public partial class KaloHashForm : Form
    {
        System.Windows.Forms.Timer updateTimer = new System.Windows.Forms.Timer();
        string status = String.Empty;

        public KaloHashForm()
        {
            InitializeComponent();
        }

        private void _Shown(object sender, EventArgs e)
        {
            DriveInfo[] di = DriveInfo.GetDrives();
            driveComboBox.Items.AddRange(di.Select(d => d.Name).ToArray());

            updateTimer.Tick += UpdateTimer_Tick;
            updateTimer.Interval = 33;
            updateTimer.Start();
        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            statusLabel.Text = status;
        }

        private void hashDiskButton_Click(object sender, EventArgs e)
        {
            hashDiskButton.Enabled = false;

            hashTextBox.Text = String.Empty;

            string drive = driveComboBox.SelectedItem.ToString();
            Thread thd = new Thread(() =>
            {
                CreateISO.Create(drive);
            });
            thd.IsBackground = true;
            thd.Start();

            Thread thd2 = new Thread(() => {
                while (thd.IsAlive)
                {
                    status = CreateISO.status;
                    Thread.Sleep(33);
                }
                status = "Calculating SHA256 hash...";
                string hash = CalculateHash();
                status = "Done.";
                this.Invoke((Action)(() => {
                    hashTextBox.Text = hash;
                    hashDiskButton.Enabled = true;
                }));
            });
            thd2.IsBackground = true;
            thd2.Start();
        }

        private string CalculateHash()
        {
            SHA256Managed sha256hash = new SHA256Managed();
            using (FileStream fs = new FileStream("disk.iso", FileMode.Open))
            {
                if (fs.Length == 0)
                {
                    return "Error.";
                }

                byte[] hash = sha256hash.ComputeHash(fs);
                string hashString = string.Empty;
                foreach (byte x in hash)
                {
                    hashString += String.Format("{0:x2}", x);
                }

                fs.Close();

                return hashString;
            }
        }

        private void _Closing(object sender, FormClosingEventArgs e)
        {
            updateTimer.Stop();
        }
    }
}
