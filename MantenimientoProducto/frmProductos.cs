using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MantenimientoProducto
{
    public partial class frmProductos : Form
    {
        DataBaseContext db = new DataBaseContext();

        public frmProductos()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Producto p = new Producto();
            p.Codigo = Convert.ToInt32(txtCodigo.Text);
            p.Descripcion = txtDescripcion.Text;
            p.CodigoCategoria = int.Parse(txtCategoria.Text);
            p.Precio = double.Parse(txtPrecio.Text);

            db.Productos.Add(p);
            CargarGV();
        }

        public void CargarGV()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = db.Productos;
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            CargarGV();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            foreach (var p in db.Productos)
            {
                if (p.Codigo == int.Parse(txtCodigo.Text))
                {
                    txtDescripcion.Text = p.Descripcion;
                    txtCategoria.Text = p.CodigoCategoria.ToString();
                    txtPrecio.Text = p.Precio.ToString();

                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = new List<Producto>() { p };
                }
            }
        }
    }
}
