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
    public partial class PlayerInit : Form
    {
        private int money;
        private string label = "Player number: ";
        public Player Player;
        public PlayerInit(int _PlayerNumber, int _PlayerMoney)
        {
            InitializeComponent();
            money = _PlayerMoney;
            label += Convert.ToString(_PlayerNumber + 1);
            label1.Text = label;
        }

        private void btn_ConfirmUsername_Click(object sender, EventArgs e)
        {
            Name = tb_Username.Text;
            Player = new Player(money, Name);
            this.Close();
        }
    }
}
