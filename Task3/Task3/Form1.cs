using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private readonly Dictionary<string, decimal> prices = new Dictionary<string, decimal>
        {
            { "Пломбір", 40.00m },
            { "Шоколадне", 45.00m },
            { "Фруктове", 35.00m },
            { "Ванільне", 38.00m }
        };

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            List<string> selectedFlavors = new List<string>();
            decimal unitPriceSum = 0;

            if (chkPlombir.Checked) { selectedFlavors.Add("Пломбір"); unitPriceSum += prices["Пломбір"]; }
            if (chkChocolate.Checked) { selectedFlavors.Add("Шоколадне"); unitPriceSum += prices["Шоколадне"]; }
            if (chkFruit.Checked) { selectedFlavors.Add("Фруктове"); unitPriceSum += prices["Фруктове"]; }
            if (chkVanilla.Checked) { selectedFlavors.Add("Ванільне"); unitPriceSum += prices["Ванільне"]; }

            if (selectedFlavors.Count == 0)
            {
                lblResult.Text = "Будь ласка, оберіть хоча б один сорт!";
                lblResult.ForeColor = Color.Red;
                return;
            }

            int quantity = (int)numQuantity.Value;
            decimal totalBeforeDiscount = unitPriceSum * quantity;
            decimal finalTotal = totalBeforeDiscount;
            string discountText = "";

            if (quantity > 20)
            {
                decimal discount = totalBeforeDiscount * 0.05m;
                finalTotal = totalBeforeDiscount - discount;
                discountText = $"(Знижка 5%: -{discount:F2} грн)";
            }

            lblResult.Text = $"Обрано видів: {selectedFlavors.Count}\nРАЗОМ: {finalTotal:F2} грн\n{discountText}";
            lblResult.ForeColor = Color.DarkGreen;
        }
    }
}
