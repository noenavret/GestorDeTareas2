using System;
using System.Drawing;
using System.Windows.Forms;

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
        private Button btnLimpiarCampos;
        private Label lblLista;
        private Label lblNombre;
        private Label lblDescripcion;
        private Label lblContadorTareas;
        private CheckBox chkPrioridadAlta;
        private ComboBox cmbCategoria;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

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
            btnLimpiarCampos = new Button();
            lblLista = new Label();
            lblNombre = new Label();
            lblDescripcion = new Label();
            lblContadorTareas = new Label();
            chkPrioridadAlta = new CheckBox();
            cmbCategoria = new ComboBox();

            SuspendLayout();

            // txtNombre
            txtNombre.Location = new Point(30, 50);
            txtNombre.Size = new Size(200, 30);

            // txtDescripcion
            txtDescripcion.Location = new Point(30, 120);
            txtDescripcion.Size = new Size(300, 100);
            txtDescripcion.Multiline = true;

            // dtpFecha
            dtpFecha.Location = new Point(30, 240);

            // CheckBox
            chkPrioridadAlta.Location = new Point(30, 280);
            chkPrioridadAlta.Text = "Prioridad alta";

            // ComboBox
            cmbCategoria.Location = new Point(30, 320);
            cmbCategoria.Size = new Size(200, 30);

            // lstTareas
            lstTareas.Location = new Point(400, 50);
            lstTareas.Size = new Size(300, 200);

            // botones
            btnAnadir.Location = new Point(30, 370);
            btnAnadir.Text = "Añadir";
            btnAnadir.Click += btnAnadir_Click;

            btnEliminar.Location = new Point(130, 370);
            btnEliminar.Text = "Eliminar";
            btnEliminar.Click += btnEliminar_Click;

            btnCompletar.Location = new Point(400, 270);
            btnCompletar.Text = "Completar";
            btnCompletar.Click += btnCompletar_Click;

            btnLimpiarCampos.Location = new Point(230, 370);
            btnLimpiarCampos.Text = "Limpiar";
            btnLimpiarCampos.Click += btnLimpiarCampos_Click;

            // Labels
            lblNombre.Location = new Point(30, 20);
            lblNombre.Text = "Nombre";

            lblDescripcion.Location = new Point(30, 90);
            lblDescripcion.Text = "Descripción";

            lblLista.Location = new Point(400, 20);
            lblLista.Text = "Lista de tareas";

            lblContadorTareas.Location = new Point(400, 320);
            lblContadorTareas.Size = new Size(200, 30);

            // Form
            ClientSize = new Size(750, 450);
            Controls.Add(txtNombre);
            Controls.Add(txtDescripcion);
            Controls.Add(dtpFecha);
            Controls.Add(lstTareas);
            Controls.Add(btnAnadir);
            Controls.Add(btnEliminar);
            Controls.Add(btnCompletar);
            Controls.Add(btnLimpiarCampos);
            Controls.Add(lblNombre);
            Controls.Add(lblDescripcion);
            Controls.Add(lblLista);
            Controls.Add(lblContadorTareas);
            Controls.Add(chkPrioridadAlta);
            Controls.Add(cmbCategoria);

            Text = "Gestor de Tareas";
            Load += Form1_Load;

            ResumeLayout(false);
            PerformLayout();
        }
    }
}