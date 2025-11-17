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
    public partial class FormProveedores : Form
    {
        public FormProveedores()
        {
            InitializeComponent();
        }

        public void FormProveedores_Load(object sender, EventArgs e)
        {
            // CONFIGURAR COLUMNAS DEL GRID
            dgvProveedores.ColumnCount = 8;
            dgvProveedores.Columns[0].Name = "IdProveedor";
            dgvProveedores.Columns[1].Name = "RUC";
            dgvProveedores.Columns[2].Name = "RazonSocial";
            dgvProveedores.Columns[3].Name = "Direccion";
            dgvProveedores.Columns[4].Name = "Telefono";
            dgvProveedores.Columns[5].Name = "Correo";
            dgvProveedores.Columns[6].Name = "Estado";
            dgvProveedores.Columns[7].Name = "FechaRegistro";

            // AGREGAR REGISTROS MANUALMENTE (SIN BD)
            dgvProveedores.Rows.Add(1, "20123456789", "Calzados Perú S.A.", "Av. Los Olivos 123", "987654321", "contacto@calzadosperu.com", 1, DateTime.Now);
            dgvProveedores.Rows.Add(2, "20456789123", "Distribuidora Andina", "Jr. Lima 450", "945123678", "ventas@andina.com", 1, DateTime.Now);
            dgvProveedores.Rows.Add(3, "20987654321", "Proveedor Textil SAC", "Av. Grau 789", "912345678", "info@textilsac.com", 1, DateTime.Now);
            dgvProveedores.Rows.Add(4, "20111222333", "Importadora Zapatos SRL", "Calle Piura 230", "999888777", "ventas@importzapa.com", 1, DateTime.Now);
            dgvProveedores.Rows.Add(5, "20567891234", "Marcas Globales SAC", "Av. Arequipa 3500", "934556677", "contacto@marcglobal.com", 1, DateTime.Now);
            dgvProveedores.Rows.Add(6, "20876543211", "Soluciones Comerciales EIRL", "Jr. Callao 120", "987111444", "info@solcom.com", 1, DateTime.Now);
            dgvProveedores.Rows.Add(7, "20999988877", "Proveedor Integral SAC", "Av. Angamos 560", "944333222", "ventas@integral.com", 1, DateTime.Now);
            dgvProveedores.Rows.Add(8, "20765432112", "Zapatería El Paso", "Calle Chiclayo 44", "955666444", "contacto@elpaso.com", 0, DateTime.Now);
            dgvProveedores.Rows.Add(9, "20654321999", "Servicios Rivera", "Av. Libertad 800", "933222111", "servicios@rivera.com", 1, DateTime.Now);
            dgvProveedores.Rows.Add(10, "20543219888", "Inversiones Romero", "Jr. Puno 340", "922555333", "info@romero.com", 1, DateTime.Now);
            dgvProveedores.Rows.Add(11, "20432198777", "Distribuciones Medina", "Av. Cusco 1200", "988111222", "contacto@medina.com", 1, DateTime.Now);
            dgvProveedores.Rows.Add(12, "20321987655", "Calzado Moderno SAC", "Calle Cuzco 450", "977444555", "ventas@calzmoderno.com", 1, DateTime.Now);
        }


    }
}
