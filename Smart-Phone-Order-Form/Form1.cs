using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1ExamWalkerJessica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Programmer: Jessica Walker
        //Purpose: This program calculates the total price of 3 different cell phone models with tax
        //Assignment: Mid-term exam
        //Updated: October 15, 2021

        //Named constants...price per phone and NC sales tax
        const decimal samsungPrice = 1100m;
        const decimal iphonePrice = 1200m;
        const decimal motorolaPrice = 1300m;
        const decimal NC_Sales_Tax = .07m;

        //If the checkbox for the Samsung phone is checked: display the Unit Price, deselect the other models/checkboxes, and clear the Quantity and Order Label
        private void samsungCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (samsungCheckbox.Checked == true)
            {
                priceTextbox.Text = samsungPrice.ToString("c");
                iphoneCheckbox.Checked =! true;
                motorolaCheckbox.Checked =! true;
            }
            else
                quantityTextbox.Text = "";
                orderTextbox.Text = "";
        }

        //If the checkbox for the iPhone phone is checked: display the Unit Price, deselect the other models/checkboxes, and clear the Quantity and Order Label
        private void iphoneCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (iphoneCheckbox.Checked)
            {
                priceTextbox.Text = iphonePrice.ToString("c");
                samsungCheckbox.Checked =! true;
                motorolaCheckbox.Checked =! true;
            }
            else
                quantityTextbox.Text = "";
                orderTextbox.Text = "";
        }

        //If the checkbox for the Motorola phone is checked: display the Unit Price, deselect the other models/checkboxes, and clear the Quantity and Order Label
        private void motorolaCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (motorolaCheckbox.Checked)
            {
                priceTextbox.Text = motorolaPrice.ToString("c");
                iphoneCheckbox.Checked =! true;
                samsungCheckbox.Checked =! true;
            }
            else
                quantityTextbox.Text = "";
                orderTextbox.Text = "";
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //Variables
            decimal quantity, beforeTax, totalSalesTax, orderTotal;

            quantity = decimal.Parse(quantityTextbox.Text);

            //Calculate the price per Samsung S20 phone with NC sales tax
            if (samsungCheckbox.Checked)
            {
                if (quantity > 0 && quantityTextbox != null)
                {
                    beforeTax = quantity * samsungPrice;
                    totalSalesTax = beforeTax * NC_Sales_Tax;
                    orderTotal = totalSalesTax + beforeTax;
                    orderTextbox.Text = "The total for your Samsung S20 order, with tax, is " + orderTotal.ToString("c") + ".";
                }
            }

            else

            //Calculate the price per iPhone 11 with NC sales tax
            if (iphoneCheckbox.Checked)
            {
                if (quantity > 0 && quantityTextbox != null)
                {
                    beforeTax = quantity * iphonePrice;
                    totalSalesTax = beforeTax * NC_Sales_Tax;
                    orderTotal = totalSalesTax + beforeTax;
                    orderTextbox.Text = "The total for your iPhone 11 order, with tax, is " + orderTotal.ToString("c") + ".";
                }
            }

            else

            //Calculate the price per Motorola Razr with NC sales tax
            if (motorolaCheckbox.Checked)
            {
                if (quantity > 0 && quantityTextbox != null)
                {
                    beforeTax = quantity * motorolaPrice;
                    totalSalesTax = beforeTax * NC_Sales_Tax;
                    orderTotal = totalSalesTax + beforeTax;
                    orderTextbox.Text = "The total for your Motorola Razr order, with tax, is " + orderTotal.ToString("c") + ".";
                }
            }
        }
    }
}
