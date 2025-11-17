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
    public partial class FormUsuarios : Form
    {
        public FormUsuarios()
        {
            InitializeComponent();
        }
        public void FormUsuarios_Load(object sender, EventArgs e)
        {
            // CONFIGURAR COLUMNAS DEL GRID
            dgvUsuarios.ColumnCount = 7;

            dgvUsuarios.Columns[0].Name = "IdUsuario";
            dgvUsuarios.Columns[1].Name = "Usuario";
            dgvUsuarios.Columns[2].Name = "Clave";
            dgvUsuarios.Columns[3].Name = "NombreCompleto";
            dgvUsuarios.Columns[4].Name = "Correo";
            dgvUsuarios.Columns[5].Name = "Estado";
            dgvUsuarios.Columns[6].Name = "IdRol";

            // AGREGAR REGISTROS MANUALMENTE (SIN BD)
            dgvUsuarios.Rows.Add(1, "admin", "123456", "Administrador General", "admin@tienda.com", 1, 1);
            dgvUsuarios.Rows.Add(2, "ventas01", "ventas2025", "Juan Pérez", "juan@tienda.com", 1, 2);
            dgvUsuarios.Rows.Add(3, "cajera01", "caja123", "María López", "maria@tienda.com", 1, 3);
            dgvUsuarios.Rows.Add(4, "almacen01", "almacen456", "Pedro Ruiz", "pedro@tienda.com", 1, 4);
            dgvUsuarios.Rows.Add(5, "soporte01", "soporte789", "Luis García", "luis@tienda.com", 1, 5);
            dgvUsuarios.Rows.Add(6, "ventas02", "v2025", "Ana Torres", "ana@tienda.com", 1, 2);
            dgvUsuarios.Rows.Add(7, "cajera02", "caj432", "Sofía Medina", "sofia@tienda.com", 1, 3);
            dgvUsuarios.Rows.Add(8, "almacen02", "alm951", "Hugo Castro", "hugo@tienda.com", 1, 4);
            dgvUsuarios.Rows.Add(9, "soporte02", "sup258", "Carlos Ramos", "carlos@tienda.com", 1, 5);
            dgvUsuarios.Rows.Add(10, "ventas03", "v3030", "Jorge Díaz", "jorge@tienda.com", 1, 2);
            dgvUsuarios.Rows.Add(11, "cajera03", "caj963", "Valeria Ponce", "valeria@tienda.com", 0, 3);
            dgvUsuarios.Rows.Add(12, "admin2", "adm2025", "Administrador Secundario", "admin2@tienda.com", 1, 1);
        }
        
    }
}
