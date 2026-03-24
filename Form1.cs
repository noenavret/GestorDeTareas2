using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GestorTareas2 { 
    public partial class Form1 : Form
    {
        private List<Tarea> tareas = new List<Tarea>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbCategoria.Items.AddRange(new string[]
            {
                "Trabajo", "Personal", "Estudios"
            });

            cmbCategoria.SelectedIndex = 0;
            ActualizarContador();
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre de la tarea es obligatorio.");
                return;
            }

            Tarea nuevaTarea = new Tarea
            {
                Nombre = txtNombre.Text,
                Descripcion = txtDescripcion.Text,
                FechaVencimiento = dtpFecha.Value,
                Completada = false,
                PrioridadAlta = chkPrioridadAlta.Checked,
                Categoria = cmbCategoria.Text
            };

            tareas.Add(nuevaTarea);
            lstTareas.Items.Add(nuevaTarea);

            LimpiarCampos();
            ActualizarContador();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstTareas.SelectedItem == null)
            {
                MessageBox.Show("Selecciona una tarea para eliminar.");
                return;
            }

            Tarea tareaSeleccionada = (Tarea)lstTareas.SelectedItem;
            tareas.Remove(tareaSeleccionada);
            lstTareas.Items.Remove(tareaSeleccionada);

            ActualizarContador();
        }

        private void btnCompletar_Click(object sender, EventArgs e)
        {
            if (lstTareas.SelectedItem == null)
            {
                MessageBox.Show("Selecciona una tarea para completar.");
                return;
            }

            Tarea tareaSeleccionada = (Tarea)lstTareas.SelectedItem;
            tareaSeleccionada.Completada = true;

            int index = lstTareas.SelectedIndex;
            lstTareas.Items[index] = tareaSeleccionada;
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtDescripcion.Clear();
            chkPrioridadAlta.Checked = false;
            cmbCategoria.SelectedIndex = 0;
        }

        private void ActualizarContador()
        {
            lblContadorTareas.Text = $"Total tareas: {tareas.Count}";
        }
    }
}
