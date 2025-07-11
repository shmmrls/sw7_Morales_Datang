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
    public partial class Maps : Form
    {
        public Maps()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void programsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Programs programs = new Programs();
            programs.Show();
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

        private void getToKnowUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About_Us about_Us = new About_Us();
            about_Us.Show();
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
            this.Show();
        }

        private void referencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            References references = new References();
            references.Show();
            this.Hide();
        }
    }
}
