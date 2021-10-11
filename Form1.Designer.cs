
namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.etPantalla = new System.Windows.Forms.Label();
            this.bt7n = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // etPantalla
            // 
            this.etPantalla.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.etPantalla.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.etPantalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.etPantalla.Location = new System.Drawing.Point(26, 27);
            this.etPantalla.Name = "etPantalla";
            this.etPantalla.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.etPantalla.Size = new System.Drawing.Size(539, 46);
            this.etPantalla.TabIndex = 0;
            this.etPantalla.Text = "0,";
            this.etPantalla.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bt7n
            // 
            this.bt7n.BackColor = System.Drawing.SystemColors.ControlDark;
            this.bt7n.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bt7n.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.bt7n.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.bt7n.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt7n.Location = new System.Drawing.Point(26, 99);
            this.bt7n.Name = "bt7n";
            this.bt7n.Size = new System.Drawing.Size(53, 56);
            this.bt7n.TabIndex = 1;
            this.bt7n.Text = "7";
            this.bt7n.UseVisualStyleBackColor = false;
            this.bt7n.MouseHover += new System.EventHandler(this.bt7n_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(593, 455);
            this.Controls.Add(this.bt7n);
            this.Controls.Add(this.etPantalla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label etPantalla;
        private System.Windows.Forms.Button bt7n;
    }
}

