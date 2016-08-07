using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace casowe_zamykanie_systemu
{
    public partial class Form1 : Form
    {
        int totalValue = 60;

        public Form1()
        {
            InitializeComponent();
        }

        public int calculateTotalValue()
        {
            totalValue = hoursSlider.Value * 60 * 60 + minutesSlider.Value * 60 + secondsSlider.Value;
            return totalValue;
        }

        private void hoursSlider_Scroll(object sender, EventArgs e)
        {
           hoursTextBox.Text = hoursSlider.Value.ToString();
            finalTimeProgressBar.Value = calculateTotalValue();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void minutesSlider_Scroll(object sender, EventArgs e)
        {
           minutesTextBox.Text = minutesSlider.Value.ToString();
            finalTimeProgressBar.Value = calculateTotalValue();
        }

        private void secondsSlider_Scroll(object sender, EventArgs e)
        {
            secondsTextBox.Text = secondsSlider.Value.ToString();
            finalTimeProgressBar.Value = calculateTotalValue();
        }

 

        private void hoursTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(hoursTextBox.Text))
                    hoursSlider.Value = int.Parse(hoursTextBox.Text);
                else
                {
                    hoursSlider.Value = 0;
                    hoursTextBox.Text = "0";
                }

                finalTimeProgressBar.Value = calculateTotalValue();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                hoursSlider.Value = hoursSlider.Maximum;
                hoursTextBox.Text = hoursSlider.Maximum.ToString();
            }
            catch (System.FormatException ex)
            {

            }
        }

        private void minutesTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(minutesTextBox.Text))
                    minutesSlider.Value = int.Parse(minutesTextBox.Text);
                else
                {
                    minutesSlider.Value = 0;
                    minutesTextBox.Text = "0";
                }

                finalTimeProgressBar.Value = calculateTotalValue();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                minutesSlider.Value = minutesSlider.Maximum;
                minutesTextBox.Text = minutesSlider.Maximum.ToString();
            }
            catch (System.FormatException ex)
            {

            }
        }

        private void secondsTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(secondsTextBox.Text))
                    secondsSlider.Value = int.Parse(secondsTextBox.Text);
                else
                {
                    secondsSlider.Value = 0;
                    secondsTextBox.Text = "0";
                }

                finalTimeProgressBar.Value = calculateTotalValue();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                secondsSlider.Value = secondsSlider.Maximum;
                secondsTextBox.Text = secondsSlider.Maximum.ToString();
            }
            catch (System.FormatException ex)
            {

            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            string strCmdText;
            strCmdText = "/C shutdown /s /t " + totalValue.ToString() ;
            System.Diagnostics.Process.Start("CMD.exe", strCmdText);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Refresh();
            string strCmdText;
            strCmdText = "/C shutdown /a";
            System.Diagnostics.Process.Start("CMD.exe", strCmdText);
        }
    }
}
