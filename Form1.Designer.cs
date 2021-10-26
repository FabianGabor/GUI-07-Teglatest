namespace GUI_07_Teglatest
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
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.labelC = new System.Windows.Forms.Label();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTerfogat = new System.Windows.Forms.TextBox();
            this.labelFelszin = new System.Windows.Forms.Label();
            this.textBoxFelszin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(177, 124);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(54, 20);
            this.textBoxA.TabIndex = 0;
            this.textBoxA.TextChanged += new System.EventHandler(this.textBoxA_TextChanged);
            // 
            // labelA
            // 
            this.labelA.Location = new System.Drawing.Point(150, 124);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(21, 20);
            this.labelA.TabIndex = 1;
            this.labelA.Text = "a";
            // 
            // labelB
            // 
            this.labelB.Location = new System.Drawing.Point(150, 150);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(21, 20);
            this.labelB.TabIndex = 3;
            this.labelB.Text = "b";
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(177, 150);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(54, 20);
            this.textBoxB.TabIndex = 2;
            this.textBoxB.TextChanged += new System.EventHandler(this.textBoxB_TextChanged);
            // 
            // labelC
            // 
            this.labelC.Location = new System.Drawing.Point(150, 176);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(21, 20);
            this.labelC.TabIndex = 5;
            this.labelC.Text = "c";
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new System.Drawing.Point(177, 176);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(54, 20);
            this.textBoxC.TabIndex = 4;
            this.textBoxC.TextChanged += new System.EventHandler(this.textBoxC_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(309, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Terfogat";
            // 
            // textBoxTerfogat
            // 
            this.textBoxTerfogat.Location = new System.Drawing.Point(392, 159);
            this.textBoxTerfogat.Name = "textBoxTerfogat";
            this.textBoxTerfogat.ReadOnly = true;
            this.textBoxTerfogat.Size = new System.Drawing.Size(54, 20);
            this.textBoxTerfogat.TabIndex = 8;
            // 
            // labelFelszin
            // 
            this.labelFelszin.Location = new System.Drawing.Point(309, 133);
            this.labelFelszin.Name = "labelFelszin";
            this.labelFelszin.Size = new System.Drawing.Size(77, 20);
            this.labelFelszin.TabIndex = 7;
            this.labelFelszin.Text = "Felszin";
            // 
            // textBoxFelszin
            // 
            this.textBoxFelszin.Location = new System.Drawing.Point(392, 133);
            this.textBoxFelszin.Name = "textBoxFelszin";
            this.textBoxFelszin.ReadOnly = true;
            this.textBoxFelszin.Size = new System.Drawing.Size(54, 20);
            this.textBoxFelszin.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTerfogat);
            this.Controls.Add(this.labelFelszin);
            this.Controls.Add(this.textBoxFelszin);
            this.Controls.Add(this.labelC);
            this.Controls.Add(this.textBoxC);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.textBoxA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTerfogat;
        private System.Windows.Forms.Label labelFelszin;
        private System.Windows.Forms.TextBox textBoxFelszin;

        #endregion
    }
}