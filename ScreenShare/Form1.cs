using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenShare
{
    public partial class frmScreenShare : Form
    {
        public frmScreenShare()
        {
            InitializeComponent();
        }
        private static Bitmap CaptureDesktop()
        {
            Rectangle desktopRect = GetDesktopBounds();

            Bitmap bitmap = new Bitmap(desktopRect.Width, desktopRect.Height);

            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                graphics.CopyFromScreen(desktopRect.Location, Point.Empty, bitmap.Size);
            }

            Image img = (Image)bitmap;

            return bitmap;

        }

        private static Rectangle GetDesktopBounds()
        {
            Rectangle result = new Rectangle();

            foreach (Screen screen in Screen.AllScreens)
            {
                result = Rectangle.Union(result, screen.Bounds);
            }
            return result;
        }

        private void cmdConnect_Click(object sender, EventArgs e)
        {
            string address = txtAddress.Text.Trim();
            string port = txtPort.Text.Trim();
            if (address.Length == 0 && port.Length == 0)
            {
                return;
            }
            lstHistory.Items.Add(address + ":" + port);


        }

        private void lstHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            String[] address = lstHistory.SelectedItem.ToString().Split(':');
            txtAddress.Text = address[0];
            txtPort.Text = address[1];
        }

        private void frmScreenShare_Load(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                while (true)
                {
                    picPreview.Image = CaptureDesktop();
                    GC.Collect();
                    Thread.Sleep(500);
                    Console.WriteLine("hi");
                }
            }).Start();
        }
        private void frmScreenShare_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to stop sharing?", "ScreenShare - Warning", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                Environment.Exit(0);
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
