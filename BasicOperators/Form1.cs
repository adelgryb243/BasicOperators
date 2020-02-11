using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicOperators
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //wayne Gretzky
            string wayne = "Wayne Gretzky";
            int jersy = 99;


            outputLabel.Text = wayne + " is number " + jersy;
           

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //area of a circle
            double pi;
            pi = 3.14;

            double radius;
            radius = 15.00;

            double area;
            area = pi * (radius * radius);

            outputLabel.Text = "The area of a circle with a radius of " + radius + " is " + area;

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            //carpet

            double length;
            length = 8.50;

            double width;
            width = 6.00;

            double area;
            area = width * length;

            double costPerMetre;
            costPerMetre = 19.95;

            double totalCost;
            totalCost = area * costPerMetre;

            outputLabel.Text = "\nThe area of a room with the dimensions " + length + " by " + width + " is " + area;
            outputLabel.Text += "\n\n The cost to carpet this room at " + costPerMetre + " is " + totalCost;




        }

        private void Button4_Click(object sender, EventArgs e)
        {
            //bill calculator

            double shirt;
            shirt = 12.49;

            double cash;
            cash = 20.00;

            double tax;
            tax = 0.13;

            double subTax;
            subTax = shirt * tax;

            double subTotal;
            subTotal = subTax + shirt;

            double change;
            change = cash - subTotal;

            outputLabel.Text = "Bill of Charge";
            outputLabel.Text += "\n\n Shirt:         " + shirt;
            outputLabel.Text += "\n\n\n Tax:          " + subTax;
            outputLabel.Text += "\n\n\n\nTotal:        " + subTotal;
            outputLabel.Text += "\n\n\n\n\n\n Tendered:        " + cash;
            outputLabel.Text += "\n\n\n\n\n\n\n Change:           " + change;

        }
    }
}
