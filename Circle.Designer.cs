
namespace Computer_graphics
{
    partial class Circle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Circle));
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.raduis = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.circle_pic = new System.Windows.Forms.PictureBox();
            this.Start_Circle = new Bunifu.Framework.UI.BunifuTileButton();
            this.undo_circle = new Bunifu.Framework.UI.BunifuTileButton();
            ((System.ComponentModel.ISupportInitialize)(this.circle_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(59, 43);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(103, 13);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "bunifuCustomLabel1";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(341, 132);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(38, 13);
            this.bunifuCustomLabel2.TabIndex = 1;
            this.bunifuCustomLabel2.Text = "Radus";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.Indigo;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(73, 65);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(112, 33);
            this.bunifuCustomLabel3.TabIndex = 2;
            this.bunifuCustomLabel3.Text = "Raduis";
            // 
            // raduis
            // 
            this.raduis.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.raduis.BorderColor = System.Drawing.Color.Indigo;
            this.raduis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.raduis.Location = new System.Drawing.Point(297, 78);
            this.raduis.Name = "raduis";
            this.raduis.Size = new System.Drawing.Size(100, 20);
            this.raduis.TabIndex = 3;
            // 
            // circle_pic
            // 
            this.circle_pic.Location = new System.Drawing.Point(62, 148);
            this.circle_pic.Name = "circle_pic";
            this.circle_pic.Size = new System.Drawing.Size(477, 215);
            this.circle_pic.TabIndex = 4;
            this.circle_pic.TabStop = false;
            // 
            // Start_Circle
            // 
            this.Start_Circle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Start_Circle.color = System.Drawing.SystemColors.ActiveCaptionText;
            this.Start_Circle.colorActive = System.Drawing.SystemColors.ActiveCaptionText;
            this.Start_Circle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Start_Circle.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.Start_Circle.ForeColor = System.Drawing.Color.White;
            this.Start_Circle.Image = ((System.Drawing.Image)(resources.GetObject("Start_Circle.Image")));
            this.Start_Circle.ImagePosition = 20;
            this.Start_Circle.ImageZoom = 50;
            this.Start_Circle.LabelPosition = 41;
            this.Start_Circle.LabelText = "";
            this.Start_Circle.Location = new System.Drawing.Point(607, 78);
            this.Start_Circle.Margin = new System.Windows.Forms.Padding(6);
            this.Start_Circle.Name = "Start_Circle";
            this.Start_Circle.Size = new System.Drawing.Size(128, 129);
            this.Start_Circle.TabIndex = 5;
            this.Start_Circle.Click += new System.EventHandler(this.Start_Circle_Click);
            // 
            // undo_circle
            // 
            this.undo_circle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.undo_circle.color = System.Drawing.SystemColors.ActiveCaptionText;
            this.undo_circle.colorActive = System.Drawing.SystemColors.ActiveCaptionText;
            this.undo_circle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.undo_circle.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.undo_circle.ForeColor = System.Drawing.Color.White;
            this.undo_circle.Image = ((System.Drawing.Image)(resources.GetObject("undo_circle.Image")));
            this.undo_circle.ImagePosition = 20;
            this.undo_circle.ImageZoom = 50;
            this.undo_circle.LabelPosition = 41;
            this.undo_circle.LabelText = "";
            this.undo_circle.Location = new System.Drawing.Point(657, 248);
            this.undo_circle.Margin = new System.Windows.Forms.Padding(6);
            this.undo_circle.Name = "undo_circle";
            this.undo_circle.Size = new System.Drawing.Size(128, 129);
            this.undo_circle.TabIndex = 6;
            this.undo_circle.Click += new System.EventHandler(this.undo_circle_Click);
            // 
            // Circle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.undo_circle);
            this.Controls.Add(this.Start_Circle);
            this.Controls.Add(this.circle_pic);
            this.Controls.Add(this.raduis);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Circle";
            this.Text = "Circle";
            this.Load += new System.EventHandler(this.Circle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.circle_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox raduis;
        private System.Windows.Forms.PictureBox circle_pic;
        private Bunifu.Framework.UI.BunifuTileButton Start_Circle;
        private Bunifu.Framework.UI.BunifuTileButton undo_circle;
    }
}