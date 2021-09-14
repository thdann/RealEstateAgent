using System;
using System.Diagnostics;
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
            comboBox2.DataSource = Enum.GetValues(typeof(EstateType));

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
            LegalForm selectedLegalForm = (LegalForm)Enum.Parse(typeof(LegalForm), cmb_legalForm.SelectedValue.ToString());

            if (selectedLegalForm.Equals(LegalForm.Rental))
            {
                lbl_price.Text = "Price per month: ";
            }
            else 
            {
             lbl_price.Text = "Price: ";
            }


        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            estate = null;
        }

        private void pnl_northwest_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private int readId() {

            int resultat;

            bool success = int.TryParse(txt_id.Text, out resultat);

            if (success)
            {
                return resultat;
            }
            else return - 1;
        
        }
        
        private Address readAddress() {

            Address address = new(
                txt_streetAddress.Text,
                txt_zipCode.Text,
                txt_city.Text,
                (Countries)cmb_country.SelectedValue
                );

            return address;

        }
        
        private LegalForm readLegalForm() {

            // Kontrollera så att inte -1?
            return (LegalForm)cmb_legalForm.SelectedValue;
        
        }

        private int readPrice() {
            return Convert.ToInt32(txt_price.Text);
        }

        private int readAttribute1() {
            return Convert.ToInt32(txt_dynamic1.Text);

        }

        private int readAttribute2()
        {
            return Convert.ToInt32(txt_dynamic2.Text);

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            String selectedEstateType = comboBox1.SelectedItem.ToString();

            switch (selectedEstateType)
            {
                case "Warehouse":
                    estate = new Warehouse();
                    setEstateAttributes();
                    break;

                 case "Shop":
                    estate = new Shop();
                    setEstateAttributes();
                    break;


                 case "Apartment":
                    estate = new Apartment();
                    setEstateAttributes();
                    break;

                 case "Villa":
                    estate = new Villa();
                    setEstateAttributes();
                    break;
             
                case "Townhouse":
                    estate = new TownHouse();
                    setEstateAttributes();
                    

                    Debug.WriteLine("Du är i townhouse");
                    Debug.WriteLine(estate.ToString());
                    
                    // Sätt attributen som är för townhouse men inte det andra.
                    // readAttribute1();
                    break;

            }


        }

        public void setEstateAttributes() {

            estate.Id = readId();
            estate.Address = readAddress();
            estate.LegalForm = readLegalForm();
            estate.Price = readPrice();
            estate.EstateAbstractMedthod(readAttribute1(), readAttribute2());

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        //Combobox for EstateType (Commercial/Resedential/Institutional
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {        
            EstateType selectedEstateType = (EstateType)Enum.Parse(typeof(EstateType), comboBox2.SelectedValue.ToString());         
                
                switch (selectedEstateType)
            {

                case EstateType.Commercial:
                    comboBox1.DataSource = Enum.GetValues(typeof(CommercialType));
                    lbl_dynamic1.Text = "Square meters:";
                    break;

                case EstateType.Residential:
                    comboBox1.DataSource = Enum.GetValues(typeof(ResidentialType));
                    lbl_dynamic1.Text = "Number of rooms:";
                    break;

                case EstateType.Institutional:
                    comboBox1.DataSource = Enum.GetValues(typeof(InstitutionalType));
                    lbl_dynamic1.Text = "Number of people Allowed:";
                    break;

            }
        }

        //Combobox for buildingtype - base classes (Villa, Shop, School etc.)
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String selectedEstateType = comboBox1.SelectedItem.ToString();

            switch (selectedEstateType)
            {
                case "Warehouse":
                    lbl_dynamic2.Text = "Number of shelves:";
                    lbl_dynamic3.Text = "Finns ej?";
                    break;

                case "Shop":
                    lbl_dynamic2.Text = "Number of Electrical sockets:";
                    lbl_dynamic3.Text = "Finns ej?";
                    break;

                case "Apartment":
                    lbl_dynamic2.Text = "Floor number:";
                    lbl_dynamic3.Text = "Finns ej?";
                    break;

                case "Villa":
                    lbl_dynamic2.Text = "Garden area:";
                    lbl_dynamic3.Text = "Finns ej?";
                    break;

                case "Townhouse":
                    lbl_dynamic2.Text = "Number of floors:";
                    lbl_dynamic3.Text = "Finns ej?";
                    break;
               
                case "University":
                    lbl_dynamic2.Text = "Number of Offices:";
                    lbl_dynamic3.Text = "Finns ej?";
                    break;

                case "School":
                    lbl_dynamic2.Text = "Number of classrooms:";
                    lbl_dynamic3.Text = "Finns ej?";
                    break;

            }

        }

        private void btn_uploadImage_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Hej hej");



        }
    }

}
