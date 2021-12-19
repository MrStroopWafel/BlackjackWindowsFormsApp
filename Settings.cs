using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackjackFormsApp
{
    public partial class Settings : Form
    {
        public int Players, Decks, Money;

        public Settings()
        {
            InitializeComponent();
        }

        /// <summary>
        /// method for controlling user input
        /// </summary>
        /// <param name="sender">the textbox sending the request</param>
        /// <param name="e">the keypress</param>
        private void InputControlNumbers(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ConfirmSettings_Click(object sender, EventArgs e)
        {
            Players = Int32.Parse(tb_PlayerAmount.Text);
            Decks = Int32.Parse(tb_DeckAmount.Text);
            Money = Int32.Parse(tb_StartMoney.Text);
            this.Close();
        }

    }
}
