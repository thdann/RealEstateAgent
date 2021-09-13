using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealEstateAgent
{
    public partial class MainForm : Form
    {
        private Estate estate;

        public MainForm()
        {
            InitializeComponent();

            // Our own instaniations GUI
            InitializeGUI();
        }

        public void InitializeGUI() {
            cmb_legalForm.DataSource = Enum.GetValues(typeof(LegalForm));
            cmb_country.DataSource = Enum.GetValues(typeof(Countries));

        }

        private void addEstate(String estateType)
        {
            
            switch (estateType) {

                case "Residential":
                    createResidential();
                    break;

                case "Institutional":
                    createInstitutional();
                    break;

                case "Commercial":
                    createCommericial();
                    break;

    
            }

        }

        private void createResidential()
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_price_Click(object sender, EventArgs e)
        {

        }

        private void pnl_northwest_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmb_legalForm_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_remove_Click(object sender, EventArgs e)
        {

        }

        private void pnl_northwest_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
