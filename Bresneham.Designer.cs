
namespace Computer_graphics
{
    partial class Bresneham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bresneham));
            this.xabres = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ybbres = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.xbbres = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.yabres = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.XATbres = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.ybtbres = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.yatbres = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.xbtbres = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuTileButton1 = new Bunifu.Framework.UI.BunifuTileButton();
            this.Bres = new Bunifu.Framework.UI.BunifuTileButton();
            this.bres_pic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bres_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // xabres
            // 
            this.xabres.AutoSize = true;
            this.xabres.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xabres.ForeColor = System.Drawing.Color.Indigo;
            this.xabres.Location = new System.Drawing.Point(85, 51);
            this.xabres.Name = "xabres";
            this.xabres.Size = new System.Drawing.Size(39, 24);
            this.xabres.TabIndex = 0;
            this.xabres.Text = "XA";
            // 
            // ybbres
            // 
            this.ybbres.AutoSize = true;
            this.ybbres.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ybbres.ForeColor = System.Drawing.Color.Indigo;
            this.ybbres.Location = new System.Drawing.Point(435, 132);
            this.ybbres.Name = "ybbres";
            this.ybbres.Size = new System.Drawing.Size(32, 24);
            this.ybbres.TabIndex = 1;
            this.ybbres.Text = "yb";
            // 
            // xbbres
            // 
            this.xbbres.AutoSize = true;
            this.xbbres.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xbbres.ForeColor = System.Drawing.Color.Indigo;
            this.xbbres.Location = new System.Drawing.Point(85, 132);
            this.xbbres.Name = "xbbres";
            this.xbbres.Size = new System.Drawing.Size(38, 24);
            this.xbbres.TabIndex = 2;
            this.xbbres.Text = "XB";
            this.xbbres.Click += new System.EventHandler(this.xbbres_Click);
            // 
            // yabres
            // 
            this.yabres.AutoSize = true;
            this.yabres.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yabres.ForeColor = System.Drawing.Color.Indigo;
            this.yabres.Location = new System.Drawing.Point(435, 51);
            this.yabres.Name = "yabres";
            this.yabres.Size = new System.Drawing.Size(31, 24);
            this.yabres.TabIndex = 3;
            this.yabres.Text = "ya";
            // 
            // XATbres
            // 
            this.XATbres.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.XATbres.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.XATbres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.XATbres.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XATbres.ForeColor = System.Drawing.Color.Indigo;
            this.XATbres.Location = new System.Drawing.Point(189, 51);
            this.XATbres.Name = "XATbres";
            this.XATbres.Size = new System.Drawing.Size(100, 29);
            this.XATbres.TabIndex = 4;
            // 
            // ybtbres
            // 
            this.ybtbres.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ybtbres.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ybtbres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ybtbres.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ybtbres.ForeColor = System.Drawing.Color.Indigo;
            this.ybtbres.Location = new System.Drawing.Point(527, 138);
            this.ybtbres.Name = "ybtbres";
            this.ybtbres.Size = new System.Drawing.Size(100, 29);
            this.ybtbres.TabIndex = 5;
            // 
            // yatbres
            // 
            this.yatbres.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.yatbres.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.yatbres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yatbres.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yatbres.ForeColor = System.Drawing.Color.Indigo;
            this.yatbres.Location = new System.Drawing.Point(527, 57);
            this.yatbres.Name = "yatbres";
            this.yatbres.Size = new System.Drawing.Size(100, 29);
            this.yatbres.TabIndex = 6;
            // 
            // xbtbres
            // 
            this.xbtbres.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.xbtbres.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.xbtbres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.xbtbres.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xbtbres.ForeColor = System.Drawing.Color.Indigo;
            this.xbtbres.Location = new System.Drawing.Point(202, 138);
            this.xbtbres.Name = "xbtbres";
            this.xbtbres.Size = new System.Drawing.Size(100, 29);
            this.xbtbres.TabIndex = 7;
            this.xbtbres.TextChanged += new System.EventHandler(this.xbtbres_TextChanged);
            // 
            // bunifuTileButton1
            // 
            this.bunifuTileButton1.BackColor = System.Drawing.Color.Black;
            this.bunifuTileButton1.color = System.Drawing.Color.Black;
            this.bunifuTileButton1.colorActive = System.Drawing.Color.Black;
            this.bunifuTileButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton1.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton1.Image")));
            this.bunifuTileButton1.ImagePosition = 20;
            this.bunifuTileButton1.ImageZoom = 50;
            this.bunifuTileButton1.LabelPosition = 41;
            this.bunifuTileButton1.LabelText = "";
            this.bunifuTileButton1.Location = new System.Drawing.Point(668, 325);
            this.bunifuTileButton1.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton1.Name = "bunifuTileButton1";
            this.bunifuTileButton1.Size = new System.Drawing.Size(128, 129);
            this.bunifuTileButton1.TabIndex = 10;
            this.bunifuTileButton1.Click += new System.EventHandler(this.bunifuTileButton1_Click);
            // 
            // Bres
            // 
            this.Bres.BackColor = System.Drawing.Color.Black;
            this.Bres.color = System.Drawing.Color.Black;
            this.Bres.colorActive = System.Drawing.Color.Black;
            this.Bres.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bres.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.Bres.ForeColor = System.Drawing.Color.White;
            this.Bres.Image = ((System.Drawing.Image)(resources.GetObject("Bres.Image")));
            this.Bres.ImagePosition = 20;
            this.Bres.ImageZoom = 50;
            this.Bres.LabelPosition = 41;
            this.Bres.LabelText = "";
            this.Bres.Location = new System.Drawing.Point(616, 184);
            this.Bres.Margin = new System.Windows.Forms.Padding(6);
            this.Bres.Name = "Bres";
            this.Bres.Size = new System.Drawing.Size(128, 129);
            this.Bres.TabIndex = 9;
            this.Bres.Click += new System.EventHandler(this.Bres_Click);
            // 
            // bres_pic
            // 
            this.bres_pic.Location = new System.Drawing.Point(75, 203);
            this.bres_pic.Name = "bres_pic";
            this.bres_pic.Size = new System.Drawing.Size(483, 201);
            this.bres_pic.TabIndex = 8;
            this.bres_pic.TabStop = false;
            // 
            // Bresneham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bunifuTileButton1);
            this.Controls.Add(this.Bres);
            this.Controls.Add(this.bres_pic);
            this.Controls.Add(this.xbtbres);
            this.Controls.Add(this.yatbres);
            this.Controls.Add(this.ybtbres);
            this.Controls.Add(this.XATbres);
            this.Controls.Add(this.yabres);
            this.Controls.Add(this.xbbres);
            this.Controls.Add(this.ybbres);
            this.Controls.Add(this.xabres);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Bresneham";
            this.Text = "Bresneham";
            ((System.ComponentModel.ISupportInitialize)(this.bres_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel xabres;
        private Bunifu.Framework.UI.BunifuCustomLabel ybbres;
        private Bunifu.Framework.UI.BunifuCustomLabel xbbres;
        private Bunifu.Framework.UI.BunifuCustomLabel yabres;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox XATbres;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox ybtbres;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox yatbres;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox xbtbres;
        private System.Windows.Forms.PictureBox bres_pic;
        private Bunifu.Framework.UI.BunifuTileButton Bres;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton1;
    }
}