namespace Ejercicio03
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tNum1 = new System.Windows.Forms.TextBox();
            this.tNum2 = new System.Windows.Forms.TextBox();
            this.bComparar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número 2:";
            // 
            // tNum1
            // 
            this.tNum1.Location = new System.Drawing.Point(239, 97);
            this.tNum1.Name = "tNum1";
            this.tNum1.Size = new System.Drawing.Size(169, 26);
            this.tNum1.TabIndex = 2;
            // 
            // tNum2
            // 
            this.tNum2.Location = new System.Drawing.Point(241, 169);
            this.tNum2.Name = "tNum2";
            this.tNum2.Size = new System.Drawing.Size(166, 26);
            this.tNum2.TabIndex = 3;
            // 
            // bComparar
            // 
            this.bComparar.Location = new System.Drawing.Point(220, 264);
            this.bComparar.Name = "bComparar";
            this.bComparar.Size = new System.Drawing.Size(213, 68);
            this.bComparar.TabIndex = 4;
            this.bComparar.Text = "Comparar";
            this.bComparar.UseVisualStyleBackColor = true;
            this.bComparar.Click += new System.EventHandler(this.bComparar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 411);
            this.Controls.Add(this.bComparar);
            this.Controls.Add(this.tNum2);
            this.Controls.Add(this.tNum1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tNum1;
        private System.Windows.Forms.TextBox tNum2;
        private System.Windows.Forms.Button bComparar;
    }
}

