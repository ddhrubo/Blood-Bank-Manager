using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Blood_Bank_Manager {
    public partial class AddDonorUC : UserControl {
        public AddDonorUC() {
            InitializeComponent();
        }

        // To make sure only one instance is created
        private static AddDonorUC _instance;
        public static AddDonorUC Instance {
            get {
                if (_instance == null) {
                    _instance = new AddDonorUC();
                }
                return _instance;
            }
        }
    }
}
