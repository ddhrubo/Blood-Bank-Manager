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
            load_donor_chart();
            load_stock_chart();
            timer1.Start();
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

        void load_donor_chart() {
            donor_chart.Series["Donors"].Points.AddXY("A+",10);
            donor_chart.Series["Donors"].Points[0].Color = Color.FromArgb(70, 36, 70);

            donor_chart.Series["Donors"].Points.AddXY("A-",15);
            donor_chart.Series["Donors"].Points[1].Color = Color.FromArgb(176, 95, 109);

            donor_chart.Series["Donors"].Points.AddXY("B+",25);
            donor_chart.Series["Donors"].Points[2].Color = Color.FromArgb(235, 107, 86);

            donor_chart.Series["Donors"].Points.AddXY("B-",35);
            donor_chart.Series["Donors"].Points[3].Color = Color.FromArgb(255, 193, 83);

            donor_chart.Series["Donors"].Points.AddXY("AB+",17);
            donor_chart.Series["Donors"].Points[4].Color = Color.FromArgb(174, 68, 200);

            donor_chart.Series["Donors"].Points.AddXY("AB-",41);
            donor_chart.Series["Donors"].Points[5].Color = Color.FromArgb(85, 195, 77);

            donor_chart.Series["Donors"].Points.AddXY("O+",5);
            donor_chart.Series["Donors"].Points[6].Color = Color.FromArgb(7, 67, 84);

            donor_chart.Series["Donors"].Points.AddXY("O-",3);
        }

        void load_stock_chart() {
            stock_chart.Series["Stock"].Points.AddXY("A+", 10);

            stock_chart.Series["Stock"].Points.AddXY("A-", 15);

            stock_chart.Series["Stock"].Points.AddXY("B+", 25);

            stock_chart.Series["Stock"].Points.AddXY("B-", 35);

            stock_chart.Series["Stock"].Points.AddXY("AB+", 17);

            stock_chart.Series["Stock"].Points.AddXY("AB-", 41);

            stock_chart.Series["Stock"].Points.AddXY("O+", 5);

            stock_chart.Series["Stock"].Points.AddXY("O-", 3);
        }

        private void timer1_Tick(object sender, EventArgs e) {
            date_label.Text = DateTime.Now.ToString("d MMMM yyyy");
            time_label.Text = DateTime.Now.ToString("hh:mm tt");
        }
    }
}
