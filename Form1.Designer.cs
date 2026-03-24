using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace GestorTareas2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtNombre;
        private TextBox txtDescripcion;
        private DateTimePicker dtpFecha;
        private ListBox lstTareas;
        private Button btnAnadir;
        private Button btnEliminar;
        private Button btnCompletar;
        private Label lblLista;
        private Label lblNombre;
        private Label lblDescripcion;

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
            txtNombre = new TextBox();
            txtDescripcion = new TextBox();
            dtpFecha = new DateTimePicker();
            lstTareas = new ListBox();
            btnAnadir = new Button();
            btnEliminar = new Button();
            btnCompletar = new Button();
            lblLista = new Label();
            lblNombre = new Label();
            lblDescripcion = new Label();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(30, 50);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(200, 23);
            txtNombre.TabIndex = 0;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(30, 120);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(300, 100);
            txtDescripcion.TabIndex = 1;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(30, 240);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(200, 23);
            dtpFecha.TabIndex = 2;
            // 
            // lstTareas
            // 
            lstTareas.ItemHeight = 15;
            lstTareas.Location = new Point(400, 60);
            lstTareas.Name = "lstTareas";
            lstTareas.Size = new Size(300, 169);
            lstTareas.TabIndex = 3;
            // 
            // btnAnadir
            // 
            btnAnadir.Location = new Point(30, 300);
            btnAnadir.Name = "btnAnadir";
            btnAnadir.Size = new Size(150, 30);
            btnAnadir.TabIndex = 4;
            btnAnadir.Text = "Añadir tarea";
            btnAnadir.Click += btnAnadir_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(200, 300);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(150, 30);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar tarea";
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCompletar
            // 
            btnCompletar.Location = new Point(400, 270);
            btnCompletar.Name = "btnCompletar";
            btnCompletar.Size = new Size(200, 30);
            btnCompletar.TabIndex = 6;
            btnCompletar.Text = "Marcar completada";
            btnCompletar.Click += btnCompletar_Click;
            // 
            // lblLista
            // 
            lblLista.Location = new Point(400, 20);
            lblLista.Name = "lblLista";
            lblLista.Size = new Size(200, 20);
            lblLista.TabIndex = 9;
            lblLista.Text = "Lista de tareas";
            // 
            // lblNombre
            // 
            lblNombre.Location = new Point(30, 20);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(200, 20);
            lblNombre.TabIndex = 7;
            lblNombre.Text = "Nombre de la tarea";
            // 
            // lblDescripcion
            // 
            lblDescripcion.Location = new Point(30, 90);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(200, 20);
            lblDescripcion.TabIndex = 8;
            lblDescripcion.Text = "Descripción";
            // 
            // Form1
            // 
            BackColor = Color.Moccasin;
            ClientSize = new Size(750, 400);
            Controls.Add(txtNombre);
            Controls.Add(txtDescripcion);
            Controls.Add(dtpFecha);
            Controls.Add(lstTareas);
            Controls.Add(btnAnadir);
            Controls.Add(btnEliminar);
            Controls.Add(btnCompletar);
            Controls.Add(lblNombre);
            Controls.Add(lblDescripcion);
            Controls.Add(lblLista);
            Name = "Form1";
            Text = "Gestor de Tareas";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
