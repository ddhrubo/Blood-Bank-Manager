using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Blood_Bank_Manager {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
            // initialize menu button list to change menu button colors
            menu_button_list_initialize();
            // load HomeUC user control
            load_HomeUC();
        }

        // Home
        private void home_button_Click(object sender, EventArgs e) {
            // Menu buttons' color change
            change_menu_button_color(sender);
            // Title change
            page_title.Text = "Home";
            // load HomeUC user control
            load_HomeUC();
        }
        private void load_HomeUC() {
            if (!base_panel.Controls.Contains(HomeUC.Instance)) {
                base_panel.Controls.Add(HomeUC.Instance);
                HomeUC.Instance.Dock = DockStyle.Fill;
            }
            HomeUC.Instance.BringToFront();
        }

        // Add Donor
        private void add_donor_button_Click(object sender, EventArgs e) {
            // Menu buttons' color change
            change_menu_button_color(sender);
            // Title change
            page_title.Text = "Add Donor";
            // Load AddDonorUC user control
            load_AddDonorUC();
        }
        private void load_AddDonorUC() {
            if (!base_panel.Controls.Contains(AddDonorUC.Instance)) {
                base_panel.Controls.Add(AddDonorUC.Instance);
                AddDonorUC.Instance.Dock = DockStyle.Fill;
            }
            AddDonorUC.Instance.BringToFront();
        }

        /*
         * Form design related codes
         */

        // Exit button
        private void exit_button_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        // Minimize button
        private void minimize_button_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        } 
        
        // Implement window drag on title_panel
        int toMove = 0, valX, valY;
        private void title_panel_MouseDown(object sender, MouseEventArgs e) {
            toMove = 1;
            valX = e.X;
            valY = e.Y;
        }
        private void title_panel_MouseUp(object sender, MouseEventArgs e) {
            toMove = 0;
        }
        private void title_panel_MouseMove(object sender, MouseEventArgs e) {
            if (toMove == 1) {
                this.SetDesktopLocation(MousePosition.X - valX - 200, MousePosition.Y - valY);
            }
        }
      
        // Button click color change code
        List<Button> menu_buttons;
        void menu_button_list_initialize() {
            menu_buttons = new List<Button>();
            menu_buttons.Add( home_button );
            menu_buttons.Add(add_donor_button);
        }
        void change_menu_button_color(object sender) {
            foreach (Button button in menu_buttons) {
                button.BackColor = Color.FromArgb(44,62,80);
            }
            (sender as Button).BackColor = Color.FromArgb(52, 152, 219);
        }
    }
}
