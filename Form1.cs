using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba_4
{
    public partial class Form1 : Form
    {
        List<Drink> drinks = new List<Drink>();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            drinks.Clear();
            add_Drinks();
            richTextBox2.Text = drinks[0].info();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            drinks.RemoveAt(0);
            richTextBox2.Text = drinks[0].info();
        }

        private void add_Drinks()
        {
            Random random = new Random();
            for (int i = 0; i < 15; i++)
            {
                int drinkType = random.Next(0, 2);
                if (drinkType == 0)
                {
                    drinks.Add(Juice.Generate());
                }
                if (drinkType == 1)
                {
                    Soda soda = new Soda();
                    drinks.Add(soda);
                }
                if (drinkType == 2)
                {
                    Alco alco = new Alco();
                    drinks.Add(alco);
                }
            }
        }
    }
}
