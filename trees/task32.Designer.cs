
namespace trees
{
    partial class task32
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
            this.Ntext = new System.Windows.Forms.TextBox();
            this.Nbut = new System.Windows.Forms.Button();
            this.Nsbutt = new System.Windows.Forms.Button();
            this.Nstext = new System.Windows.Forms.TextBox();
            this.hey = new System.Windows.Forms.Label();
            this.numver = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Ntext
            // 
            this.Ntext.Location = new System.Drawing.Point(46, 30);
            this.Ntext.Name = "Ntext";
            this.Ntext.Size = new System.Drawing.Size(201, 27);
            this.Ntext.TabIndex = 0;
            // 
            // Nbut
            // 
            this.Nbut.Location = new System.Drawing.Point(253, 30);
            this.Nbut.Name = "Nbut";
            this.Nbut.Size = new System.Drawing.Size(37, 29);
            this.Nbut.TabIndex = 1;
            this.Nbut.Text = "OK";
            this.Nbut.UseVisualStyleBackColor = true;
            this.Nbut.Click += new System.EventHandler(this.Nbut_Click);
            // 
            // Nsbutt
            // 
            this.Nsbutt.Location = new System.Drawing.Point(314, 30);
            this.Nsbutt.Name = "Nsbutt";
            this.Nsbutt.Size = new System.Drawing.Size(37, 29);
            this.Nsbutt.TabIndex = 3;
            this.Nsbutt.Text = "OK";
            this.Nsbutt.UseVisualStyleBackColor = true;
            this.Nsbutt.Visible = false;
            this.Nsbutt.Click += new System.EventHandler(this.Nsbutt_Click);
            // 
            // Nstext
            // 
            this.Nstext.Location = new System.Drawing.Point(12, 30);
            this.Nstext.Name = "Nstext";
            this.Nstext.Size = new System.Drawing.Size(296, 27);
            this.Nstext.TabIndex = 2;
            this.Nstext.Visible = false;
            // 
            // hey
            // 
            this.hey.AutoSize = true;
            this.hey.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hey.Location = new System.Drawing.Point(46, 62);
            this.hey.Name = "hey";
            this.hey.Size = new System.Drawing.Size(0, 28);
            this.hey.TabIndex = 4;
            // 
            // numver
            // 
            this.numver.AutoSize = true;
            this.numver.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numver.Location = new System.Drawing.Point(46, 2);
            this.numver.Name = "numver";
            this.numver.Size = new System.Drawing.Size(151, 28);
            this.numver.TabIndex = 5;
            this.numver.Text = "Число вершин:";
            // 
            // task32
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(361, 121);
            this.Controls.Add(this.numver);
            this.Controls.Add(this.hey);
            this.Controls.Add(this.Nsbutt);
            this.Controls.Add(this.Nbut);
            this.Controls.Add(this.Ntext);
            this.Controls.Add(this.Nstext);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "task32";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "task32";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Ntext;
        private System.Windows.Forms.Button Nbut;
        private System.Windows.Forms.Button Nsbutt;
        private System.Windows.Forms.TextBox Nstext;
        private System.Windows.Forms.Label hey;
        private System.Windows.Forms.Label numver;
    }
}