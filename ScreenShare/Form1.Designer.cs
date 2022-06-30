
namespace ScreenShare
{
    partial class frmScreenShare
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmScreenShare));
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lstHistory = new System.Windows.Forms.ListBox();
            this.cmdConnect = new System.Windows.Forms.Button();
            this.cmdStart = new System.Windows.Forms.Button();
            this.cmdStop = new System.Windows.Forms.Button();
            this.lblHistory = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lblPreview = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.picPreview = new System.Windows.Forms.PictureBox();
            this.lblSplit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(12, 57);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(267, 35);
            this.txtAddress.TabIndex = 0;
            // 
            // lstHistory
            // 
            this.lstHistory.FormattingEnabled = true;
            this.lstHistory.ItemHeight = 29;
            this.lstHistory.Location = new System.Drawing.Point(556, 57);
            this.lstHistory.Name = "lstHistory";
            this.lstHistory.Size = new System.Drawing.Size(232, 381);
            this.lstHistory.TabIndex = 1;
            this.lstHistory.SelectedIndexChanged += new System.EventHandler(this.lstHistory_SelectedIndexChanged);
            // 
            // cmdConnect
            // 
            this.cmdConnect.Location = new System.Drawing.Point(12, 393);
            this.cmdConnect.Name = "cmdConnect";
            this.cmdConnect.Size = new System.Drawing.Size(130, 45);
            this.cmdConnect.TabIndex = 2;
            this.cmdConnect.Text = "Connect";
            this.cmdConnect.UseVisualStyleBackColor = true;
            this.cmdConnect.Click += new System.EventHandler(this.cmdConnect_Click);
            // 
            // cmdStart
            // 
            this.cmdStart.Location = new System.Drawing.Point(148, 393);
            this.cmdStart.Name = "cmdStart";
            this.cmdStart.Size = new System.Drawing.Size(198, 45);
            this.cmdStart.TabIndex = 3;
            this.cmdStart.Text = "Start";
            this.cmdStart.UseVisualStyleBackColor = true;
            // 
            // cmdStop
            // 
            this.cmdStop.Location = new System.Drawing.Point(352, 393);
            this.cmdStop.Name = "cmdStop";
            this.cmdStop.Size = new System.Drawing.Size(198, 45);
            this.cmdStop.TabIndex = 4;
            this.cmdStop.Text = "Stop";
            this.cmdStop.UseVisualStyleBackColor = true;
            // 
            // lblHistory
            // 
            this.lblHistory.AutoSize = true;
            this.lblHistory.Location = new System.Drawing.Point(556, 25);
            this.lblHistory.Name = "lblHistory";
            this.lblHistory.Size = new System.Drawing.Size(87, 29);
            this.lblHistory.TabIndex = 5;
            this.lblHistory.Text = "History";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(12, 25);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(130, 29);
            this.lblAddress.TabIndex = 6;
            this.lblAddress.Text = "IP Address";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(313, 25);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(57, 29);
            this.lblPort.TabIndex = 8;
            this.lblPort.Text = "Port";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(313, 57);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(237, 35);
            this.txtPort.TabIndex = 7;
            // 
            // lblPreview
            // 
            this.lblPreview.AutoSize = true;
            this.lblPreview.Location = new System.Drawing.Point(12, 106);
            this.lblPreview.Name = "lblPreview";
            this.lblPreview.Size = new System.Drawing.Size(100, 29);
            this.lblPreview.TabIndex = 9;
            this.lblPreview.Text = "Preview";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // picPreview
            // 
            this.picPreview.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.picPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPreview.Location = new System.Drawing.Point(12, 138);
            this.picPreview.Name = "picPreview";
            this.picPreview.Size = new System.Drawing.Size(538, 249);
            this.picPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPreview.TabIndex = 10;
            this.picPreview.TabStop = false;
            // 
            // lblSplit
            // 
            this.lblSplit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSplit.Location = new System.Drawing.Point(285, 54);
            this.lblSplit.Name = "lblSplit";
            this.lblSplit.Size = new System.Drawing.Size(22, 29);
            this.lblSplit.TabIndex = 11;
            this.lblSplit.Text = ":";
            // 
            // frmScreenShare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSplit);
            this.Controls.Add(this.picPreview);
            this.Controls.Add(this.lblPreview);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblHistory);
            this.Controls.Add(this.cmdStop);
            this.Controls.Add(this.cmdStart);
            this.Controls.Add(this.cmdConnect);
            this.Controls.Add(this.lstHistory);
            this.Controls.Add(this.txtAddress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmScreenShare";
            this.Text = "ScreenShare";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmScreenShare_FormClosing);
            this.Load += new System.EventHandler(this.frmScreenShare_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.ListBox lstHistory;
        private System.Windows.Forms.Button cmdConnect;
        private System.Windows.Forms.Button cmdStart;
        private System.Windows.Forms.Button cmdStop;
        private System.Windows.Forms.Label lblHistory;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label lblPreview;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox picPreview;
        private System.Windows.Forms.Label lblSplit;
    }
}

