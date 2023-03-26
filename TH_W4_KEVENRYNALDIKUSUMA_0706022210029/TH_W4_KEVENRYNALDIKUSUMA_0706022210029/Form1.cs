using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TH_W4_KEVENRYNALDIKUSUMA_0706022210029
{
    public partial class Form1 : Form
    {
        List<Team> teambola = new List<Team>();
        public Form1()
        {
            InitializeComponent();

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            bool ada = false;
            if (txtbox_Name.Text == "" && txtbox_cntry.Text == "" && txtbox_city.Text == "")
            {
                MessageBox.Show("Please fill in all the fields.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                foreach (Team t in teambola)
                {
                    if (txtbox_cntry.Text == t.teamcountry)
                    {
                        if (txtbox_Name.Text == t.teamname)
                        {
                            ada = true;
                        }
                    }

                }
                if (ada == true)
                {
                    MessageBox.Show("Team already exists. Please add another team.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    teambola.Add(new Team
                    {
                        teamname = txtbox_Name.Text,
                        teamcountry = txtbox_cntry.Text,
                        teamcity = txtbox_city.Text
                    });
                }

                if (!cmbox_Cntry1.Items.Contains(txtbox_cntry.Text))
                {
                    cmbox_Cntry1.Items.Add(txtbox_cntry.Text);
                }
                txtbox_city.Clear();
                txtbox_cntry.Clear();
                txtbox_Name.Clear();
            }
        }

        private void btn_add2_Click(object sender, EventArgs e)
        {
            bool ada1 = false;
            if (txtbox_plyr_name.Text == "" && txtbox_plyr_number.Text == "" && cmbox_plyr_pstn.Text == "")
            {
                MessageBox.Show("Please fill in all the fields.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (cmbox_tm1.Text == "")
                {
                    MessageBox.Show("Please select a team first.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    foreach (Team l in teambola)
                    {
                        if (cmbox_tm1.Text == l.teamname)
                        {
                            foreach (Player k in l.players)
                            {
                                if (txtbox_plyr_number.Text == k.playernumber)
                                {
                                    ada1 = true;
                                }
                            }
                            if (ada1 == true)
                            {
                                MessageBox.Show("A player with the same number already exists.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                l.players.Add(new Player { playername = txtbox_plyr_name.Text, playernumber = txtbox_plyr_number.Text, playerpos = cmbox_plyr_pstn.Text });
                            }
                            
                        }
                    }
                }
                txtbox_plyr_name.Clear();
                txtbox_plyr_number.Clear();
                cmbox_plyr_pstn.Text = "";
            }
        }

        private void cmbox_Cntry1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmbox_tm1.Items.Clear();
            foreach (Team o in teambola)
            {
                if (cmbox_Cntry1.SelectedItem.ToString().ToLower() == o.teamcountry.ToLower())
                {
                    cmbox_tm1.Items.Add(o.teamname);
                }
            }
        }

        private void cmbox_tm1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            listBox_plyrlist.Items.Clear();
            foreach (Team p in teambola)
            {
                if (cmbox_tm1.SelectedItem.ToString().ToLower() == p.teamname.ToLower())
                {
                    foreach (Player n in p.players)
                    {
                        listBox_plyrlist.Items.Add($"({n.playernumber}) {n.playername}, {n.playerpos}");
                    }
                }
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (listBox_plyrlist.Items.Count <= 11)
            {
                MessageBox.Show("Players must be 11 or more.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (Team g in teambola)
                {
                    if (cmbox_tm1.SelectedItem.ToString().ToLower() == g.teamname)
                    {
                        foreach (Player z in g.players)
                        {
                            if (listBox_plyrlist.SelectedItems.ToString().Contains(z.playername))
                            {
                                g.players.Remove(z);
                                break;
                            }
                        }
                    }
                }
                listBox_plyrlist.Items.RemoveAt(listBox_plyrlist.SelectedIndex);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Team sampleteam1 = new Team() { teamname = "Manchester United", teamcountry = "England", teamcity = "Manchester" };
            Team sampleteam2 = new Team() { teamname = "Liverpool", teamcountry = "England", teamcity = "Liverpool" };
            Team sampleteam3 = new Team() { teamname = "Barcelona", teamcountry = "Spain", teamcity = "Barcelona" };
            teambola.Add(sampleteam1);
            teambola.Add(sampleteam2);
            teambola.Add(sampleteam3);
            foreach (Team f in teambola)
            {
                if (!cmbox_Cntry1.Items.Contains(f.teamcountry))
                {
                    cmbox_Cntry1.Items.Add(f.teamcountry);
                }
            }
            sampleteam1.players.Add(new Player() { playername = "David de Gea ", playernumber = "1", playerpos = "GK" });
            sampleteam1.players.Add(new Player() { playername = "Harry Maguire ", playernumber = "5", playerpos = "DF" });
            sampleteam1.players.Add(new Player() { playername = "Victor Lindelof ", playernumber = "2", playerpos = "DF" });
            sampleteam1.players.Add(new Player() { playername = "Eric Bailly ", playernumber = "3", playerpos = "DF" });
            sampleteam1.players.Add(new Player() { playername = "Paul Pogba ", playernumber = "6", playerpos = "MF" });
            sampleteam1.players.Add(new Player() { playername = "Bruno Fernandes ", playernumber = "18", playerpos = "MF" });
            sampleteam1.players.Add(new Player() { playername = "Fred ", playernumber = "17", playerpos = "MF" });
            sampleteam1.players.Add(new Player() { playername = "Nemanja Matic ", playernumber = "31", playerpos = "MF" });
            sampleteam1.players.Add(new Player() { playername = "Marcus Rashford ", playernumber = "10", playerpos = "FW" });
            sampleteam1.players.Add(new Player() { playername = "Mason Greenwood ", playernumber = "11", playerpos = "FW" });
            sampleteam1.players.Add(new Player() { playername = "Jadon Sancho ", playernumber = "25", playerpos = "FW" });

            sampleteam2.players.Add(new Player() { playername = "Alisson Becker", playernumber = "1", playerpos = "GK" });
            sampleteam2.players.Add(new Player() { playername = "Virgil van Dijk", playernumber = "4", playerpos = "DF" });
            sampleteam2.players.Add(new Player() { playername = "Joe Gomez", playernumber = "12", playerpos = "DF" });
            sampleteam2.players.Add(new Player() { playername = "Joel Matip", playernumber = "32", playerpos = "DF" });
            sampleteam2.players.Add(new Player() { playername = "Trent Alexander-Arnold", playernumber = "66", playerpos = "DF" });
            sampleteam2.players.Add(new Player() { playername = "Andy Robertson", playernumber = "26", playerpos = "DF" });
            sampleteam2.players.Add(new Player() { playername = "Jordan Henderson", playernumber = "14", playerpos = "MF" });
            sampleteam2.players.Add(new Player() { playername = "Fabinho", playernumber = "3", playerpos = "MF" });
            sampleteam2.players.Add(new Player() { playername = "Thiago Alcantara", playernumber = "6", playerpos = "MF" });
            sampleteam2.players.Add(new Player() { playername = "Sadio Mane", playernumber = "10", playerpos = "FW" });
            sampleteam2.players.Add(new Player() { playername = "Mohamed Salah", playernumber = "11", playerpos = "FW" });

            sampleteam3.players.Add(new Player() { playername = "Lionel Messi", playernumber = "10", playerpos = "FW" });
            sampleteam3.players.Add(new Player() { playername = "Gerard Pique", playernumber = "3", playerpos = "DF" });
            sampleteam3.players.Add(new Player() { playername = "Jordi Alba", playernumber = "18", playerpos = "DF" });
            sampleteam3.players.Add(new Player() { playername = "Frenkie de Jong", playernumber = "21", playerpos = "MF" });
            sampleteam3.players.Add(new Player() { playername = "Sergio Busquets", playernumber = "5", playerpos = "MF" });
            sampleteam3.players.Add(new Player() { playername = "Pedri", playernumber = "16", playerpos = "MF" });
            sampleteam3.players.Add(new Player() { playername = "Ansu Fati", playernumber = "22", playerpos = "FW" });
            sampleteam3.players.Add(new Player() { playername = "Antoine Griezmann", playernumber = "7", playerpos = "FW" });
            sampleteam3.players.Add(new Player() { playername = "Ousmane Dembele", playernumber = "11", playerpos = "FW" });
            sampleteam3.players.Add(new Player() { playername = "Ronald Araujo", playernumber = "4", playerpos = "DF" });
            sampleteam3.players.Add(new Player() { playername = "Marc-Andre ter Stegen", playernumber = "1", playerpos = "GK" });

        }

      
    }
}
