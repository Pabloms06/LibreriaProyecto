using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LibreriaProyecto
{




    public partial class UserControl1 : UserControl

    {


        private void button1_Click(object sender, EventArgs e)
        {
            List<string> colores = new List<string>();

            colores.Add("red");
            colores.Add("yellow");
            colores.Add("green");
            colores.Add("blue");

            if (textBox1.Text.Equals(colores[0]))
            {
                Console.BackgroundColor = ConsoleColor.Red;
            }

            if (textBox1.Text.Equals(colores[1]))
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
            }

            if (textBox1.Text.Equals(colores[2]))
            {
                Console.BackgroundColor = ConsoleColor.Green;
            }

            if (textBox1.Text.Equals(colores[3]))
            {
                Console.BackgroundColor = ConsoleColor.Blue;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

           
        }

        

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
    }

}



