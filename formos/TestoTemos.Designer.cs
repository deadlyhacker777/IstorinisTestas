namespace formos
{
    partial class TestoTemos
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
            this.JAVbutton = new System.Windows.Forms.Button();
            this.OSMbutton = new System.Windows.Forms.Button();
            this.WWIIbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // JAVbutton
            // 
            this.JAVbutton.Location = new System.Drawing.Point(85, 71);
            this.JAVbutton.Name = "JAVbutton";
            this.JAVbutton.Size = new System.Drawing.Size(137, 23);
            this.JAVbutton.TabIndex = 0;
            this.JAVbutton.Text = "JAV revoliucija";
            this.JAVbutton.UseVisualStyleBackColor = true;
            this.JAVbutton.Click += new System.EventHandler(this.JAVbutton_Click);
            // 
            // OSMbutton
            // 
            this.OSMbutton.Location = new System.Drawing.Point(85, 116);
            this.OSMbutton.Name = "OSMbutton";
            this.OSMbutton.Size = new System.Drawing.Size(137, 23);
            this.OSMbutton.TabIndex = 1;
            this.OSMbutton.Text = "Osmanų Imperija";
            this.OSMbutton.UseVisualStyleBackColor = true;
            this.OSMbutton.Click += new System.EventHandler(this.OSMbutton_Click);
            // 
            // WWIIbutton
            // 
            this.WWIIbutton.Location = new System.Drawing.Point(85, 169);
            this.WWIIbutton.Name = "WWIIbutton";
            this.WWIIbutton.Size = new System.Drawing.Size(137, 23);
            this.WWIIbutton.TabIndex = 2;
            this.WWIIbutton.Text = "Antrasis pasaulinis karas";
            this.WWIIbutton.UseVisualStyleBackColor = true;
            this.WWIIbutton.Click += new System.EventHandler(this.WWIIbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pasirinkite temą";
            // 
            // TestoTemos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WWIIbutton);
            this.Controls.Add(this.OSMbutton);
            this.Controls.Add(this.JAVbutton);
            this.Name = "TestoTemos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "TestoTemos";
            this.Load += new System.EventHandler(this.TestoTemos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button JAVbutton;
        private System.Windows.Forms.Button OSMbutton;
        private System.Windows.Forms.Button WWIIbutton;
        private System.Windows.Forms.Label label1;
    }
}