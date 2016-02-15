namespace CS_App1 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnFindGuitar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFindGuitar
            // 
            this.btnFindGuitar.Location = new System.Drawing.Point(12, 12);
            this.btnFindGuitar.Name = "btnFindGuitar";
            this.btnFindGuitar.Size = new System.Drawing.Size(75, 23);
            this.btnFindGuitar.TabIndex = 0;
            this.btnFindGuitar.Text = "Find Guitar";
            this.btnFindGuitar.UseVisualStyleBackColor = true;
            this.btnFindGuitar.Click += new System.EventHandler(this.btnFindGuitar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnFindGuitar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFindGuitar;
    }
}

