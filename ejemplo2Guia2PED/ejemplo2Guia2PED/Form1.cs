using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo2Guia2PED
{
    public partial class Form1 : Form
    {
        Random random = new Random(); //crear un objeto random
                                      //Utilizamos una lista de C# con elementos de tipo string
                                      //los valores de la lista ya estarán predeterminados.
        List<string> iconos = new List<string>()
        {
             "!", "!", "N","N", "k","k",
             "b","b","v","v","w","w","z","z"
        };
        //Primer label al que se le ha dado click
        Label primerclick = null;
        //Segundo label al que se le ha dado click
        Label segundoclick = null;

        private void Asignar()
        { //realiza esta acción para cada label
            foreach (Control control in tablelayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    int numeroRandom = random.Next(iconos.Count);
                    iconLabel.Text = iconos[numeroRandom];
                    iconos.RemoveAt(numeroRandom);
                }
                iconLabel.ForeColor = iconLabel.BackColor;
            }
        }

        public Form1()
        {
            InitializeComponent();
            Asignar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            timer1.Stop(); //detener timer
            primerclick.ForeColor = primerclick.BackColor; //color fondo click 1
            segundoclick.ForeColor = segundoclick.BackColor; //color fondo click 2
            primerclick = null; //retorna el primer click a null
            segundoclick = null; //retorna el segundo click a null

        }
        private void VerificaGana()
        {
        }
        private void label1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true) //si el timer está habilitado
                return;
            Label clickedLabel = sender as Label; //registra si el label ha sido
                                                  //seleccionado
                                                  //si ese label en concreto ha sido seleccionado ( no está nulo)
            if (clickedLabel != null)
            { //el forecolor será negro
                if (clickedLabel.ForeColor == Color.Black)
                    return;
                VerificaGana(); //1lama al método de Verificar Ganador
                if (primerclick == null) //si no ha habido un click antes
                { //se convierte en primer elemento clickeado
                    primerclick = clickedLabel;
                    //el color de forecolor en negro

                    primerclick.ForeColor = Color.Black;
                    //retorna
                    return;
                }
                //si ya hay algo en primer click entonces será el segundo
                segundoclick = clickedLabel;
                //color en negro
                segundoclick.ForeColor = Color.Black;
                //elemento clickeado es segundo
                if (primerclick.Text == segundoclick.Text)
                {
                    primerclick = null;
                    segundoclick = null;

                    return;
                }
                timer1.Start();
                
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true) //si el timer está habilitado
                return;
            Label clickedLabel = sender as Label; //registra si el label ha sido
                                                  //seleccionado
                                                  //si ese label en concreto ha sido seleccionado ( no está nulo)
            if (clickedLabel != null)
            { //el forecolor será negro
                if (clickedLabel.ForeColor == Color.Black)
                    return;
                VerificaGana(); //1lama al método de Verificar Ganador
                if (primerclick == null) //si no ha habido un click antes
                { //se convierte en primer elemento clickeado
                    primerclick = clickedLabel;
                    //el color de forecolor en negro

                    primerclick.ForeColor = Color.Black;
                    //retorna
                    return;
                }//si ya hay algo en primer click entonces será el segundo
                segundoclick = clickedLabel;
                //color en negro
                segundoclick.ForeColor = Color.Black;
                //elemento clickeado es segundo
                if (primerclick.Text == segundoclick.Text)
                {
                    primerclick = null;
                    segundoclick = null;

                    return;
                }
                timer1.Start();

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true) //si el timer está habilitado
                return;
            Label clickedLabel = sender as Label; //registra si el label ha sido
                                                  //seleccionado
                                                  //si ese label en concreto ha sido seleccionado ( no está nulo)
            if (clickedLabel != null)
            { //el forecolor será negro
                if (clickedLabel.ForeColor == Color.Black)
                    return;
                VerificaGana(); //1lama al método de Verificar Ganador
                if (primerclick == null) //si no ha habido un click antes
                { //se convierte en primer elemento clickeado
                    primerclick = clickedLabel;
                    //el color de forecolor en negro

                    primerclick.ForeColor = Color.Black;
                    //retorna
                    return;
                }//si ya hay algo en primer click entonces será el segundo
                segundoclick = clickedLabel;
                //color en negro
                segundoclick.ForeColor = Color.Black;
                //elemento clickeado es segundo
                if (primerclick.Text == segundoclick.Text)
                {
                    primerclick = null;
                    segundoclick = null;

                    return;
                }
                timer1.Start();

            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true) //si el timer está habilitado
                return;
            Label clickedLabel = sender as Label; //registra si el label ha sido
                                                  //seleccionado
                                                  //si ese label en concreto ha sido seleccionado ( no está nulo)
            if (clickedLabel != null)
            { //el forecolor será negro
                if (clickedLabel.ForeColor == Color.Black)
                    return;
                VerificaGana(); //1lama al método de Verificar Ganador
                if (primerclick == null) //si no ha habido un click antes
                { //se convierte en primer elemento clickeado
                    primerclick = clickedLabel;
                    //el color de forecolor en negro

                    primerclick.ForeColor = Color.Black;
                    //retorna
                    return;
                }//si ya hay algo en primer click entonces será el segundo
                segundoclick = clickedLabel;
                //color en negro
                segundoclick.ForeColor = Color.Black;
                //elemento clickeado es segundo
                if (primerclick.Text == segundoclick.Text)
                {
                    primerclick = null;
                    segundoclick = null;

                    return;
                }
                timer1.Start();

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true) //si el timer está habilitado
                return;
            Label clickedLabel = sender as Label; //registra si el label ha sido
                                                  //seleccionado
                                                  //si ese label en concreto ha sido seleccionado ( no está nulo)
            if (clickedLabel != null)
            { //el forecolor será negro
                if (clickedLabel.ForeColor == Color.Black)
                    return;
                VerificaGana(); //1lama al método de Verificar Ganador
                if (primerclick == null) //si no ha habido un click antes
                { //se convierte en primer elemento clickeado
                    primerclick = clickedLabel;
                    //el color de forecolor en negro

                    primerclick.ForeColor = Color.Black;
                    //retorna
                    return;
                }//si ya hay algo en primer click entonces será el segundo
                segundoclick = clickedLabel;
                //color en negro
                segundoclick.ForeColor = Color.Black;
                //elemento clickeado es segundo
                if (primerclick.Text == segundoclick.Text)
                {
                    primerclick = null;
                    segundoclick = null;

                    return;
                }
                timer1.Start();

            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true) //si el timer está habilitado
                return;
            Label clickedLabel = sender as Label; //registra si el label ha sido
                                                  //seleccionado
                                                  //si ese label en concreto ha sido seleccionado ( no está nulo)
            if (clickedLabel != null)
            { //el forecolor será negro
                if (clickedLabel.ForeColor == Color.Black)
                    return;
                VerificaGana(); //1lama al método de Verificar Ganador
                if (primerclick == null) //si no ha habido un click antes
                { //se convierte en primer elemento clickeado
                    primerclick = clickedLabel;
                    //el color de forecolor en negro

                    primerclick.ForeColor = Color.Black;
                    //retorna
                    return;
                }//si ya hay algo en primer click entonces será el segundo
                segundoclick = clickedLabel;
                //color en negro
                segundoclick.ForeColor = Color.Black;
                //elemento clickeado es segundo
                if (primerclick.Text == segundoclick.Text)
                {
                    primerclick = null;
                    segundoclick = null;

                    return;
                }
                timer1.Start();

            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true) //si el timer está habilitado
                return;
            Label clickedLabel = sender as Label; //registra si el label ha sido
                                                  //seleccionado
                                                  //si ese label en concreto ha sido seleccionado ( no está nulo)
            if (clickedLabel != null)
            { //el forecolor será negro
                if (clickedLabel.ForeColor == Color.Black)
                    return;
                VerificaGana(); //1lama al método de Verificar Ganador
                if (primerclick == null) //si no ha habido un click antes
                { //se convierte en primer elemento clickeado
                    primerclick = clickedLabel;
                    //el color de forecolor en negro

                    primerclick.ForeColor = Color.Black;
                    //retorna
                    return;
                }//si ya hay algo en primer click entonces será el segundo
                segundoclick = clickedLabel;
                //color en negro
                segundoclick.ForeColor = Color.Black;
                //elemento clickeado es segundo
                if (primerclick.Text == segundoclick.Text)
                {
                    primerclick = null;
                    segundoclick = null;

                    return;
                }
                timer1.Start();

            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true) //si el timer está habilitado
                return;
            Label clickedLabel = sender as Label; //registra si el label ha sido
                                                  //seleccionado
                                                  //si ese label en concreto ha sido seleccionado ( no está nulo)
            if (clickedLabel != null)
            { //el forecolor será negro
                if (clickedLabel.ForeColor == Color.Black)
                    return;
                VerificaGana(); //1lama al método de Verificar Ganador
                if (primerclick == null) //si no ha habido un click antes
                { //se convierte en primer elemento clickeado
                    primerclick = clickedLabel;
                    //el color de forecolor en negro

                    primerclick.ForeColor = Color.Black;
                    //retorna
                    return;
                }//si ya hay algo en primer click entonces será el segundo
                segundoclick = clickedLabel;
                //color en negro
                segundoclick.ForeColor = Color.Black;
                //elemento clickeado es segundo
                if (primerclick.Text == segundoclick.Text)
                {
                    primerclick = null;
                    segundoclick = null;

                    return;
                }
                timer1.Start();

            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true) //si el timer está habilitado
                return;
            Label clickedLabel = sender as Label; //registra si el label ha sido
                                                  //seleccionado
                                                  //si ese label en concreto ha sido seleccionado ( no está nulo)
            if (clickedLabel != null)
            { //el forecolor será negro
                if (clickedLabel.ForeColor == Color.Black)
                    return;
                VerificaGana(); //1lama al método de Verificar Ganador
                if (primerclick == null) //si no ha habido un click antes
                { //se convierte en primer elemento clickeado
                    primerclick = clickedLabel;
                    //el color de forecolor en negro

                    primerclick.ForeColor = Color.Black;
                    //retorna
                    return;
                }//si ya hay algo en primer click entonces será el segundo
                segundoclick = clickedLabel;
                //color en negro
                segundoclick.ForeColor = Color.Black;
                //elemento clickeado es segundo
                if (primerclick.Text == segundoclick.Text)
                {
                    primerclick = null;
                    segundoclick = null;

                    return;
                }
                timer1.Start();

            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true) //si el timer está habilitado
                return;
            Label clickedLabel = sender as Label; //registra si el label ha sido
                                                  //seleccionado
                                                  //si ese label en concreto ha sido seleccionado ( no está nulo)
            if (clickedLabel != null)
            { //el forecolor será negro
                if (clickedLabel.ForeColor == Color.Black)
                    return;
                VerificaGana(); //1lama al método de Verificar Ganador
                if (primerclick == null) //si no ha habido un click antes
                { //se convierte en primer elemento clickeado
                    primerclick = clickedLabel;
                    //el color de forecolor en negro

                    primerclick.ForeColor = Color.Black;
                    //retorna
                    return;
                }//si ya hay algo en primer click entonces será el segundo
                segundoclick = clickedLabel;
                //color en negro
                segundoclick.ForeColor = Color.Black;
                //elemento clickeado es segundo
                if (primerclick.Text == segundoclick.Text)
                {
                    primerclick = null;
                    segundoclick = null;

                    return;
                }
                timer1.Start();

            }
        }

        private void label11_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true) //si el timer está habilitado
                return;
            Label clickedLabel = sender as Label; //registra si el label ha sido
                                                  //seleccionado
                                                  //si ese label en concreto ha sido seleccionado ( no está nulo)
            if (clickedLabel != null)
            { //el forecolor será negro
                if (clickedLabel.ForeColor == Color.Black)
                    return;
                VerificaGana(); //1lama al método de Verificar Ganador
                if (primerclick == null) //si no ha habido un click antes
                { //se convierte en primer elemento clickeado
                    primerclick = clickedLabel;
                    //el color de forecolor en negro

                    primerclick.ForeColor = Color.Black;
                    //retorna
                    return;
                }//si ya hay algo en primer click entonces será el segundo
                segundoclick = clickedLabel;
                //color en negro
                segundoclick.ForeColor = Color.Black;
                //elemento clickeado es segundo
                if (primerclick.Text == segundoclick.Text)
                {
                    primerclick = null;
                    segundoclick = null;

                    return;
                }
                timer1.Start();

            }
        }

        private void label12_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true) //si el timer está habilitado
                return;
            Label clickedLabel = sender as Label; //registra si el label ha sido
                                                  //seleccionado
                                                  //si ese label en concreto ha sido seleccionado ( no está nulo)
            if (clickedLabel != null)
            { //el forecolor será negro
                if (clickedLabel.ForeColor == Color.Black)
                    return;
                VerificaGana(); //1lama al método de Verificar Ganador
                if (primerclick == null) //si no ha habido un click antes
                { //se convierte en primer elemento clickeado
                    primerclick = clickedLabel;
                    //el color de forecolor en negro

                    primerclick.ForeColor = Color.Black;
                    //retorna
                    return;
                }//si ya hay algo en primer click entonces será el segundo
                segundoclick = clickedLabel;
                //color en negro
                segundoclick.ForeColor = Color.Black;
                //elemento clickeado es segundo
                if (primerclick.Text == segundoclick.Text)
                {
                    primerclick = null;
                    segundoclick = null;

                    return;
                }
                timer1.Start();

            }
        }

        private void label13_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true) //si el timer está habilitado
                return;
            Label clickedLabel = sender as Label; //registra si el label ha sido
                                                  //seleccionado
                                                  //si ese label en concreto ha sido seleccionado ( no está nulo)
            if (clickedLabel != null)
            { //el forecolor será negro
                if (clickedLabel.ForeColor == Color.Black)
                    return;
                VerificaGana(); //1lama al método de Verificar Ganador
                if (primerclick == null) //si no ha habido un click antes
                { //se convierte en primer elemento clickeado
                    primerclick = clickedLabel;
                    //el color de forecolor en negro

                    primerclick.ForeColor = Color.Black;
                    //retorna
                    return;
                }//si ya hay algo en primer click entonces será el segundo
                segundoclick = clickedLabel;
                //color en negro
                segundoclick.ForeColor = Color.Black;
                //elemento clickeado es segundo
                if (primerclick.Text == segundoclick.Text)
                {
                    primerclick = null;
                    segundoclick = null;

                    return;
                }
                timer1.Start();

            }
        }

        private void label14_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true) //si el timer está habilitado
                return;
            Label clickedLabel = sender as Label; //registra si el label ha sido
                                                  //seleccionado
                                                  //si ese label en concreto ha sido seleccionado ( no está nulo)
            if (clickedLabel != null)
            { //el forecolor será negro
                if (clickedLabel.ForeColor == Color.Black)
                    return;
                VerificaGana(); //1lama al método de Verificar Ganador
                if (primerclick == null) //si no ha habido un click antes
                { //se convierte en primer elemento clickeado
                    primerclick = clickedLabel;
                    //el color de forecolor en negro

                    primerclick.ForeColor = Color.Black;
                    //retorna
                    return;
                }//si ya hay algo en primer click entonces será el segundo
                segundoclick = clickedLabel;
                //color en negro
                segundoclick.ForeColor = Color.Black;
                //elemento clickeado es segundo
                if (primerclick.Text == segundoclick.Text)
                {
                    primerclick = null;
                    segundoclick = null;

                    return;
                }
                timer1.Start();

            }
        }

        private void label15_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true) //si el timer está habilitado
                return;
            Label clickedLabel = sender as Label; //registra si el label ha sido
                                                  //seleccionado
                                                  //si ese label en concreto ha sido seleccionado ( no está nulo)
            if (clickedLabel != null)
            { //el forecolor será negro
                if (clickedLabel.ForeColor == Color.Black)
                    return;
                VerificaGana(); //1lama al método de Verificar Ganador
                if (primerclick == null) //si no ha habido un click antes
                { //se convierte en primer elemento clickeado
                    primerclick = clickedLabel;
                    //el color de forecolor en negro

                    primerclick.ForeColor = Color.Black;
                    //retorna
                    return;
                }//si ya hay algo en primer click entonces será el segundo
                segundoclick = clickedLabel;
                //color en negro
                segundoclick.ForeColor = Color.Black;
                //elemento clickeado es segundo
                if (primerclick.Text == segundoclick.Text)
                {
                    primerclick = null;
                    segundoclick = null;

                    return;
                }
                timer1.Start();

            }
        }

        private void label16_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true) //si el timer está habilitado
                return;
            Label clickedLabel = sender as Label; //registra si el label ha sido
                                                  //seleccionado
                                                  //si ese label en concreto ha sido seleccionado ( no está nulo)
            if (clickedLabel != null)
            { //el forecolor será negro
                if (clickedLabel.ForeColor == Color.Black)
                    return;
                VerificaGana(); //1lama al método de Verificar Ganador
                if (primerclick == null) //si no ha habido un click antes
                { //se convierte en primer elemento clickeado
                    primerclick = clickedLabel;
                    //el color de forecolor en negro

                    primerclick.ForeColor = Color.Black;
                    //retorna
                    return;
                }//si ya hay algo en primer click entonces será el segundo
                segundoclick = clickedLabel;
                //color en negro
                segundoclick.ForeColor = Color.Black;
                //elemento clickeado es segundo
                if (primerclick.Text == segundoclick.Text)
                {
                    primerclick = null;
                    segundoclick = null;

                    return;
                }
                timer1.Start();

            }
        }
    }    
}