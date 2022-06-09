
namespace Ejercicio1
{
    partial class FuncionesTexto
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
            this.CadenaTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LongitudLabel = new System.Windows.Forms.Label();
            this.GenerarButton = new System.Windows.Forms.Button();
            this.PrimerCaracterLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UltimoCaracterLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MayusLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MinusLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.RemplazarLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CadenaTextBox
            // 
            this.CadenaTextBox.Location = new System.Drawing.Point(274, 67);
            this.CadenaTextBox.Name = "CadenaTextBox";
            this.CadenaTextBox.Size = new System.Drawing.Size(280, 20);
            this.CadenaTextBox.TabIndex = 0;
            this.CadenaTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CadenaTextBox_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Longitud de la cadena: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // LongitudLabel
            // 
            this.LongitudLabel.AutoSize = true;
            this.LongitudLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LongitudLabel.Location = new System.Drawing.Point(416, 118);
            this.LongitudLabel.Name = "LongitudLabel";
            this.LongitudLabel.Size = new System.Drawing.Size(14, 13);
            this.LongitudLabel.TabIndex = 2;
            this.LongitudLabel.Text = "?";
            this.LongitudLabel.Click += new System.EventHandler(this.LongitudLabel_Click);
            // 
            // GenerarButton
            // 
            this.GenerarButton.Location = new System.Drawing.Point(579, 50);
            this.GenerarButton.Name = "GenerarButton";
            this.GenerarButton.Size = new System.Drawing.Size(75, 52);
            this.GenerarButton.TabIndex = 3;
            this.GenerarButton.Text = "Generar Funciones de Texto";
            this.GenerarButton.UseVisualStyleBackColor = true;
            this.GenerarButton.Click += new System.EventHandler(this.GenerarButton_Click);
            // 
            // PrimerCaracterLabel
            // 
            this.PrimerCaracterLabel.AutoSize = true;
            this.PrimerCaracterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrimerCaracterLabel.Location = new System.Drawing.Point(416, 151);
            this.PrimerCaracterLabel.Name = "PrimerCaracterLabel";
            this.PrimerCaracterLabel.Size = new System.Drawing.Size(14, 13);
            this.PrimerCaracterLabel.TabIndex = 5;
            this.PrimerCaracterLabel.Text = "?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Primer caracter: ";
            // 
            // UltimoCaracterLabel
            // 
            this.UltimoCaracterLabel.AutoSize = true;
            this.UltimoCaracterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UltimoCaracterLabel.Location = new System.Drawing.Point(416, 182);
            this.UltimoCaracterLabel.Name = "UltimoCaracterLabel";
            this.UltimoCaracterLabel.Size = new System.Drawing.Size(14, 13);
            this.UltimoCaracterLabel.TabIndex = 7;
            this.UltimoCaracterLabel.Text = "?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(271, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ultimo caracter: ";
            // 
            // MayusLabel
            // 
            this.MayusLabel.AutoSize = true;
            this.MayusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MayusLabel.Location = new System.Drawing.Point(416, 214);
            this.MayusLabel.Name = "MayusLabel";
            this.MayusLabel.Size = new System.Drawing.Size(14, 13);
            this.MayusLabel.TabIndex = 9;
            this.MayusLabel.Text = "?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(271, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Todo Mayus: ";
            // 
            // MinusLabel
            // 
            this.MinusLabel.AutoSize = true;
            this.MinusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinusLabel.Location = new System.Drawing.Point(416, 242);
            this.MinusLabel.Name = "MinusLabel";
            this.MinusLabel.Size = new System.Drawing.Size(14, 13);
            this.MinusLabel.TabIndex = 11;
            this.MinusLabel.Text = "?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(271, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Todo Minus: ";
            // 
            // RemplazarLabel
            // 
            this.RemplazarLabel.AutoSize = true;
            this.RemplazarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemplazarLabel.Location = new System.Drawing.Point(416, 271);
            this.RemplazarLabel.Name = "RemplazarLabel";
            this.RemplazarLabel.Size = new System.Drawing.Size(14, 13);
            this.RemplazarLabel.TabIndex = 13;
            this.RemplazarLabel.Text = "?";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(271, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Reemplazar n por *: ";
            // 
            // FuncionesTexto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RemplazarLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MinusLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MayusLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.UltimoCaracterLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PrimerCaracterLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GenerarButton);
            this.Controls.Add(this.LongitudLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CadenaTextBox);
            this.Name = "FuncionesTexto";
            this.Text = "Funciones de Texto";
            this.Load += new System.EventHandler(this.FuncionesTexto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CadenaTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LongitudLabel;
        private System.Windows.Forms.Button GenerarButton;
        private System.Windows.Forms.Label PrimerCaracterLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label UltimoCaracterLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label MayusLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label MinusLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label RemplazarLabel;
        private System.Windows.Forms.Label label7;
    }
}