using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheWayToTheEnd
{
    public partial class PVP : Form
    {
        int dicenum;
        int p1=1, p2=0;
        int p1currentlocation=1, p2currentlocation=1;

        public PVP()
        {
            InitializeComponent();
        }

        private void PVP_Load(object sender, EventArgs e)
        {
            reset();
        }

        private void playermove() {
            if (p1 == 1)
            {
                player1position.Text = (Convert.ToInt16(player1position.Text) + dicenum).ToString(); 
                p1 = 0;
                p2 = 1;
                wincheck();
                player1disappear();
                conditionckeckforp1(); 
            }
            else if (p2 == 1)
            {
                player2position.Text = (Convert.ToInt16(player2position.Text) + dicenum).ToString();
                p2 = 0;
                p1 = 1;
                wincheck();
                player2disappear();
                conditionckeckforp2();
            }
            else {
                MessageBox.Show("Error moving player!");
            }
        }

        //Appear Paper1 location
        private void player2appear() {
            switch (Convert.ToInt16(player2position.Text)) {
                case 1:
                    player2_1.Visible = true;
                    p2currentlocation = 1;
                    break;
                case 2:
                    player2_2.Visible = true;
                    p2currentlocation = 2;
                    break;
                case 3:
                    player2_3.Visible = true;
                    p2currentlocation = 3;
                    break;
                case 4:
                    player2_4.Visible = true;
                    p2currentlocation = 4;
                    break;
                case 5:
                    player2_5.Visible = true;
                    p2currentlocation = 5;
                    break;
                case 6:
                    player2_6.Visible = true;
                    p2currentlocation = 6;
                    break;
                case 7:
                    player2_7.Visible = true;
                    p2currentlocation = 7;
                    break;
                case 8:
                    player2_8.Visible = true;
                    p2currentlocation = 8;
                    break;
                case 9:
                    player2_9.Visible = true;
                    p2currentlocation = 9;
                    break;
                case 10:
                    player2_10.Visible = true;
                    p2currentlocation = 10;
                    break;
                case 11:
                    player2_11.Visible = true;
                    p2currentlocation = 11;
                    break;
                case 12:
                    player2_12.Visible = true;
                    p2currentlocation = 12;
                    break;
                case 13:
                    player2_13.Visible = true;
                    p2currentlocation = 13;
                    break;
                case 14:
                    player2_14.Visible = true;
                    p2currentlocation = 14;
                    break;
                case 15:
                    player2_15.Visible = true;
                    p2currentlocation = 15;
                    break;
                case 16:
                    player2_16.Visible = true;
                    p2currentlocation = 16;
                    break;
                case 17:
                    player2_17.Visible = true;
                    p2currentlocation = 17;
                    break;
                case 18:
                    player2_18.Visible = true;
                    p2currentlocation = 18;
                    break;
                case 19:
                    player2_19.Visible = true;
                    p2currentlocation = 19;
                    break;
                case 20:
                    player2_20.Visible = true;
                    p2currentlocation = 20;
                    break;
                case 21:
                    player2_21.Visible = true;
                    p2currentlocation = 21;
                    break;
                case 22:
                    player2_22.Visible = true;
                    p2currentlocation = 22;
                    break;
                case 23:
                    player2_23.Visible = true;
                    p2currentlocation = 23;
                    break;
                case 24:
                    player2_24.Visible = true;
                    p2currentlocation = 24;
                    break;
                case 25:
                    player2_25.Visible = true;
                    p2currentlocation = 25;
                    break;
                case 26:
                    player2_26.Visible = true;
                    p2currentlocation = 26;
                    break;
                case 27:
                    player2_27.Visible = true;
                    p2currentlocation = 27;
                    break;
                case 28:
                    player2_28.Visible = true;
                    p2currentlocation = 28;
                    break;
                case 29:
                    player2_29.Visible = true;
                    p2currentlocation = 29;
                    break;
                case 30:
                    player2_30.Visible = true;
                    p2currentlocation = 30;
                    break;
                case 31:
                    player2_31.Visible = true;
                    p2currentlocation = 31;
                    break;
                case 32:
                    player2_32.Visible = true;
                    p2currentlocation = 32;
                    break;
                case 33:
                    player2_33.Visible = true;
                    p2currentlocation = 33;
                    break;
                case 34:
                    player2_34.Visible = true;
                    p2currentlocation = 34;
                    break;
                case 35:
                    player2_35.Visible = true;
                    p2currentlocation = 35;
                    break;
                case 36:
                    player2_36.Visible = true;
                    p2currentlocation = 36;
                    break;
                case 37:
                    player2_37.Visible = true;
                    p2currentlocation = 37;
                    break;
                case 38:
                    player2_38.Visible = true;
                    p2currentlocation = 38;
                    break;
                case 39:
                    player2_39.Visible = true;
                    p2currentlocation = 39;
                    break;
                case 40:
                    player2_40.Visible = true;
                    p2currentlocation = 40;
                    break;
                case 41:
                    player2_41.Visible = true;
                    p2currentlocation = 41;
                    break;
                case 42:
                    player2_42.Visible = true;
                    p2currentlocation = 42;
                    break;
                default:

                    break;
            }
        }

        //DisAppear Paper1 location
        private void player2disappear()
        {
            switch (p2currentlocation)
            {
                case 1:
                    player2_1.Visible = false;
                    break;
                case 2:
                    player2_2.Visible = false;
                    break;
                case 3:
                    player2_3.Visible = false;
                    break;
                case 4:
                    player2_4.Visible = false;
                    break;
                case 5:
                    player2_5.Visible = false;
                    break;
                case 6:
                    player2_6.Visible = false;
                    break;
                case 7:
                    player2_7.Visible = false;
                    break;
                case 8:
                    player2_8.Visible = false;
                    break;
                case 9:
                    player2_9.Visible = false;
                    break;
                case 10:
                    player2_10.Visible = false;
                    break;
                case 11:
                    player2_11.Visible = false;
                    break;
                case 12:
                    player2_12.Visible = false;
                    break;
                case 13:
                    player2_13.Visible = false;
                    break;
                case 14:
                    player2_14.Visible = false;
                    break;
                case 15:
                    player2_15.Visible = false;
                    break;
                case 16:
                    player2_16.Visible = false;
                    break;
                case 17:
                    player2_17.Visible = false;
                    break;
                case 18:
                    player2_18.Visible = false;
                    break;
                case 19:
                    player2_19.Visible = false;
                    break;
                case 20:
                    player2_20.Visible = false;
                    break;
                case 21:
                    player2_21.Visible = false;
                    break;
                case 22:
                    player2_22.Visible = false;
                    break;
                case 23:
                    player2_23.Visible = false;
                    break;
                case 24:
                    player2_24.Visible = false;
                    break;
                case 25:
                    player2_25.Visible = false;
                    break;
                case 26:
                    player2_26.Visible = false;
                    break;
                case 27:
                    player2_27.Visible = false;
                    break;
                case 28:
                    player2_28.Visible = false;
                    break;
                case 29:
                    player2_29.Visible = false;
                    break;
                case 30:
                    player2_30.Visible = false;
                    break;
                case 31:
                    player2_31.Visible = false;
                    break;
                case 32:
                    player2_32.Visible = false;
                    break;
                case 33:
                    player2_33.Visible = false;
                    break;
                case 34:
                    player2_34.Visible = false;
                    break;
                case 35:
                    player2_35.Visible = false;
                    break;
                case 36:
                    player2_36.Visible = false;
                    break;
                case 37:
                    player2_37.Visible = false;
                    break;
                case 38:
                    player2_38.Visible = false;
                    break;
                case 39:
                    player2_39.Visible = false;
                    break;
                case 40:
                    player2_40.Visible = false;
                    break;
                case 41:
                    player2_41.Visible = false;
                    break;
                case 42:
                    player2_42.Visible = false;
                    break;
                default:

                    break;
            }
        }

        //Appear Paper1 location
        private void player1appear()
        {
            switch (Convert.ToInt16(player1position.Text))
            {
                case 1:
                    player1_1.Visible = true;
                    p1currentlocation = 1;
                    break;
                case 2:
                    player1_2.Visible = true;
                    p1currentlocation = 2;
                    break;
                case 3:
                    player1_3.Visible = true;
                    p1currentlocation = 3;
                    break;
                case 4:
                    player1_4.Visible = true;
                    p1currentlocation = 4;
                    break;
                case 5:
                    player1_5.Visible = true;
                    p1currentlocation = 5;
                    break;
                case 6:
                    player1_6.Visible = true;
                    p1currentlocation = 6;
                    break;
                case 7:
                    player1_7.Visible = true;
                    p1currentlocation = 7;
                    break;
                case 8:
                    player1_8.Visible = true;
                    p1currentlocation = 8;
                    break;
                case 9:
                    player1_9.Visible = true;
                    p1currentlocation = 9;
                    break;
                case 10:
                    player1_10.Visible = true;
                    p1currentlocation = 10;
                    break;
                case 11:
                    player1_11.Visible = true;
                    p1currentlocation = 11;
                    break;
                case 12:
                    player1_12.Visible = true;
                    p1currentlocation = 12;
                    break;
                case 13:
                    player1_13.Visible = true;
                    p1currentlocation = 13;
                    break;
                case 14:
                    player1_14.Visible = true;
                    p1currentlocation = 14;
                    break;
                case 15:
                    player1_15.Visible = true;
                    p1currentlocation = 15;
                    break;
                case 16:
                    player1_16.Visible = true;
                    p1currentlocation = 16;
                    break;
                case 17:
                    player1_17.Visible = true;
                    p1currentlocation = 17;
                    break;
                case 18:
                    player1_18.Visible = true;
                    p1currentlocation = 18;
                    break;
                case 19:
                    player1_19.Visible = true;
                    p1currentlocation = 19;
                    break;
                case 20:
                    player1_20.Visible = true;
                    p1currentlocation = 20;
                    break;
                case 21:
                    player1_21.Visible = true;
                    p1currentlocation = 21;
                    break;
                case 22:
                    player1_22.Visible = true;
                    p1currentlocation = 22;
                    break;
                case 23:
                    player1_23.Visible = true;
                    p1currentlocation = 23;
                    break;
                case 24:
                    player1_24.Visible = true;
                    p1currentlocation = 24;
                    break;
                case 25:
                    player1_25.Visible = true;
                    p1currentlocation = 25;
                    break;
                case 26:
                    player1_26.Visible = true;
                    p1currentlocation = 26;
                    break;
                case 27:
                    player1_27.Visible = true;
                    p1currentlocation = 27;
                    break;
                case 28:
                    player1_28.Visible = true;
                    p1currentlocation = 28;
                    break;
                case 29:
                    player1_29.Visible = true;
                    p1currentlocation = 29;
                    break;
                case 30:
                    player1_30.Visible = true;
                    p1currentlocation = 30;
                    break;
                case 31:
                    player1_31.Visible = true;
                    p1currentlocation = 31;
                    break;
                case 32:
                    player1_32.Visible = true;
                    p1currentlocation = 32;
                    break;
                case 33:
                    player1_33.Visible = true;
                    p1currentlocation = 33;
                    break;
                case 34:
                    player1_34.Visible = true;
                    p1currentlocation = 34;
                    break;
                case 35:
                    player1_35.Visible = true;
                    p1currentlocation = 35;
                    break;
                case 36:
                    player1_36.Visible = true;
                    p1currentlocation = 36;
                    break;
                case 37:
                    player1_37.Visible = true;
                    p1currentlocation = 37;
                    break;
                case 38:
                    player1_38.Visible = true;
                    p1currentlocation = 38;
                    break;
                case 39:
                    player1_39.Visible = true;
                    p1currentlocation = 39;
                    break;
                case 40:
                    player1_40.Visible = true;
                    p1currentlocation = 40;
                    break;
                case 41:
                    player1_41.Visible = true;
                    p1currentlocation = 41;
                    break;
                case 42:
                    player1_42.Visible = true;
                    p1currentlocation = 42;
                    break;
                default:

                    break;
            }
        }

        //DisAppear Paper1 location
        private void player1disappear()
        {
            switch (p1currentlocation)
            {
                case 1:
                    player1_1.Visible = false;
                    break;
                case 2:
                    player1_2.Visible = false;
                    break;
                case 3:
                    player1_3.Visible = false;
                    break;
                case 4:
                    player1_4.Visible = false;
                    break;
                case 5:
                    player1_5.Visible = false;
                    break;
                case 6:
                    player1_6.Visible = false;
                    break;
                case 7:
                    player1_7.Visible = false;
                    break;
                case 8:
                    player1_8.Visible = false;
                    break;
                case 9:
                    player1_9.Visible = false;
                    break;
                case 10:
                    player1_10.Visible = false;
                    break;
                case 11:
                    player1_11.Visible = false;
                    break;
                case 12:
                    player1_12.Visible = false;
                    break;
                case 13:
                    player1_13.Visible = false;
                    break;
                case 14:
                    player1_14.Visible = false;
                    break;
                case 15:
                    player1_15.Visible = false;
                    break;
                case 16:
                    player1_16.Visible = false;
                    break;
                case 17:
                    player1_17.Visible = false;
                    break;
                case 18:
                    player1_18.Visible = false;
                    break;
                case 19:
                    player1_19.Visible = false;
                    break;
                case 20:
                    player1_20.Visible = false;
                    break;
                case 21:
                    player1_21.Visible = false;
                    break;
                case 22:
                    player1_22.Visible = false;
                    break;
                case 23:
                    player1_23.Visible = false;
                    break;
                case 24:
                    player1_24.Visible = false;
                    break;
                case 25:
                    player1_25.Visible = false;
                    break;
                case 26:
                    player1_26.Visible = false;
                    break;
                case 27:
                    player1_27.Visible = false;
                    break;
                case 28:
                    player1_28.Visible = false;
                    break;
                case 29:
                    player1_29.Visible = false;
                    break;
                case 30:
                    player1_30.Visible = false;
                    break;
                case 31:
                    player1_31.Visible = false;
                    break;
                case 32:
                    player1_32.Visible = false;
                    break;
                case 33:
                    player1_33.Visible = false;
                    break;
                case 34:
                    player1_34.Visible = false;
                    break;
                case 35:
                    player1_35.Visible = false;
                    break;
                case 36:
                    player1_36.Visible = false;
                    break;
                case 37:
                    player1_37.Visible = false;
                    break;
                case 38:
                    player1_38.Visible = false;
                    break;
                case 39:
                    player1_39.Visible = false;
                    break;
                case 40:
                    player1_40.Visible = false;
                    break;
                case 41:
                    player1_41.Visible = false;
                    break;
                case 42:
                    player1_42.Visible = false;
                    break;
                default:

                    break;
            }
        }

        /*
        UP
        5 to 18
        19 to 39
        23 to 34
        33 to 40

        Down
        38 to 4
        22 to 7
        27 to 13
        14 to 2
         */
        private void conditionckeckforp1() {
            switch (Convert.ToInt16(player1position.Text)) {
                case 5:
                    MessageBox.Show("Player 1 Go Up To 18");
                    player1_18.Visible = true;
                    player1position.Text = "18";
                    p1currentlocation = 18;
                    break;
                case 19:
                    MessageBox.Show("Player 1 Go Up To 39");
                    player1_39.Visible = true;
                    player1position.Text = "39";
                    p1currentlocation = 39;
                    break;
                case 23:
                    MessageBox.Show("Player 1 Go Up To 23");
                    player1_34.Visible = true;
                    player1position.Text = "23";
                    p1currentlocation = 34;
                    break;
                case 33:
                    MessageBox.Show("Player 1 Go Up To 40");
                    player1_40.Visible = true;
                    player1position.Text = "40";
                    p1currentlocation = 40;
                    break;
                case 38:
                    MessageBox.Show("Player 1 Go Down To 4");
                    player1_4.Visible = true;
                    player1position.Text = "4";
                    p1currentlocation = 4;
                    break;
                case 22:
                    MessageBox.Show("Player 1 Go Down to 7");
                    player1_7.Visible = true;
                    player1position.Text = "7";
                    p1currentlocation = 7;
                    break;
                case 27:
                    MessageBox.Show("Player 1 Go Down to 13");
                    player1_13.Visible = true;
                    player1position.Text = "13";
                    p1currentlocation = 13;
                    break;
                case 14:
                    MessageBox.Show("Player 1 Go Down to 2");
                    player1_2.Visible = true;
                    player1position.Text = "2";
                    p1currentlocation = 2;
                    break;
                default:
                    player1appear();
                    break;
            }
        }

        private void conditionckeckforp2()
        {
            switch (Convert.ToInt16(player2position.Text))
            {
                case 5:
                    MessageBox.Show("Player 2 Go Up To 18");
                    player2_18.Visible = true;
                    player2position.Text = "18";
                    p2currentlocation = 18;
                    break;
                case 19:
                    MessageBox.Show("Player 2 Go Up To 39");
                    player2_39.Visible = true;
                    player2position.Text = "39";
                    p2currentlocation = 39;
                    break;
                case 23:
                    MessageBox.Show("Player 2 Go Up To 23");
                    player2_34.Visible = true;
                    player2position.Text = "23";
                    p2currentlocation = 34;
                    break;
                case 33:
                    MessageBox.Show("Player 2 Go Up To 40");
                    player2_40.Visible = true;
                    player2position.Text = "40";
                    p2currentlocation = 40;
                    break;
                case 38:
                    MessageBox.Show("Player 2 Go Down To 4");
                    player2_4.Visible = true;
                    player2position.Text = "4";
                    p2currentlocation = 4;
                    break;
                case 22:
                    MessageBox.Show("Player 2 Go Down to 7");
                    player2_7.Visible = true;
                    player2position.Text = "7";
                    p2currentlocation = 7;
                    break;
                case 27:
                    MessageBox.Show("Player 2 Go Down to 13");
                    player2_13.Visible = true;
                    player2position.Text = "13";
                    p2currentlocation = 13;
                    break;
                case 14:
                    MessageBox.Show("Player 2 Go Down to 2");
                    player2_2.Visible = true;
                    player2position.Text = "2";
                    p2currentlocation = 2;
                    break;
                default:
                    player2appear();
                    break;
            }
        }

        private void wincheck() {
            if (Convert.ToInt16(player1position.Text) >= 42) {
                MessageBox.Show("Player1 Win");
                reset();
            }
            if (Convert.ToInt16(player2position.Text) >= 42)
            {
                MessageBox.Show("Player2 Win");
                reset();
            }
        }

        private void mainmenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mm = new MainMenu();
            mm.Show();
        }

        public void reset() {
            player1position.Text = "1";
            player2position.Text = "1";
            player2_1.Visible = true;
            player1_1.Visible = true;
            dicenumber.Text = "0";
        }

        private void Dice_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            dicenum = rand.Next(1,7);
            dicenumber.Text = dicenum.ToString();
            playermove();
        }
    }
}
