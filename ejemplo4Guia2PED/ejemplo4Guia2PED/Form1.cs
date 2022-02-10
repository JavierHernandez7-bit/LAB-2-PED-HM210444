using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo4Guia2PED
{
    public partial class Form1 : Form
    {
        int total = 0; //cantidad de elementos en cola
        Random numeros = new Random(); //los valores serán random
        
        public Form1()
        {
            InitializeComponent();
            txtn1.Text = Convert.ToString(total);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            if (total == 5)
            { 
                MessageBox.Show("La cola está llena"); 
            }
            else
            {
                total++; //incrementamos cantidad de elementos en cola
                txtn1.Text = Convert.ToString(total);
                switch (total)
                {
                    case 1:
                        txtn1.Text = Convert.ToString(numeros.Next(1, 99));
                        txtn1.Visible = true;
                        break;
                    case 2:
                        txtn2.Text = Convert.ToString(numeros.Next(1, 99));
                        txtn2.Visible = true;
                        break;
                    case 3:
                        txtn3.Text = Convert.ToString(numeros.Next(1, 99));
                        txtn3.Visible = true;
                        break;
                    case 4:
                        txtn4.Text = Convert.ToString(numeros.Next(1, 99));
                        txtn4.Visible = true;
                        break;
                    case 5:
                        txtn5.Text = Convert.ToString(numeros.Next(1, 99));
                        txtn5.Visible = true;
                        break;
                    default:
                        MessageBox.Show("Error en la cola");
                        break;
                }
                timer1.Enabled=true;

            }
        }

        private void btnextraer_Click(object sender, EventArgs e)
        {
            if (total==0)
                { MessageBox.Show("Cola vacia, no puede eliminar datos"); }
            else
            {
                txtn1.Text=txtn2.Text;
                txtn2.Text=txtn3.Text;
                txtn3.Text=txtn4.Text;
                txtn4.Text=txtn5.Text;

                if (total == 1) txtn1.Visible = false;
                if (total == 2) txtn2.Visible = false;
                if (total == 3) txtn3.Visible = false;
                if (total == 4) txtn4.Visible = false;
                if (total == 5) txtn5.Visible = false;
                total--;
                txtn1.Text = Convert.ToString(total);

                timer2.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            btningresar.Enabled = false;
            if (total == 1)
            {
                pbox1.Left=pbox1.Left + 5;
            if (pbox1.Left >= 300) timer1.Enabled = false;
            }
            if (total == 2)                
            {   pictureBox2.Left=pictureBox2.Left + 5;                     
                if (pictureBox2.Left >= 250) timer1.Enabled = false;
            }
            if (total == 3)
            {
                pictureBox3.Left = pictureBox3.Left + 5;                   
                if (pictureBox3.Left >= 200) timer1.Enabled = false;
            }
            if (total == 4)
            {
                pictureBox4.Left = pictureBox4.Left + 5;
                if (pictureBox4.Left >= 150) timer1.Enabled = false;
            }
            if (total == 5)
            {
                pictureBox5.Left = pictureBox5.Left + 5;
                if (pictureBox5.Left >= 150) timer1.Enabled = false;
            }
            if (timer1.Enabled==false) btningresar.Enabled =true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            btnextraer.Enabled = false; //deshabilitamos extraer 
            pbox1.Left = pbox1.Left + 5; //movemos la imagen a la derecha
            if (pbox1.Left >= 600)
            {
                pbox1.Left = 300; //regresamos el primer picturebox a la primera posición
                if (total == 4) pictureBox5.Left = -50; //escondo el picturebox5
                if (total == 3) pictureBox4.Left = -50; //escondo el picturebox4
                if (total == 2) pictureBox4.Left = -50;  
                if (total == 1) pictureBox2.Left = -50; //escondo el picturebox2
                if (total == 0) pbox1.Left = -50; //escondo el picturebox1
                                                  //al esconderse a la derecha              
                timer2.Enabled=false; //deshabilito timer 
            }
            if (timer2.Enabled=false) btnextraer.Enabled = true; //habilito botón de nuevo 3D
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
