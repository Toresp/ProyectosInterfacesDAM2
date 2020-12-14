using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_7___Sambade_Martinez_Miguel
{
    public partial class organizaVideos : Form
    {
        private List<FileInfo> files = new List<FileInfo>();
        FolderBrowserDialog fdb = new FolderBrowserDialog();

        public organizaVideos()
        {
            InitializeComponent();
        }

        private void btnCarpeta_Click(object sender, EventArgs e)//Añade las carpetas al TreeList
        {
            if (fdb.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(fdb.SelectedPath))
            {
                tvFolders.Nodes.Clear();
                lbVideos.Items.Clear();
                files.Clear();
                tvFolders.Nodes.Add(LoadDirectory(new DirectoryInfo(fdb.SelectedPath)));

            }
        }
        private TreeNode LoadDirectory(DirectoryInfo di) //Crea los nodos segun las subcarpetas existentes
        {
            if (!di.Exists)
                return null;
            
            TreeNode Nodos = new TreeNode(di.Name, 0, 0);

            foreach (DirectoryInfo subDir in di.GetDirectories())
            {
                try
                {
                    Nodos.Nodes.Add(LoadDirectory(subDir));
                }
                catch (IOException Ex)
                {
                   
                }
                catch { }
            }

            foreach (FileInfo file in di.GetFiles())
            {
                if (file.Exists)
                {
                    if (file.Extension.Equals(".mp4") || file.Extension.Equals(".avi") || file.Extension.Equals(".mts")
                        || file.Extension.Equals(".mov"))
                    {
                        files.Add(file);
                        lbVideos.Items.Add(new TextBox().Text = file.Name);
                    }
                }
            }
            labCarpeta.Text = di.FullName;
            labCarpeta.Visible = true;
            return Nodos;
        }
        private void btnOrganiza_Click(object sender, EventArgs e)
        { 
            //Crea las carpetas necesarias para organizar los archivos
            int año = Fecha.Value.Year;
            new FileInfo(fdb.SelectedPath+año+"\\").Directory.Create();
            new FileInfo(fdb.SelectedPath + año+"\\1Enero\\").Directory.Create();
            new FileInfo(fdb.SelectedPath + año + "\\2Febrero\\").Directory.Create();
            new FileInfo(fdb.SelectedPath + año + "\\3Marzo\\").Directory.Create();
            new FileInfo(fdb.SelectedPath + año + "\\4Abril\\").Directory.Create();
            new FileInfo(fdb.SelectedPath + año + "\\5Mayo\\").Directory.Create();
            new FileInfo(fdb.SelectedPath + año + "\\6Junio\\").Directory.Create();
            new FileInfo(fdb.SelectedPath + año + "\\7Julio\\").Directory.Create();
            new FileInfo(fdb.SelectedPath + año + "\\8Agosto\\").Directory.Create();
            new FileInfo(fdb.SelectedPath + año + "\\9Septiembre\\").Directory.Create();
            new FileInfo(fdb.SelectedPath + año + "\\10Octubre\\").Directory.Create();
            new FileInfo(fdb.SelectedPath + año + "\\11Noviembre\\").Directory.Create();
            new FileInfo(fdb.SelectedPath + año + "\\12Diciembre\\").Directory.Create();
            //Mueve los archivos segun el año marcado y su mes de creación
            foreach (FileInfo file in files)
            {
            if(file.CreationTime.Year == año)
                {
                    int mes = file.CreationTime.Month;
                    switch(mes){
                        case 1: File.Move(file.FullName, fdb.SelectedPath + año + "\\1Enero\\" + file.Name); break;
                        case 2: File.Move(file.FullName, fdb.SelectedPath + año + "\\2Febrero\\" + file.Name); break;
                        case 3: File.Move(file.FullName, fdb.SelectedPath + año + "\\3Marzo\\" + file.Name); break;
                        case 4: File.Move(file.FullName, fdb.SelectedPath + año + "\\4Abril\\" + file.Name); break;
                        case 5: File.Move(file.FullName, fdb.SelectedPath + año + "\\5Mayo\\" + file.Name); break;
                        case 6: File.Move(file.FullName, fdb.SelectedPath + año + "\\6Junio\\" + file.Name); break;
                        case 7: File.Move(file.FullName, fdb.SelectedPath + año + "\\7Julio\\" + file.Name); break;
                        case 8: File.Move(file.FullName, fdb.SelectedPath + año + "\\8Agosto\\" + file.Name); break;
                        case 9: File.Move(file.FullName, fdb.SelectedPath + año + "\\9Septiembre\\" + file.Name); break;
                        case 10: File.Move(file.FullName, fdb.SelectedPath + año + "\\10Octubre\\" + file.Name); break;
                        case 11: File.Move(file.FullName, fdb.SelectedPath + año + "\\11Noviembre\\"+file.Name); break;
                        case 12: File.Move(file.FullName, fdb.SelectedPath + año + "\\12Diciembre\\" + file.Name); break;
                    }
                }

            }
        }


        private void organizaVideos_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

    }
}
