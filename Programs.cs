using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practical_Morales_Datang
{
    public partial class Programs : Form
    {
        public Programs()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void homeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void servicesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void programsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Show();
        }

        private void getToKnowUsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            About_Us know = new About_Us();
            know.Show();
            this.Hide();
        }

        private void offersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Offers offers = new Offers();
            offers.Show();
            this.Hide();
        }

        private void activitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Activites activities = new Activites();
            activities.Show();
            this.Hide();
        }

        private void missionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mission mission = new Mission();
            mission.Show();
            this.Hide();
        }

        private void visionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vision vision = new Vision();
            vision.Show();
            this.Hide();
        }

        private void testimonyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Testimony testimony = new Testimony();
            testimony.Show();
            this.Hide();
        }

        private void mapsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Maps maps = new Maps();
            maps.Show();
            this.Hide();
        }

        private void referencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            References references = new References();
            references.Show();
            this.Hide();
        }
    }
}
