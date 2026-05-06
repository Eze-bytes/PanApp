using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Servicios;


namespace Presentacion
{
    public partial class BackupsFRM : Form
    {
       
        Usuario usu;
        public BackupsFRM(Usuario U)
        {
            InitializeComponent();
            usu = U;
            restaurarbtn.Enabled = false;
        }
        BitacoraMP bmp = new BitacoraMP();

        public void Cargar_entradas_bitacora()
        {
            grilla_bitacora.DataSource = null;

            grilla_bitacora.DataSource = bmp.Retornar_entradas_bitacora();
            grilla_bitacora_CellClick(null, null);
        }
        Backup Bak = new Backup();
        BitacoraMP Bmp = new BitacoraMP();
        private void crear_backupbtn_Click(object sender, EventArgs e)
        {

            string path;
            SaveFileDialog Crear_bak_dialog = new SaveFileDialog();
            Crear_bak_dialog.InitialDirectory = "c:\\";
            Crear_bak_dialog.Title = "Crear Backup";
            Crear_bak_dialog.CheckFileExists = false;
            Crear_bak_dialog.CheckPathExists = true;
            Crear_bak_dialog.DefaultExt = "xml";
            Crear_bak_dialog.Filter = "Archivos xml (*.xml)|*.xml";
            
            if (Crear_bak_dialog.ShowDialog() == DialogResult.OK)
            {
                path = Crear_bak_dialog.FileName;
                Bak.Crear_backup(path);
                Bitacora Bt = new Bitacora(usu.ID_usuario,usu.Nombre,"Creacion de backup");
                Bt.Ruta = path;
                Bt.Nombre_de_archivo = Path.GetFileName(path);
                Bmp.Agregar_entrada_bitacora(Bt);
                MessageBox.Show("Backup creado correctamente");
                Cargar_entradas_bitacora();
            }
        }

        private void BackupsFRM_Load(object sender, EventArgs e)
        {
            this.Owner.Enabled = false;
            Cargar_entradas_bitacora();
        }

        private void restaurarbtn_Click(object sender, EventArgs e)
        {
            try{
                Bitacora Bt = (Bitacora)grilla_bitacora.SelectedRows[0].DataBoundItem;
                var resultado = MessageBox.Show("¿Confirma la restauracion de la base de datos de nombre " + Bt.Nombre_de_archivo + " ?", "Restaurar",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    Bak.Restaurar_backup(Bt.Ruta);
                    string nombre_archivo = Bt.Nombre_de_archivo;
                    Bt = new Bitacora(usu.ID_usuario,usu.Nombre, "Restauracion de backup");
                    Bt.Ruta = "-";
                    Bt.Nombre_de_archivo = nombre_archivo;
                    Bmp.Agregar_entrada_bitacora(Bt);
                    MessageBox.Show("Se restauro correctamente la base de datos, se reiniciara el programa a la pantalla de autenticación");
                    this.Owner.Visible = false;
                    this.Close();
                    
                    AutenticacionFRM f = new AutenticacionFRM();
                    f.Show();

                }
            }
            
            catch (System.IO.FileNotFoundException) { MessageBox.Show("Error: el archivo de backup fue eliminado o movido, compruebe la ruta del archivo"); }
            catch { MessageBox.Show("Error al restaurar base de datos"); }
        }

        private void grilla_bitacora_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Bitacora bt = (Bitacora)grilla_bitacora.SelectedRows[0].DataBoundItem;
                if (bt.Tipo_de_movimiento == "Creacion de backup") { restaurarbtn.Enabled = true; }
                else { restaurarbtn.Enabled = false; }
            }
            catch { }
        }

        private void BackupsFRM_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Enabled = true;
        }
    }
}
