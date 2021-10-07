
namespace UI
{
    partial class MainForm
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
            this.ObjetivosDataGrid = new System.Windows.Forms.DataGridView();
            this.labelArma = new System.Windows.Forms.Label();
            this.DispararBtn = new System.Windows.Forms.Button();
            this.RadarBtn = new System.Windows.Forms.Button();
            this.labelBienvenida = new System.Windows.Forms.Label();
            this.DeteccionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ObjetivosDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ObjetivosDataGrid
            // 
            this.ObjetivosDataGrid.AllowUserToAddRows = false;
            this.ObjetivosDataGrid.AllowUserToDeleteRows = false;
            this.ObjetivosDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ObjetivosDataGrid.Location = new System.Drawing.Point(12, 95);
            this.ObjetivosDataGrid.MultiSelect = false;
            this.ObjetivosDataGrid.Name = "ObjetivosDataGrid";
            this.ObjetivosDataGrid.ReadOnly = true;
            this.ObjetivosDataGrid.RowTemplate.Height = 25;
            this.ObjetivosDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ObjetivosDataGrid.Size = new System.Drawing.Size(776, 343);
            this.ObjetivosDataGrid.TabIndex = 0;
            this.ObjetivosDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ObjetivosDataGrid_CellClick);
            // 
            // labelArma
            // 
            this.labelArma.Location = new System.Drawing.Point(412, 32);
            this.labelArma.Name = "labelArma";
            this.labelArma.Size = new System.Drawing.Size(376, 19);
            this.labelArma.TabIndex = 1;
            this.labelArma.Text = "label1";
            this.labelArma.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // DispararBtn
            // 
            this.DispararBtn.Location = new System.Drawing.Point(713, 66);
            this.DispararBtn.Name = "DispararBtn";
            this.DispararBtn.Size = new System.Drawing.Size(75, 23);
            this.DispararBtn.TabIndex = 2;
            this.DispararBtn.Text = "Disparar";
            this.DispararBtn.UseVisualStyleBackColor = true;
            this.DispararBtn.Click += new System.EventHandler(this.DispararBtn_Click);
            // 
            // RadarBtn
            // 
            this.RadarBtn.Location = new System.Drawing.Point(626, 66);
            this.RadarBtn.Name = "RadarBtn";
            this.RadarBtn.Size = new System.Drawing.Size(75, 23);
            this.RadarBtn.TabIndex = 3;
            this.RadarBtn.Text = "Usar Radar";
            this.RadarBtn.UseVisualStyleBackColor = true;
            this.RadarBtn.Click += new System.EventHandler(this.RadarBtn_Click);
            // 
            // labelBienvenida
            // 
            this.labelBienvenida.Location = new System.Drawing.Point(12, 9);
            this.labelBienvenida.Name = "labelBienvenida";
            this.labelBienvenida.Size = new System.Drawing.Size(376, 31);
            this.labelBienvenida.TabIndex = 4;
            this.labelBienvenida.Text = "Bienvenido, presione el boton \"Usar Radar\" para detectar los objetivos dentro de " +
    "200 Km";
            // 
            // DeteccionLabel
            // 
            this.DeteccionLabel.Location = new System.Drawing.Point(12, 58);
            this.DeteccionLabel.Name = "DeteccionLabel";
            this.DeteccionLabel.Size = new System.Drawing.Size(514, 31);
            this.DeteccionLabel.TabIndex = 5;
            this.DeteccionLabel.Text = "DeteccionLabel";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeteccionLabel);
            this.Controls.Add(this.labelBienvenida);
            this.Controls.Add(this.RadarBtn);
            this.Controls.Add(this.DispararBtn);
            this.Controls.Add(this.labelArma);
            this.Controls.Add(this.ObjetivosDataGrid);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ObjetivosDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ObjetivosDataGrid;
        private System.Windows.Forms.Label labelArma;
        private System.Windows.Forms.Button DispararBtn;
        private System.Windows.Forms.Button RadarBtn;
        private System.Windows.Forms.Label labelBienvenida;
        private System.Windows.Forms.Label DeteccionLabel;
    }
}

