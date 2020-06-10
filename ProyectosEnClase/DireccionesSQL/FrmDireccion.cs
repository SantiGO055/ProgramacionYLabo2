using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DireccionesSQL
{
    public partial class FrmDireccion : Form
    {
        //las conexiones se realizan en una clase aparte
        SqlConnection cn;
        SqlCommand cm;
        List<KeyValuePair<decimal, string>> provincias;
        List<Localidad> localidades;

        public FrmDireccion()
        {

            InitializeComponent();
            provincias = new List<KeyValuePair<decimal, string>>();
            cn = new SqlConnection(@"Data Source = LCCTECNMJ669C42\SQLEXPRESS; Initial Catalog = Argentina; Integrated Security = True;");
            localidades = new List<Localidad>();
            cm = new SqlCommand();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarDirecciones();
            //si tengo conexion a otra base uso esto de aca abajo, puedo usar constructor de SqlConnection();
            //cn.ConnectionString = @"Data Source = LCCTECNMJ669C42\SQLEXPRESS; Initial Catalog = Argentina; Integrated Security = True;";

            try
            {
                cn.Open();
                
                cm.Connection = cn;
                cm.CommandText = "select * from Provincia";
                SqlDataReader sqlDr = cm.ExecuteReader();

                
                while (sqlDr.Read())
                {
                    //MessageBox.Show(sqlDr[0].ToString());
                    //MessageBox.Show(sqlDr[1].ToString());


                    //provincias.Add((decimal)sqlDr[0],sqlDr[1].ToString());
                    provincias.Add(new KeyValuePair<decimal, string>(decimal.Parse(sqlDr[0].ToString()), sqlDr[1].ToString()));

                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }
            cmbIDProvincia.DataSource = provincias;
        }



        private void cmbIDProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                localidades.Clear();
                cn.Open();
                cm.Connection = cn;
                cm.CommandText = "select * from localidad where idProvincia = " + ((KeyValuePair<decimal, string>)cmbIDProvincia.SelectedItem).Key;
                SqlDataReader dr = cm.ExecuteReader();

                while (dr.Read())
                {
                    localidades.Add(new Localidad((decimal)dr[0], (decimal)dr[1], dr[2].ToString()));
                }
                //
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }
            cmbLocalidades.DataSource = null;
            cmbLocalidades.DataSource = localidades;
        }

        /// <summary>
        /// lleno el datagrid view con las direcciones cargadas en la bd
        /// </summary>
        public void CargarDirecciones()
        {
            try
            {
                cn.Open();
                cm.Connection = cn;
                cm.CommandText = "select * from domicilio";
                SqlDataReader dr = cm.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);

                dataGridView1.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }

        }

        /// <summary>
        /// Doy de alta un domicilio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Direccion direcciones = new Direccion();

            direcciones.Calle = txtCalle.Text;
            direcciones.Numero = int.Parse(txtNumero.Text);
            direcciones.IDLocalidad = ((Localidad)cmbLocalidades.SelectedItem).ID;
            direcciones.Departamento = txtDepartamento.Text;
            direcciones.Piso = int.Parse(txtPiso.Text);

            try
            {
                localidades.Clear();
                cn.Open();
                cm.Connection = cn;
                
                cm.CommandText = "insert into domicilio (calle, numero, idLocalidad, piso, departamento) values (@calle,@numero,@idLocalidad,@piso,@departamento)";
                cm.Parameters.Add(new SqlParameter("calle", direcciones.Calle));
                cm.Parameters.Add(new SqlParameter("numero", direcciones.Numero));
                cm.Parameters.Add(new SqlParameter("idLocalidad", direcciones.IDLocalidad));
                cm.Parameters.Add(new SqlParameter("piso", direcciones.Piso));
                cm.Parameters.Add(new SqlParameter("departamento", direcciones.Departamento));

                int retorno = cm.ExecuteNonQuery();

                if (retorno != 1)
                {
                    MessageBox.Show("No se insertaron datos");
                }
                else
                {
                    MessageBox.Show("Limpiar datos");
                }

                //SqlDataReader dr = cm.ExecuteReader();

                //while (dr.Read())
                //{
                //    localidades.Add(new Localidad((decimal)dr[0], (decimal)dr[1], dr[2].ToString()));
                //}
                //

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }
            CargarDirecciones();
        }
    }
}
