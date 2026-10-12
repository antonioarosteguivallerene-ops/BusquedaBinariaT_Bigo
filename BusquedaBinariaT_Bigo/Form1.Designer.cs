using System.Windows.Forms;

namespace BusquedaBinaria
{
    public partial class Form1 : Form
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTamano = new System.Windows.Forms.Label();
            this.txtTamano = new System.Windows.Forms.TextBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.lstDatos = new System.Windows.Forms.ListBox();
            this.lblGenerado = new System.Windows.Forms.Label();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.rtxtPasos = new System.Windows.Forms.RichTextBox();
            this.lblPasos = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.rtxtResultado = new System.Windows.Forms.RichTextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblComplejidad = new System.Windows.Forms.Label();
            this.rtxtComplejidad = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();

            // lblTamano
            this.lblTamano.AutoSize = true;
            this.lblTamano.Location = new System.Drawing.Point(12, 15);
            this.lblTamano.Name = "lblTamano";
            this.lblTamano.Size = new System.Drawing.Size(100, 13);
            this.lblTamano.TabIndex = 0;
            this.lblTamano.Text = "Tamaño del arreglo (n):";

            // txtTamano
            this.txtTamano.Location = new System.Drawing.Point(12, 31);
            this.txtTamano.Name = "txtTamano";
            this.txtTamano.Size = new System.Drawing.Size(100, 20);
            this.txtTamano.TabIndex = 1;

            // btnGenerar
            this.btnGenerar.Location = new System.Drawing.Point(120, 31);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 2;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);

            // lstDatos
            this.lstDatos.FormattingEnabled = true;
            this.lstDatos.Location = new System.Drawing.Point(12, 75);
            this.lstDatos.Name = "lstDatos";
            this.lstDatos.Size = new System.Drawing.Size(300, 95);
            this.lstDatos.TabIndex = 3;

            // lblGenerado
            this.lblGenerado.AutoSize = true;
            this.lblGenerado.Location = new System.Drawing.Point(12, 59);
            this.lblGenerado.Name = "lblGenerado";
            this.lblGenerado.Size = new System.Drawing.Size(100, 13);
            this.lblGenerado.TabIndex = 4;
            this.lblGenerado.Text = "Arreglo generado:";

            // lblBuscar
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(12, 185);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(100, 13);
            this.lblBuscar.TabIndex = 5;
            this.lblBuscar.Text = "Valor a buscar:";

            // txtBuscar
            this.txtBuscar.Location = new System.Drawing.Point(12, 201);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(100, 20);
            this.txtBuscar.TabIndex = 6;

            // btnBuscar
            this.btnBuscar.Location = new System.Drawing.Point(120, 201);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);

            // lblPasos
            this.lblPasos.AutoSize = true;
            this.lblPasos.Location = new System.Drawing.Point(320, 15);
            this.lblPasos.Name = "lblPasos";
            this.lblPasos.Size = new System.Drawing.Size(80, 13);
            this.lblPasos.TabIndex = 8;
            this.lblPasos.Text = "Pasos de ejecución:";

            // rtxtPasos
            this.rtxtPasos.Location = new System.Drawing.Point(320, 31);
            this.rtxtPasos.Name = "rtxtPasos";
            this.rtxtPasos.ReadOnly = true;
            this.rtxtPasos.Size = new System.Drawing.Size(250, 139);
            this.rtxtPasos.TabIndex = 9;
            this.rtxtPasos.Text = "";

            // lblResultado
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(320, 185);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(60, 13);
            this.lblResultado.TabIndex = 10;
            this.lblResultado.Text = "Resultado:";

            // rtxtResultado
            this.rtxtResultado.Location = new System.Drawing.Point(320, 201);
            this.rtxtResultado.Name = "rtxtResultado";
            this.rtxtResultado.ReadOnly = true;
            this.rtxtResultado.Size = new System.Drawing.Size(250, 80);
            this.rtxtResultado.TabIndex = 11;
            this.rtxtResultado.Text = "";

            // btnLimpiar
            this.btnLimpiar.Location = new System.Drawing.Point(495, 201);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 12;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);

            // lblComplejidad
            this.lblComplejidad.AutoSize = true;
            this.lblComplejidad.Location = new System.Drawing.Point(12, 235);
            this.lblComplejidad.Name = "lblComplejidad";
            this.lblComplejidad.Size = new System.Drawing.Size(100, 13);
            this.lblComplejidad.TabIndex = 13;
            this.lblComplejidad.Text = "Análisis de complejidad:";

            // rtxtComplejidad
            this.rtxtComplejidad.Location = new System.Drawing.Point(12, 251);
            this.rtxtComplejidad.Name = "rtxtComplejidad";
            this.rtxtComplejidad.ReadOnly = true;
            this.rtxtComplejidad.Size = new System.Drawing.Size(558, 110);
            this.rtxtComplejidad.TabIndex = 14;
            this.rtxtComplejidad.Text = "";

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 373);
            this.Controls.Add(this.rtxtComplejidad);
            this.Controls.Add(this.lblComplejidad);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.rtxtResultado);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.rtxtPasos);
            this.Controls.Add(this.lblPasos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.lblGenerado);
            this.Controls.Add(this.lstDatos);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.txtTamano);
            this.Controls.Add(this.lblTamano);
            this.Name = "Form1";
            this.Text = "Búsqueda Binaria - Análisis de Complejidad";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTamano;
        private System.Windows.Forms.TextBox txtTamano;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.ListBox lstDatos;
        private System.Windows.Forms.Label lblGenerado;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.RichTextBox rtxtPasos;
        private System.Windows.Forms.Label lblPasos;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.RichTextBox rtxtResultado;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblComplejidad;
        private System.Windows.Forms.RichTextBox rtxtComplejidad;
    }
}
