using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiendaDeCalzados
{
    public partial class FormClientes : Form
    {
        public FormClientes()
        {
            InitializeComponent();
        }

        public void FormClientes_load(object sender, EventArgs e)
        {
            dgvClientes.ColumnCount = 4;
            dgvClientes.Columns[0].Name = "Cod";
            dgvClientes.Columns[1].Name = "Nombres";
            dgvClientes.Columns[2].Name = "Teléfono";
            dgvClientes.Columns[3].Name = "Correo";

            string[] row1 = { "001", "Miguel Grau Semimario", "987654321", "fbolognesi@gmail.com" };
            string[] row2 = { "002", "Francisco Bolognesi Cervantes", "985472145", "mgrau@hotmail.com" };
            string[] row3 = { "003", "Abelardo Quiñones Gonzales", "985214756", "aquinones@yahoo.com" };
            string[] row4 = { "004", "Alfonso Ugarte Vernal", "96325874", "augarte@outlook.com" };

            dgvClientes.Rows.Add(row1);
            dgvClientes.Rows.Add(row2);
            dgvClientes.Rows.Add(row3);
            dgvClientes.Rows.Add(row4);


        }
    }
}
