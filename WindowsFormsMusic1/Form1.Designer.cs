namespace WindowsFormsMusic1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFD = new System.Windows.Forms.OpenFileDialog();
            this.saveFD = new System.Windows.Forms.SaveFileDialog();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowPanel = new System.Windows.Forms.Panel();
            this.buttonStop = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFD
            // 
            this.openFD.FileName = "openFD";
            // 
            // buttonPlus
            // 
            this.buttonPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPlus.Location = new System.Drawing.Point(37, 12);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(126, 26);
            this.buttonPlus.TabIndex = 5;
            this.buttonPlus.Text = "Open File";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMinus.Location = new System.Drawing.Point(37, 76);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(126, 26);
            this.buttonMinus.TabIndex = 6;
            this.buttonMinus.Text = "Create playlist";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.buttonMinus_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(206, 483);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(564, 160);
            this.listBox1.TabIndex = 4;
            // 
            // buttonPrev
            // 
            this.buttonPrev.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPrev.Location = new System.Drawing.Point(19, 3);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(75, 23);
            this.buttonPrev.TabIndex = 3;
            this.buttonPrev.Text = "<<";
            this.buttonPrev.UseVisualStyleBackColor = true;
            // 
            // buttonPlay
            // 
            this.buttonPlay.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonPlay.BackColor = System.Drawing.Color.Red;
            this.buttonPlay.Location = new System.Drawing.Point(110, 3);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(75, 23);
            this.buttonPlay.TabIndex = 2;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = false;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNext.Location = new System.Drawing.Point(272, 2);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 1;
            this.buttonNext.Text = ">>";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(287, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(369, 375);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // flowPanel
            // 
            this.flowPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowPanel.Controls.Add(this.buttonStop);
            this.flowPanel.Controls.Add(this.buttonNext);
            this.flowPanel.Controls.Add(this.buttonPrev);
            this.flowPanel.Controls.Add(this.buttonPlay);
            this.flowPanel.Location = new System.Drawing.Point(287, 430);
            this.flowPanel.Name = "flowPanel";
            this.flowPanel.Size = new System.Drawing.Size(369, 43);
            this.flowPanel.TabIndex = 7;
            // 
            // buttonStop
            // 
            this.buttonStop.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonStop.BackColor = System.Drawing.Color.LightCoral;
            this.buttonStop.Location = new System.Drawing.Point(191, 3);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 4;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = false;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.buttonPlus);
            this.panel1.Controls.Add(this.buttonMinus);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 643);
            this.panel1.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(37, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 26);
            this.button1.TabIndex = 5;
            this.button1.Text = "Playlists";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(771, 643);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowPanel);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Music";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFD;
        private System.Windows.Forms.SaveFileDialog saveFD;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel flowPanel;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}

