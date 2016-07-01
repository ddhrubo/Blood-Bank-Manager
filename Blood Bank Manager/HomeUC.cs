using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Blood_Bank_Manager {
    public partial class HomeUC : UserControl {
        public HomeUC() {
            InitializeComponent();
        }

        // To make sure only one instance is created
        private static HomeUC _instance;
        public static HomeUC Instance {
            get {
                if (_instance == null) {
                    _instance = new HomeUC();
                }
                return _instance;
            }
        }

        private void view_button_Click(object sender, EventArgs e) {
            MessageBox.Show(input_text_box.Text);
        }
    }
}
