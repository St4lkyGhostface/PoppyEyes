using System;
using System.Windows.Forms;
using System.Diagnostics;
using Infinity;

namespace PoppyEyes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Pretty much the launch procedure, checks the status of the server, gets the game's path and then shows the form
            Infinity.Net.Health();
            Modifier.GetPath();
            gamePathBox.Text = Modifier.PATH;
        }

        private void donate_Click(object sender, EventArgs e)
        {
            // Opens the donation page in the default browser, you should try it out!
            Process.Start("https://infinitygg.net/tip");
        }

        private void label11_Click(object sender, EventArgs e)
        {
            // Opens the page from where you got this code
            Process.Start("https://github.com/St4lkyGhostface/PoppyEyes");
        }

        // Below are the event handlers for the buttons, they're pretty self-explanatory
        private void defaultFov_Click(object sender, EventArgs e)
        {
            Modifier.Mod("DEFAULTFOV", "settings.sav", "FOV");
        }

        private void midFov_Click(object sender, EventArgs e)
        {
            Modifier.Mod("MIDFOV", "settings.sav", "FOV");
        }

        private void maxFov_Click(object sender, EventArgs e)
        {
            Modifier.Mod("MAXFOV", "settings.sav", "FOV");
        }

        private void maxTickets_Click(object sender, EventArgs e)
        {
            Modifier.Mod("MAX", "TicketSaveGameSlot.sav", "TICKETS");
        }

        private void resetTickets_Click(object sender, EventArgs e)
        {
            Modifier.Mod("ZERO", "TicketSaveGameSlot.sav", "TICKETS");
        }

        // Code to run when the user closes the tab
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Thank you for using our tool, if you'd like to contribute please visit https://infinitygg.net/tip", "Poppy Eyes, developed by StalkyGhostface", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Environment.Exit(0);
        }

        // Opens a link that redirects to the infinity's discord server invite
        private void discordButton_Click(object sender, EventArgs e)
        {
            Process.Start("https://infinitygg.net/join");
        }

        // Launches the game through Steam
        private void launchButton_Click(object sender, EventArgs e)
        {
            Process.Start("steam://rungameid/1961460");
        }
    }
}
