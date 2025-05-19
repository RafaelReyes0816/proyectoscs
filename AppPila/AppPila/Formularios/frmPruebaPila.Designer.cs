namespace AppPila
{
    partial class frmPruebaPila
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
            this.txtElemento = new System.Windows.Forms.TextBox();
            this.btnPush = new System.Windows.Forms.Button();
            this.btnPop = new System.Windows.Forms.Button();
            this.pbarEstado = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // txtElemento
            // 
            this.txtElemento.Location = new System.Drawing.Point(12, 12);
            this.txtElemento.Name = "txtElemento";
            this.txtElemento.Size = new System.Drawing.Size(196, 20);
            this.txtElemento.TabIndex = 0;
            // 
            // btnPush
            // 
            this.btnPush.Location = new System.Drawing.Point(12, 38);
            this.btnPush.Name = "btnPush";
            this.btnPush.Size = new System.Drawing.Size(196, 23);
            this.btnPush.TabIndex = 1;
            this.btnPush.Text = "Agregar elemento";
            this.btnPush.UseVisualStyleBackColor = true;
            this.btnPush.Click += new System.EventHandler(this.btnPush_Click);
            // 
            // btnPop
            // 
            this.btnPop.Location = new System.Drawing.Point(12, 67);
            this.btnPop.Name = "btnPop";
            this.btnPop.Size = new System.Drawing.Size(196, 23);
            this.btnPop.TabIndex = 2;
            this.btnPop.Text = "Quitar elemento";
            this.btnPop.UseVisualStyleBackColor = true;
            this.btnPop.Click += new System.EventHandler(this.btnPop_Click);
            // 
            // pbarEstado
            // 
            this.pbarEstado.Location = new System.Drawing.Point(12, 96);
            this.pbarEstado.Name = "pbarEstado";
            this.pbarEstado.Size = new System.Drawing.Size(196, 48);
            this.pbarEstado.TabIndex = 3;
            // 
            // frmPruebaPila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 164);
            this.Controls.Add(this.pbarEstado);
            this.Controls.Add(this.btnPop);
            this.Controls.Add(this.btnPush);
            this.Controls.Add(this.txtElemento);
            this.Name = "frmPruebaPila";
            this.Text = "frmPruebaPila";
            this.Load += new System.EventHandler(this.frmPruebaPila_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtElemento;
        private System.Windows.Forms.Button btnPush;
        private System.Windows.Forms.Button btnPop;
        private System.Windows.Forms.ProgressBar pbarEstado;
    }
}