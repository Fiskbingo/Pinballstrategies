namespace Pinball
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.about1 = new Pinball.about();
            this.drwho1 = new Pinball.drwho();
            this.congo1 = new Pinball.congo();
            this.alien1 = new Pinball.Alien();
            this.start1 = new Pinball.Start();
            this.twd1 = new Pinball.twd();
            this.batman661 = new Pinball.batman66();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(185, 1041);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(46, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 97);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.PeachPuff;
            this.label1.Location = new System.Drawing.Point(48, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select game";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.PeachPuff;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.DropDownWidth = 200;
            this.comboBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(15, 300);
            this.comboBox1.MaxDropDownItems = 20;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(170, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.Font = new System.Drawing.Font("Wide Latin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 58);
            this.button1.TabIndex = 4;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LimeGreen;
            this.button2.Font = new System.Drawing.Font("Wide Latin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 183);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 58);
            this.button2.TabIndex = 3;
            this.button2.Text = "About";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(185, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1719, 108);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1719, 108);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // about1
            // 
            this.about1.BackColor = System.Drawing.Color.Black;
            this.about1.Location = new System.Drawing.Point(202, 119);
            this.about1.Name = "about1";
            this.about1.Size = new System.Drawing.Size(1716, 992);
            this.about1.TabIndex = 6;
            // 
            // drwho1
            // 
            this.drwho1.AutoSize = true;
            this.drwho1.BackColor = System.Drawing.Color.Black;
            this.drwho1.Cursor = System.Windows.Forms.Cursors.Default;
            this.drwho1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drwho1.ForeColor = System.Drawing.Color.PeachPuff;
            this.drwho1.Location = new System.Drawing.Point(189, 116);
            this.drwho1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.drwho1.Name = "drwho1";
            this.drwho1.Size = new System.Drawing.Size(1702, 995);
            this.drwho1.TabIndex = 5;
            // 
            // congo1
            // 
            this.congo1.BackColor = System.Drawing.Color.Black;
            this.congo1.Location = new System.Drawing.Point(191, 114);
            this.congo1.Name = "congo1";
            this.congo1.Size = new System.Drawing.Size(1785, 992);
            this.congo1.TabIndex = 4;
            // 
            // alien1
            // 
            this.alien1.BackColor = System.Drawing.Color.Black;
            this.alien1.Location = new System.Drawing.Point(191, 114);
            this.alien1.Name = "alien1";
            this.alien1.Size = new System.Drawing.Size(1785, 992);
            this.alien1.TabIndex = 3;
            // 
            // start1
            // 
            this.start1.BackColor = System.Drawing.Color.Black;
            this.start1.Location = new System.Drawing.Point(191, 114);
            this.start1.Name = "start1";
            this.start1.Size = new System.Drawing.Size(1785, 992);
            this.start1.TabIndex = 2;
            // 
            // twd1
            // 
            this.twd1.BackColor = System.Drawing.Color.Black;
            this.twd1.Cursor = System.Windows.Forms.Cursors.Default;
            this.twd1.Location = new System.Drawing.Point(191, 116);
            this.twd1.Name = "twd1";
            this.twd1.Size = new System.Drawing.Size(1785, 992);
            this.twd1.TabIndex = 3;
            // 
            // batman661
            // 
            this.batman661.BackColor = System.Drawing.Color.Black;
            this.batman661.Location = new System.Drawing.Point(191, 114);
            this.batman661.Name = "batman661";
            this.batman661.Size = new System.Drawing.Size(1785, 992);
            this.batman661.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.about1);
            this.Controls.Add(this.drwho1);
            this.Controls.Add(this.congo1);
            this.Controls.Add(this.alien1);
            this.Controls.Add(this.start1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.twd1);
            this.Controls.Add(this.batman661);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pinball Strategies!";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Start start1;
        private Alien alien1;
        private batman66 batman661;
        private twd twd1;
        private System.Windows.Forms.Label label1;
        private congo congo1;
        private drwho drwho1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private about about1;
    }
}

