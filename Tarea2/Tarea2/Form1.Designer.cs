
namespace Tarea2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.numerolabel1 = new System.Windows.Forms.Label();
            this.Numerolabel2 = new System.Windows.Forms.Label();
            this.Numerolabel3 = new System.Windows.Forms.Label();
            this.Numerolabel4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Calcularbutton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numerolabel1
            // 
            this.numerolabel1.AutoSize = true;
            this.numerolabel1.Location = new System.Drawing.Point(136, 73);
            this.numerolabel1.Name = "numerolabel1";
            this.numerolabel1.Size = new System.Drawing.Size(53, 13);
            this.numerolabel1.TabIndex = 0;
            this.numerolabel1.Text = "Numero 1";
            // 
            // Numerolabel2
            // 
            this.Numerolabel2.AutoSize = true;
            this.Numerolabel2.Location = new System.Drawing.Point(136, 101);
            this.Numerolabel2.Name = "Numerolabel2";
            this.Numerolabel2.Size = new System.Drawing.Size(53, 13);
            this.Numerolabel2.TabIndex = 1;
            this.Numerolabel2.Text = "Numero 2";
            // 
            // Numerolabel3
            // 
            this.Numerolabel3.AutoSize = true;
            this.Numerolabel3.Location = new System.Drawing.Point(136, 127);
            this.Numerolabel3.Name = "Numerolabel3";
            this.Numerolabel3.Size = new System.Drawing.Size(53, 13);
            this.Numerolabel3.TabIndex = 2;
            this.Numerolabel3.Text = "Numero 3";
            // 
            // Numerolabel4
            // 
            this.Numerolabel4.AutoSize = true;
            this.Numerolabel4.Location = new System.Drawing.Point(136, 159);
            this.Numerolabel4.Name = "Numerolabel4";
            this.Numerolabel4.Size = new System.Drawing.Size(53, 13);
            this.Numerolabel4.TabIndex = 3;
            this.Numerolabel4.Text = "Numero 4";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(195, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(195, 96);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(128, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(195, 124);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(128, 20);
            this.textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(195, 156);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(128, 20);
            this.textBox4.TabIndex = 7;
            // 
            // Calcularbutton1
            // 
            this.Calcularbutton1.Location = new System.Drawing.Point(402, 143);
            this.Calcularbutton1.Name = "Calcularbutton1";
            this.Calcularbutton1.Size = new System.Drawing.Size(95, 33);
            this.Calcularbutton1.TabIndex = 8;
            this.Calcularbutton1.Text = "Calcular";
            this.Calcularbutton1.UseVisualStyleBackColor = true;
            this.Calcularbutton1.Click += new System.EventHandler(this.Calcularbutton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Calcularbutton1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Numerolabel4);
            this.Controls.Add(this.Numerolabel3);
            this.Controls.Add(this.Numerolabel2);
            this.Controls.Add(this.numerolabel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label numerolabel1;
        private System.Windows.Forms.Label Numerolabel2;
        private System.Windows.Forms.Label Numerolabel3;
        private System.Windows.Forms.Label Numerolabel4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button Calcularbutton1;
    }
}

