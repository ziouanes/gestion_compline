namespace p2
{
    partial class acceulle
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
            this.MS1 = new System.Windows.Forms.MenuStrip();
            this.consulationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conx = new System.Windows.Forms.ToolStripMenuItem();
            this.deconx = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.show = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MS1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MS1
            // 
            this.MS1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.MS1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MS1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MS1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consulationToolStripMenuItem,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.show});
            this.MS1.Location = new System.Drawing.Point(0, 0);
            this.MS1.Name = "MS1";
            this.MS1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.MS1.ShowItemToolTips = true;
            this.MS1.Size = new System.Drawing.Size(1181, 33);
            this.MS1.Stretch = false;
            this.MS1.TabIndex = 2;
            this.MS1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MS1_ItemClicked);
            // 
            // consulationToolStripMenuItem
            // 
            this.consulationToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.consulationToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.consulationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conx,
            this.deconx});
            this.consulationToolStripMenuItem.ForeColor = System.Drawing.Color.Silver;
            this.consulationToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.consulationToolStripMenuItem.Name = "consulationToolStripMenuItem";
            this.consulationToolStripMenuItem.Size = new System.Drawing.Size(121, 29);
            this.consulationToolStripMenuItem.Text = "Connection";
            this.consulationToolStripMenuItem.Click += new System.EventHandler(this.consulationToolStripMenuItem_Click);
            // 
            // conx
            // 
            this.conx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.conx.ForeColor = System.Drawing.Color.Silver;
            this.conx.Name = "conx";
            this.conx.Size = new System.Drawing.Size(180, 30);
            this.conx.Text = "Log_in";
            this.conx.Click += new System.EventHandler(this.conx_Click);
            // 
            // deconx
            // 
            this.deconx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.deconx.Enabled = false;
            this.deconx.ForeColor = System.Drawing.Color.Silver;
            this.deconx.Name = "deconx";
            this.deconx.Size = new System.Drawing.Size(180, 30);
            this.deconx.Text = "Log_out";
            this.deconx.Click += new System.EventHandler(this.deconx_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.toolStripMenuItem1.Enabled = false;
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.Silver;
            this.toolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.ShowShortcutKeys = false;
            this.toolStripMenuItem1.Size = new System.Drawing.Size(144, 29);
            this.toolStripMenuItem1.Text = "Add_compline";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.toolStripMenuItem2.Enabled = false;
            this.toolStripMenuItem2.ForeColor = System.Drawing.Color.Silver;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(157, 29);
            this.toolStripMenuItem2.Text = "recive compline";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.toolStripMenuItem3.Enabled = false;
            this.toolStripMenuItem3.ForeColor = System.Drawing.Color.Silver;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(178, 29);
            this.toolStripMenuItem3.Text = "Show all compline";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.toolStripMenuItem4.Enabled = false;
            this.toolStripMenuItem4.ForeColor = System.Drawing.Color.Silver;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(166, 29);
            this.toolStripMenuItem4.Text = "update compline";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // show
            // 
            this.show.Enabled = false;
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(134, 29);
            this.show.Text = "update Users";
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::p2.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1181, 437);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // acceulle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 470);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MS1);
            this.Name = "acceulle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "acceulle";
            this.Load += new System.EventHandler(this.acceulle_Load);
            this.MS1.ResumeLayout(false);
            this.MS1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MS1;
        private System.Windows.Forms.ToolStripMenuItem consulationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conx;
        private System.Windows.Forms.ToolStripMenuItem deconx;
        private System.Windows.Forms.ToolStripMenuItem show;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}