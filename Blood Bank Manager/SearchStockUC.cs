using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Blood_Bank_Manager {
    public partial class SearchStockUC : UserControl {
        public SearchStockUC() {
            InitializeComponent();
        }

        // To make sure only one instance is created
        private static SearchStockUC _instance;
        public static SearchStockUC Instance {
            get {
                if (_instance == null) {
                    _instance = new SearchStockUC();
                }
                return _instance;
            }
        }
    }
}
