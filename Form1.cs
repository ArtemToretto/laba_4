﻿using System;
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
        int juiceCount = 0, sodaCount = 0, alcoCount = 0;
        public Form1()
        {
            InitializeComponent();
            countInformation();
            richTextBox2.Text = "Напитки закончились!\nПерезаполните автомат!";
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            drinks.Clear();
            add_Drinks();
            richTextBox2.Text = drinks[0].info();
            showImage();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (drinks.Count==0)
            {
                richTextBox2.Text = "Напитки закончились!\nПерезаполните автомат!";
            }
            else
            {
                if (drinks[0] is Juice)
                {
                    juiceCount--;
                }
                else if (drinks[0] is Soda)
                {
                    sodaCount--;
                }
                else if (drinks[0] is Alco)
                {
                    alcoCount--;
                }
                drinks.RemoveAt(0);
                if (drinks.Count!= 0)
                {
                    richTextBox2.Text = drinks[0].info();
                }
                else
                {
                    richTextBox2.Text = "Напитки закончились!\nПерезаполните автомат!";
                }
                countInformation();
                showImage();
            }
        }

        private void add_Drinks()
        {
            juiceCount = 0;
            sodaCount = 0;
            alcoCount = 0;
            Random random = new Random();
            for (int i = 0; i < 15; i++)
            {
                int drinkType = random.Next(0, 3);
                if (drinkType == 0)
                {
                    drinks.Add(Juice.Generate());
                    juiceCount++;
                }
                if (drinkType == 1)
                {
                    drinks.Add(Soda.Generate());
                    sodaCount++;
                }
                if (drinkType == 2)
                {
                    drinks.Add(Alco.Generate());
                    alcoCount++;
                }
                countInformation();
            }
        }
        private void countInformation()
        {
            String information = $"Количество напитков:\nГазировка: {sodaCount} Сок: {juiceCount} Алкоголь: {alcoCount}";
            richTextBox1.Text = information;
            if (drinks.Count>1)
            {
                richTextBox1.Text += $"\n\n Следующий напиток в очереди: {drinks[1].getDrinkType()}";
            }
            showImage();
        }
        private void showImage()
        {
            if (drinks.Count != 0)
            {
                String drink = drinks[0].getDrinkType();
                switch (drink)
                {
                    case "Водка":
                        pictureBox1.Image = Properties.Resources._1;
                        break;
                    case "Пиво":
                        pictureBox1.Image = Properties.Resources._3;
                        break;
                    case "Вино":
                        pictureBox1.Image = Properties.Resources._2;
                        break;
                    case "CocaCola":
                        pictureBox1.Image = Properties.Resources._4;
                        break;
                    case "Sprite":
                        pictureBox1.Image = Properties.Resources._6;
                        break;
                    case "Pepsi":
                        pictureBox1.Image = Properties.Resources._7;
                        break;
                    case "Fanta":
                        pictureBox1.Image = Properties.Resources._5;
                        break;
                    case "Яблочный сок":
                        pictureBox1.Image = Properties.Resources._8;
                        break;
                    case "Апельсиновый сок":
                        pictureBox1.Image = Properties.Resources._9;
                        break;
                    case "Томатный сок":
                        pictureBox1.Image = Properties.Resources._11;
                        break;
                    case "Банановый сок":
                        pictureBox1.Image = Properties.Resources.banan;
                        break;
                    default:
                        pictureBox1.Image = Properties.Resources.grey_white_background;
                        break;
                }
            }
            else { pictureBox1.Image = Properties.Resources.grey_white_background; }
        }
    }
}
