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
    public partial class AddBet : Form
    {
        private Player tempPlayer;

        public AddBet(Player _Player)
        {
            InitializeComponent();
            string question = $"{_Player.Name} Money: ${_Player.Money} \nHow much money do you wanna bet? ";
            label1.Text = question;
            tempPlayer = _Player;
        }
        private void btn_ConfirmBet_Click(object sender, EventArgs e)
        {
            int tempValue = Int32.Parse(tb_BetAmount.Text);
            tempPlayer.Money += tempValue * -1;
            tempPlayer.HandMoney = tempValue;
            this.Close();
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

    }
}
