using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UitwerkingToetsFundamentals
{
    public partial class CashRegisterForm : Form
    {
        decimal balance;

        decimal totalPrice;
        decimal change;

        string[] gamesToBeSold; // Games in de bestelling
        decimal[] pricesForGamesToBeSold; // De prijzen van die games

        public CashRegisterForm()
        {
            InitializeComponent();

            receiptListBox.HorizontalScrollbar = true;

            balance = 1000;

            UpdateBalanceLabel();
        }

        private void calculateTotalButton_Click(object sender, EventArgs e)
        {
            totalPrice = 0;

            if (bagCheckBox.Checked)
            {
                totalPrice += 0.15M;
            }
            else
            {
                totalPrice += 0;
            }

            // Check if any games have been given to us by the inventory
            if (gamesToBeSold != null)
            {
                for (int i = 0; i < pricesForGamesToBeSold.Length; i++)
                {
                    // Opdracht 4: Tel hier de prijs van de game bij het totaalbedrag op
                }

                // Round the price to two decimals
                totalPrice = RoundToTwoDecimals(totalPrice);


                // Set the price without taxes on the label
                priceNoTaxResultLabel.Text = totalPrice.ToString();

                // Add taxes (BTW) to the price
                decimal withTax = GetPriceWithTax(totalPrice);

                totalPriceResultLabel.Text = withTax.ToString();
                
                UpdateChangeLabel();
            }
            else
            {
                MessageBox.Show("Voeg spellen toe aan de bestelling!");
            }

            change = GetChange(paidAmountNumericUpDown.Value, GetPriceWithTax(totalPrice));

            UpdateChangeLabel();
        }

        private void inventoryButton_Click(object sender, EventArgs e)
        {
            GameInventoryForm form = new GameInventoryForm();
            form.ShowDialog();

            gamesToBeSold = form.GamesToSell;
            pricesForGamesToBeSold = form.PricesOfGamesToSell;

            // Show the games in the receipt listbox, with their prices
            for (int i = 0; i < gamesToBeSold.Length; i++)
            {
                // Opdracht 3: Laat in de receiptListBox de game incl prijs zien op deze manier: 1 keer GAME_NAAM_HIER voor €PRIJS_HIER

                //ListViewItem item = receiptListBox.Items[i];
                //int index = (int)item.Tag;

                //GamesToSell[i] = inventoryGames[index];
                //PricesOfGamesToSell[i] = inventoryPrices[index];
                //snap ik niet !!!!! 
            }

            inventoryButton.Enabled = false;
        }

        private void completeSaleButton_Click(object sender, EventArgs e)
        {
            decimal priceWithTax = GetPriceWithTax(totalPrice);

            if (change < 0)
            {
                MessageBox.Show("Klant moet nog €" + change + " Betalen");
            }
            else if (change > 0) 
            {
                MessageBox.Show("Klant krijgt nog €" + change + " terug");
            }
            else
            { 

            // Add the total price to the history
            calculateTotalNumber.Items.Add(string.Format("€{0}", priceWithTax));

            // Add the money to our balance
            balance += priceWithTax;
            UpdateBalanceLabel();

            // Reset all controls and values
            receiptListBox.Items.Clear();

            totalPrice = 0;
            change = 0;

            paidAmountNumericUpDown.Value = 0;
            totalPriceResultLabel.Text = "0.00";
            priceNoTaxResultLabel.Text = "0.00";
            changeResultLabel.Text = "0.00";
            inventoryButton.Enabled = true;

            }
        }

        private decimal RoundToTwoDecimals(decimal amount)
        {
            // The decimal.Round method with amount, 2 and MidpointRounding.AwayFromZero as parameters makes the number appear like:
            // 1.00 even if it's 1.
            return decimal.Round(amount, 2, MidpointRounding.AwayFromZero);
        }

        // 21% on top of the price (100%)
        private decimal GetPriceWithTax(decimal price)
        {
            // Opdracht 2: Schrijf hier een berekening die het bedrag teruggeeft + 21% BTW.
            totalPrice = (price / 100) * 121;
            // Opdracht 2a: Rond dat bedrag af op 2 decimalen met de RoundToTwoDecimals methode
            RoundToTwoDecimals(totalPrice);
            return totalPrice;
        }

        private decimal GetChange(decimal paid, decimal cost)
        {
            // Opdracht 1: Schrijf hier de berekening die de juiste hoeveelheid wisselgeld teruggeeft.
            change = paid - cost;
            return change;
        }

        private void UpdateChangeLabel()
        {
            changeResultLabel.Text = change.ToString();
        }

        private void UpdateBalanceLabel()
        {
            // Opdracht 8: De hoeveelheid balans wordt niet geupdatet! Zorg dat dit wel gebeurt en maak gebruik van de RoundToTwoDecimals methode om het getal af te ronden.
            balance += 1000M;
            balanceResultLabel.Text = RoundToTwoDecimals(balance).ToString();
        }

        private void completeBuyInButton_Click(object sender, EventArgs e)
        {
            // Opdracht 9: Wanneer bij het inkopen geen getal ingevoerd wordt crasht de applicatie! Vang dit probleem op.
            try
            {
                decimal buyInAmount = decimal.Parse(buyInAmountTextBox.Text);

                // Opdracht 10: Als het inkopen van een spel zou resulteren in een negatieve balans moet dit voorkomen worden.
                if (buyInAmount > balance)
                {
                    MessageBox.Show("Niet genoeg geld om één spel in tekopen");
                }
                else if (lightDamageRadioButton.Checked && int.Parse(buyInAmountTextBox.Text) > 25)
                {
                    MessageBox.Show("lichte beschadigde spellen kopen wij niet meer dan 25 euro in");
                }
                else if (damagedRadioButton.Checked && int.Parse(buyInAmountTextBox.Text) > 5)
                {
                    MessageBox.Show("beschadigde spellen kopen wij niet meer dan 5 euro in");
                }
                else if (brokenRadioButton.Checked && int.Parse(buyInAmountTextBox.Text) > 1)
                {
                    MessageBox.Show("Kapote spellen kopen wij niet meer dan 1 euro in");
                }
                else
                {

                    balance -= buyInAmount;
                    UpdateBalanceLabel();

                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Geen inkoop waarde ingevoert");
            }
        }

        private void paidAmountNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            change = GetChange(paidAmountNumericUpDown.Value, GetPriceWithTax(totalPrice));
            UpdateChangeLabel();
        }
    }
}
