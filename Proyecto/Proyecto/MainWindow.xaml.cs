using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;


namespace Proyecto
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private DataTable Buscar(string condicion = "1=1")
        {
            Clsconexion A = new Clsconexion();
            DataTable B = new DataTable();
            string C = $"select* from Verduras where {condicion}";
            A.consultaTablaDirecta(C);
            return B;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string id = txt1.Text;
            string nombre = txt2.Text;
            string precio = txt3.Text;
            string fecha = txt4.Text;
            string tipo = txt5.Text;
            string sentencia = $"insert into Verduras(id_producto,nombre,precio,fecha,tipo) values({id},'{nombre}','{precio}','{fecha}','{tipo}')  ";
            Clsconexion cn = new Clsconexion();
            cn.EjecutaSQLDirecto(sentencia);

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            string id = txt6.Text;
            Clsconexion cn = new Clsconexion();
            string query = $"select * from Verduras where id_producto={id}";
            DataTable dt = cn.consultaTablaDirecta(query);
            if (dt.Rows.Count > 0)
            {
                string nombre = dt.Rows[0].Field<string>("nombre");
                txt7.Text = nombre;
                string precio = dt.Rows[0].Field<string>("precio");
                txt8.Text = precio;
                string fecha = dt.Rows[0].Field<string>("fecha");
                txt9.Text = fecha;
                string tipo = dt.Rows[0].Field<string>("tipo");
                txt10.Text = tipo;

            }
            else
            {
                txt7.Text = "error";
                txt8.Text = "error";
                txt9.Text = "error";
                txt10.Text = "error";
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string id = txt6.Text;

            string sentencia = $"delete from Verduras where Id_producto={id}";
            Clsconexion cn = new Clsconexion();
            cn.EjecutaSQLDirecto(sentencia);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            string id = txt6.Text;
            string nombre = txt7.Text;
            string pre = txt8.Text;
            string fe = txt9.Text;
            string ti = txt10.Text;


            string sentencia = $"Update Verduras set nombre='{nombre}',precio='{pre}',fecha='{fe}',tipo='{ti}' where Id_producto={id}";
            Clsconexion cn = new Clsconexion();
            cn.EjecutaSQLDirecto(sentencia);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            string id = txt1.Text;
            string nombre = txt2.Text;
            string precio = txt3.Text;
            string fecha = txt4.Text;
            string tipo = txt5.Text;
            string sentencia = $"insert into Verduras(id_producto,nombre,precio,fecha,tipo) values({id},'{nombre}','{precio}','{fecha}','{tipo}')  ";
            Clsconexion cn = new Clsconexion();
            cn.EjecutaSQLDirecto(sentencia);
            
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {

            string id = txt6.Text;
            Clssconexion cn = new Clssconexion();
            string query = $"select * from Verduras where Id_producto={id}";
            DataTable dt = cn.consultaTablaDirecta(query);
            if (dt.Rows.Count > 0)
            {
                string nombre = dt.Rows[0].Field<string>("Nombre");
                txt7.Text = nombre;
                string precio = dt.Rows[0].Field<string>("Aprecio");
                txt8.Text = precio;
                string fecha = dt.Rows[0].Field<string>("fecha");
                txt9.Text = fecha;
                string tipo = dt.Rows[0].Field<string>("tipo");
                txt10.Text = tipo;

            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            string id = txt6.Text;
            string nombre = txt7.Text;
            string pre = txt8.Text;
            string fe = txt9.Text;
            string ti = txt10.Text;


            string sentencia = $"Update Verduras set Nombre='{nombre}',Aprecio='{pre}',fecha='{fe}',tipo='{ti}' where Id_producto={id}";
            Clsconexion cn = new Clsconexion();
            cn.EjecutaSQLDirecto(sentencia);
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {

            string id = txt6.Text;
            Clssconexion cn = new Clssconexion();
            string query = $"select * from Verduras where Id_producto={id}";
            DataTable dt = cn.consultaTablaDirecta(query);
            if (dt.Rows.Count > 0)
            {
                string nombre = dt.Rows[0].Field<string>("Nombre");
                txt7.Text = nombre;
                string precio = dt.Rows[0].Field<string>("Aprecio");
                txt8.Text = precio;
                string fecha = dt.Rows[0].Field<string>("fecha");
                txt9.Text = fecha;
                string tipo = dt.Rows[0].Field<string>("tipo");
                txt10.Text = tipo;

            }
            else
            {
                txt7.Text = "error";
                txt8.Text = "error";
                txt9.Text = "error";
                txt10.Text = "error";
            }
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            string id = txt6.Text;
            string nombre = txt7.Text;
            string pre = txt8.Text;
            string fe = txt9.Text;
            string ti = txt10.Text;


            string sentencia = $"Update Verduras set Nombre='{nombre}',Aprecio='{pre}',fecha='{fe}',tipo='{ti}' where Id_producto={id}";
            Clssconexion cn = new Clssconexion();
            cn.EjecutaSQLDirecto(sentencia);
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            string id = txt1.Text;
            string nombre = txt2.Text;
            string precio = txt3.Text;
            string fecha = txt4.Text;
            string tipo = txt5.Text;
            string sentencia = $"insert into Verduras(Id_producto,Nombre,Aprecio,fecha,tipo) values({id},'{nombre}','{precio}','{fecha}','{tipo}')  ";
            Clssconexion cn = new Clssconexion();
            cn.EjecutaSQLDirecto(sentencia);
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {

            string id = txt6.Text;

            string sentencia = $"delete from Verduras where Id_producto={id}";
            Clssconexion cn = new Clssconexion();
            cn.EjecutaSQLDirecto(sentencia);
        }
        private DataTable Buscarr(string condicion = "1=1")
        {
            Clssconexion D = new Clssconexion();
            DataTable E = new DataTable();
            string F = $"select* from Verduras where {condicion}";
            D.consultaTablaDirecta(F);
            return E;
        }
    }
}
