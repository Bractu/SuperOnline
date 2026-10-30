using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperOnline
{
    public partial class Form1 : Form
    {
        public class productos
        {
            public string producto { get; set; }
            public int precio { get; set; }
            public int cantidad { get; set; }
            public decimal subtotal => precio * cantidad;
        }
        public Form1()
        {
            InitializeComponent();
        }
        List<productos> carrito = new List<productos>();

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnManzana_Click(object sender, EventArgs e)
        {
            int cantidad = (int)numManzana.Value;
            if (cantidad > 0)
            {
                carrito.Add(new productos { producto = "Manzana", precio = 2100, cantidad = cantidad });
            }
        }

        private void btnLeche_Click(object sender, EventArgs e)
        {
            int cantidad = (int)numLeche.Value;
            if (cantidad > 0)
            {
                carrito.Add(new productos { producto = "Leche", precio = 3500, cantidad = cantidad });
            }
        }

        private void btnPan_Click(object sender, EventArgs e)
        {
            int cantidad = (int)numPan.Value;
            if (cantidad > 0)
            {
                carrito.Add(new productos { producto = "Pan", precio = 5600, cantidad = cantidad });
            }
        }

        private void btnArroz_Click(object sender, EventArgs e)
        {
            int cantidad = (int)numArroz.Value;
            if (cantidad > 0)
            {
                carrito.Add(new productos { producto = "Arroz", precio = 2500, cantidad = cantidad });
            }
        }

        private void btnCafe_Click(object sender, EventArgs e)
        {
            int cantidad = (int)numCafe.Value;
            if (cantidad > 0)
            {
                carrito.Add(new productos { producto = "Café", precio = 18000, cantidad = cantidad });
            }
        }

        private void btnCarrito_Click(object sender, EventArgs e)
        {
            if (carrito.Count == 0)
            {
                MessageBox.Show("El carrito está vacío");

            }
            else
            {
                FormCarrito ventanaCarrito = new FormCarrito(carrito);
                ventanaCarrito.ShowDialog();
            }
            
        }
    }
}
