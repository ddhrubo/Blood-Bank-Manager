using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Blood_Bank_Manager {
    public partial class SearchDonorUC : UserControl {
        public SearchDonorUC() {
            InitializeComponent();
        }

        // To make sure only one instance is created
        private static SearchDonorUC _instance;
        public static SearchDonorUC Instance {
            get {
                if (_instance == null) {
                    _instance = new SearchDonorUC();
                }
                return _instance;
            }
        }

        private void search_button_Click(object sender, EventArgs e) {
            Organizer.current_main_form.goToDonorSearchResultPage();
        }
    }
}
