using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Blood_Bank_Manager {
    public partial class DonorSearchResultUC : UserControl {
        public DonorSearchResultUC() {
            InitializeComponent();
        }

        // To make sure only one instance is created
        private static DonorSearchResultUC _instance;
        public static DonorSearchResultUC Instance {
            get {
                if (_instance == null) {
                    _instance = new DonorSearchResultUC();
                }
                return _instance;
            }
        }

        private void back_button_Click(object sender, EventArgs e) {
            Organizer.current_main_form.goToDonorSearchPage();
        }
    }
}
