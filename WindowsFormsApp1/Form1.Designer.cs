namespace WindowsFormsApp1
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
            this.buttonRacunskeOperacije = new System.Windows.Forms.Button();
            this.buttonPoruke = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonRacunskeOperacije
            // 
            this.buttonRacunskeOperacije.Location = new System.Drawing.Point(37, 28);
            this.buttonRacunskeOperacije.Name = "buttonRacunskeOperacije";
            this.buttonRacunskeOperacije.Size = new System.Drawing.Size(145, 23);
            this.buttonRacunskeOperacije.TabIndex = 0;
            this.buttonRacunskeOperacije.Text = "Računske Operacije";
            this.buttonRacunskeOperacije.UseVisualStyleBackColor = true;
            this.buttonRacunskeOperacije.Click += new System.EventHandler(this.buttonRacunskeOperacije_Click);
            // 
            // buttonPoruke
            // 
            this.buttonPoruke.Location = new System.Drawing.Point(37, 70);
            this.buttonPoruke.Name = "buttonPoruke";
            this.buttonPoruke.Size = new System.Drawing.Size(145, 23);
            this.buttonPoruke.TabIndex = 1;
            this.buttonPoruke.Text = "Poruke";
            this.buttonPoruke.UseVisualStyleBackColor = true;
            this.buttonPoruke.Click += new System.EventHandler(this.buttonPoruke_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 142);
            this.Controls.Add(this.buttonPoruke);
            this.Controls.Add(this.buttonRacunskeOperacije);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRacunskeOperacije;
        private System.Windows.Forms.Button buttonPoruke;
    }
}

