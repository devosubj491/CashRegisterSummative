using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace CashRegisterSummative
{
    public partial class Form1 : Form
    {
        //global variables
        double trainPrice = 100;
        double trackPrice = 50;
        double accessoriesPrice = 25;
        int currentSec = DateTime.Now.Second;
        int currentMin = DateTime.Now.Minute;
        int currentHour = DateTime.Now.Hour;
        int currentDay = DateTime.Now.Day;
        int currentMonth = DateTime.Now.Month;
        int currentYear = DateTime.Now.Year;
        int numberOfTrains = 0;
        int numberOfTracks = 0;
        int numberOfAccessories = 0;
        double subtotalCost = 0;
        double taxRate = 0.13;
        double taxAmount = 0;
        double totalCost = 0;

        double tenderedAmount = 0;
        double changeAmount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            receiptOutput.Text = "";
            try
            {
                //get inputs
                numberOfTrains = (int)Convert.ToDouble(trainsInput.Text);
                numberOfTracks = (int)Convert.ToDouble(tracksInput.Text);
                numberOfAccessories = (int)Convert.ToDouble(accessoriesInput.Text);

                //calculate values
                subtotalCost = (numberOfTrains * trainPrice) + (numberOfTracks * trackPrice) + (numberOfAccessories * accessoriesPrice);
                taxAmount = subtotalCost * taxRate;
                totalCost = subtotalCost + taxAmount;

                //display outputs
                subtotalOutput.Text = $"{subtotalCost.ToString("C")}";
                taxOutput.Text = $"{taxAmount.ToString("C")}";
                totalOutput.Text = $"{totalCost.ToString("C")}";
            }
            catch
            {
                receiptOutput.Text = "Error: Must Be A Valid Number";
            }
        }

        private void printReceiptButton_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources._345053__azumarill__epson_receipt_printer6);
            player.Play();

            Thread.Sleep(400);
            receiptOutput.Text = "            Divo's Model Trains";
            Refresh();

            Thread.Sleep(400);
            receiptOutput.Text += $"\n\nNew Order";
            Refresh();

            Thread.Sleep(400);
            receiptOutput.Text += $"\nDate: {currentMonth}/{currentDay}/{currentYear}; {currentHour}:{currentMin}:{currentSec}";
            Refresh();

            Thread.Sleep(400);
            double totalTrainPrice = numberOfTrains * trainPrice;
            receiptOutput.Text += $"\n\nTrains        {numberOfTrains} x {trainPrice.ToString("C")}: {totalTrainPrice.ToString("C")}";
            Refresh();

            Thread.Sleep(400);
            double totalTrackPrice = numberOfTracks * trackPrice;
            receiptOutput.Text += $"\nTracks         {numberOfTracks} x {trackPrice.ToString("C")}: {totalTrackPrice.ToString("C")}";
            Refresh();

            Thread.Sleep(400);
            double totalAccessoriesPrice = numberOfAccessories * accessoriesPrice;
            receiptOutput.Text += $"\nAccessories    {numberOfAccessories} x {accessoriesPrice.ToString("C")}: {totalAccessoriesPrice.ToString("C")}";
            Refresh();

            Thread.Sleep(400);
            receiptOutput.Text += $"\n\nSubtotal                   {subtotalCost.ToString("C")}";
            Refresh();

            Thread.Sleep(400);
            receiptOutput.Text += $"\nTax                        {taxAmount.ToString("C")}";
            Refresh();

            Thread.Sleep(400);
            receiptOutput.Text += $"\nTotal                      {totalCost.ToString("C")}";
            Refresh();

            Thread.Sleep(400);
            receiptOutput.Text += $"\n\nTendered Amount            {tenderedAmount.ToString("C")}";
            Refresh();

            Thread.Sleep(400);
            receiptOutput.Text += $"\nChange                     {changeAmount.ToString("C")}";
            Refresh();

            Thread.Sleep(400);
            receiptOutput.Text += $"\n\nThank you for shopping at Divo's!";
            Refresh();

            Thread.Sleep(400);
            receiptOutput.Text += $"\nCome again soon!";
            Refresh();
        }

        private void calculateChangeButton_Click(object sender, EventArgs e)
        {
            receiptOutput.Text = "";
            try
            {
                //get input
                tenderedAmount = Convert.ToDouble(tenderedInput.Text);

                //calculate values
                changeAmount = tenderedAmount - totalCost;

                //display output
                changeOutput.Text = $"{changeAmount.ToString("C")}";
            }
            catch
            {
                receiptOutput.Text = "Error: Must Be A Valid Number";
            }
        }

        private void newOrderButton_Click(object sender, EventArgs e)
        {
            receiptOutput.Text = "";
            trainsInput.Text = "";
            tracksInput.Text = "";
            accessoriesInput.Text = "";
            subtotalOutput.Text = "";
            taxOutput.Text = "";
            totalOutput.Text = "";
            tenderedInput.Text = "";
            changeOutput.Text = "";
        }
    }
}
