
namespace PRACTICA_SEMANA_07
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
            this.Lista = new System.Windows.Forms.DataGridView();
            this.dgData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Lista)).BeginInit();
            this.SuspendLayout();
            // 
            // Lista
            // 
            this.Lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Lista.Location = new System.Drawing.Point(12, 25);
            this.Lista.Name = "Lista";
            this.Lista.RowHeadersWidth = 51;
            this.Lista.RowTemplate.Height = 24;
            this.Lista.Size = new System.Drawing.Size(692, 291);
            this.Lista.TabIndex = 0;
            this.Lista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Lista_CellContentClick);
            // 
            // dgData
            // 
            this.dgData.Location = new System.Drawing.Point(710, 368);
            this.dgData.Name = "dgData";
            this.dgData.Size = new System.Drawing.Size(92, 53);
            this.dgData.TabIndex = 1;
            this.dgData.Text = "DATOS";
            this.dgData.UseVisualStyleBackColor = true;
            this.dgData.Click += new System.EventHandler(this.dgData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 433);
            this.Controls.Add(this.dgData);
            this.Controls.Add(this.Lista);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Lista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Lista;
        private System.Windows.Forms.Button dgData;
    }
}

