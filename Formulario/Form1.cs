using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;


namespace Formulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            


            string Nombres = textBoxNombre.Text;
            string Apellidos = textBoxApellidos.Text;
            string Edad = textBoxEdad.Text;
            string Estatura = textBoxEstatura.Text;
            string Telefono = textBoxTelefono.Text;
            string Genero = "";
            if (rbHombre.Checked)
            {
                Genero = "Hombre";
            }
            else if (rbMujer.Checked) 
            {
                Genero = "Mujer";
            }
            string datos = $"Nombres: {Nombres}\r\nApellidos: {Apellidos}\r\nTelefono: {Telefono} kg\r\nEstatura: {Estatura} cm\r\nEdad: {Edad} años\r\nGénero: {Genero}";
            string rutaArchivo = "C:/Users/JoseB/Documents/datos.txt";
            File.WriteAllText(rutaArchivo,datos);

            bool archivoExiste = File.Exists(rutaArchivo);
            if (archivoExiste == false)

            {
                File.WriteAllText(rutaArchivo, datos);
            }
            else
            {
                using (StreamWriter writer = new StreamWriter(rutaArchivo ,true))
                {
                    if (archivoExiste)
                    {
                        writer.WriteLine();
                    }
                    writer.WriteLine(datos);
                }
                    
            }
        }
        
       
         
        
        
        private void button2_Click(object sender, EventArgs e)
        {
            textBoxNombre.Clear();
            textBoxApellidos.Clear();
            textBoxEstatura.Clear();
            textBoxTelefono.Clear();
            textBoxEdad.Clear();

        }

    }
}
