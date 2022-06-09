
namespace Ejercicio1
{
    partial class FuncionesProcedimientos
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
            this.Valor1textBox = new System.Windows.Forms.TextBox();
            this.Valor2textBox = new System.Windows.Forms.TextBox();
            this.Ejecutarbutton = new System.Windows.Forms.Button();
            this.Restarbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Valor1textBox
            // 
            this.Valor1textBox.Location = new System.Drawing.Point(356, 78);
            this.Valor1textBox.Name = "Valor1textBox";
            this.Valor1textBox.Size = new System.Drawing.Size(100, 20);
            this.Valor1textBox.TabIndex = 0;
            this.Valor1textBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Valor2textBox
            // 
            this.Valor2textBox.Location = new System.Drawing.Point(356, 141);
            this.Valor2textBox.Name = "Valor2textBox";
            this.Valor2textBox.Size = new System.Drawing.Size(100, 20);
            this.Valor2textBox.TabIndex = 1;
            this.Valor2textBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Ejecutarbutton
            // 
            this.Ejecutarbutton.Location = new System.Drawing.Point(356, 201);
            this.Ejecutarbutton.Name = "Ejecutarbutton";
            this.Ejecutarbutton.Size = new System.Drawing.Size(100, 23);
            this.Ejecutarbutton.TabIndex = 2;
            this.Ejecutarbutton.Text = "Ejecutar Sm";
            this.Ejecutarbutton.UseVisualStyleBackColor = true;
            this.Ejecutarbutton.Click += new System.EventHandler(this.Ejecutarbutton_Click);
            // 
            // Restarbutton
            // 
            this.Restarbutton.Location = new System.Drawing.Point(356, 276);
            this.Restarbutton.Name = "Restarbutton";
            this.Restarbutton.Size = new System.Drawing.Size(100, 23);
            this.Restarbutton.TabIndex = 3;
            this.Restarbutton.Text = "Ejecutar Rst";
            this.Restarbutton.UseVisualStyleBackColor = true;
            this.Restarbutton.Click += new System.EventHandler(this.Restarbutton_Click);
            // 
            // FuncionesProcedimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Restarbutton);
            this.Controls.Add(this.Ejecutarbutton);
            this.Controls.Add(this.Valor2textBox);
            this.Controls.Add(this.Valor1textBox);
            this.Name = "FuncionesProcedimientos";
            this.Text = "Funciones y Procedimentos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Valor1textBox;
        private System.Windows.Forms.TextBox Valor2textBox;
        private System.Windows.Forms.Button Ejecutarbutton;
        private System.Windows.Forms.Button Restarbutton;
    }
}

