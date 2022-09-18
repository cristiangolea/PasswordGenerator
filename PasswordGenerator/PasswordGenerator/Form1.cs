using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int len = 8;
            const string DefaultChars = "qwertyuiopasdfghjklzxcvbnm";
            const string UppercaseChars = "QWERTYUIOPASDFGHJKLZXCVBNM";
            const string SpecialChars = "!@#$%^&*()";
            StringBuilder result = new StringBuilder();
            Random rand = new Random();
            while (0<len--)
            {
                if (checkBox1.Checked)
                result.Append(DefaultChars[rand.Next(DefaultChars.Length)]);
            }
            char lower = Convert.ToChar(rand.Next(0,26) + 97);
            char upper = Convert.ToChar(rand.Next(0, 26) + 65);
            char special = Convert.ToChar(rand.Next(0, 10) + 48);

            Console.WriteLine(getRandomLower(rand));
            Console.WriteLine(getRandomUpper(rand));
            Console.WriteLine(getRandomNumber(rand));
            Console.WriteLine(getRandomSymbol(rand));
            Console.WriteLine();
            textBox1.Text = result.ToString();
        }
        public char getRandomLower(Random rnd)
        { 
            return(Convert.ToChar(rnd.Next(0, 26) + 97));
        }
        public char getRandomUpper(Random rnd)
        {
            return (Convert.ToChar(rnd.Next(0, 26) + 65));
        }
        public char getRandomNumber(Random rnd)
        {
            return (Convert.ToChar(rnd.Next(0, 10) + 48));
        }
        public char getRandomSymbol(Random rnd)
        {
            const string Symbols = "!@#$%^&*()[]{}-=+_";
            return (Symbols[rnd.Next(Symbols.Length)]);
        }
    }
}
