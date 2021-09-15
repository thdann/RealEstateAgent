using System;
using System.Diagnostics;
using System.Drawing;
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
            int selectedIndex = lst_Estates.SelectedIndex;
            lst_Estates.Items.RemoveAt(selectedIndex);
            estate = null;
            clearTextFields();
            
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
            else
                MessageBox.Show("The id is not a valid id!");
            return 0;

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
            int resultat;

            bool success = int.TryParse(txt_price.Text, out resultat);

            if (success)
            {
                return resultat;
            }
            else
            { 
                MessageBox.Show("The price is not a valid price!");
                return 0;
            }
        }

        private int readAttribute1() {
            int resultat;

            bool success = int.TryParse(txt_dynamic1.Text, out resultat);

            if (success)
            {
                return resultat;
            }
            else
            {
                return 0;
            }
        }


        private int readAttribute2() {
            int resultat;

            bool success = int.TryParse(txt_dynamic2.Text, out resultat);

            if (success)
            {
                return resultat;
            }
            else
            {
                return 0;
            }
        }

        private Image readImage()
        {
            Debug.WriteLine("Metoden readImage(): Denna bild är uppladdad: " + pBox_estateImage.Image);
            return pBox_estateImage.Image;
        }


        private void btn_save_Click(object sender, EventArgs e)
        {
            String selectedEstateType = comboBox1.SelectedItem.ToString();

            switch (selectedEstateType)
            {
                case "Warehouse":
                    estate = new Warehouse();
                    break;

                 case "Shop":
                    estate = new Shop();
                    break;

                 case "Apartment":
                    estate = new Apartment();
                    break;

                 case "Villa":
                    estate = new Villa();
                    break;
             
                case "Townhouse":
                    estate = new TownHouse();
                    break;

                case "University":
                    estate = new University();
                    break;

                case "School":
                    estate = new School();
                    break;

            }

            setEstateAttributes();
            lst_Estates.Items.Add(estate);
            clearTextFields();
        }

        public void clearTextFields() {

            txt_id.Clear();
            txt_streetAddress.Clear();
            txt_zipCode.Clear();
            txt_city.Clear();
            txt_price.Clear();
            txt_dynamic1.Clear();
            txt_dynamic2.Clear();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            cmb_country.SelectedIndex = 0;
            cmb_legalForm.SelectedIndex = 0;

            pBox_estateImage.Image = null;

        }

        public void setEstateAttributes() {

            estate.Id = readId();
            estate.Address = readAddress();
            estate.LegalForm = readLegalForm();
            estate.Price = readPrice();
           // estate.EstateAbstractMedthod(readAttribute1(), readAttribute2());
            estate.Attribute1 = readAttribute1();
            estate.Attribute2 = readAttribute2();
            estate.EstateImage = readImage();
            Debug.WriteLine("Metoden setEstateAttributed(): Denna bild är inlagt i estateobjektet: " + estate.EstateImage);

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            enableTextFields();
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
                    break;

                case "Shop":
                    lbl_dynamic2.Text = "Number of Electrical sockets:";
                    break;

                case "Apartment":
                    lbl_dynamic2.Text = "Floor number:";
                    break;

                case "Villa":
                    lbl_dynamic2.Text = "Garden area:";
                    break;

                case "Townhouse":
                    lbl_dynamic2.Text = "Number of floors:";
                    break;
               
                case "University":
                    lbl_dynamic2.Text = "Number of Offices:";
                    break;

                case "School":
                    lbl_dynamic2.Text = "Number of classrooms:";
                    break;

            }

        }

        private void btn_upploadImages_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string filePath = openFileDialog1.FileName;
            pBox_estateImage.Image = Image.FromFile(filePath);
        }

        private void lst_Estates_SelectedIndexChanged(object sender, EventArgs e)
        {
      
            Estate selectedObject = (Estate)lst_Estates.SelectedItem;
            if (selectedObject != null)
            {
                pBox_estateImage.Image = selectedObject.EstateImage;// funkar ej?

                txt_id.Text = selectedObject.Id.ToString();
                txt_streetAddress.Text = selectedObject.Address.Street.ToString();
                txt_zipCode.Text = selectedObject.Address.ZipCode.ToString();
                txt_city.Text = selectedObject.Address.City.ToString();
                cmb_country.SelectedItem = selectedObject.Address.Country;
                cmb_legalForm.SelectedItem = selectedObject.LegalForm;

                txt_price.Text = selectedObject.Price.ToString();

                //Dessa två är beroende på vilken typ av objekt som skapats, går ej att komma åt dess specifika properties från estateobjekten. 
                //txt_dynamic1.Text = selectedObject. 
                txt_dynamic1.Text = selectedObject.Attribute1.ToString();
                txt_dynamic2.Text = selectedObject.Attribute2.ToString();
                

                // Hur fixa comboboxarna utifrån type och basetype när enum i comboboxarna?
                //comboBox1.SelectedItem =selectedObject.GetType().BaseType; // Estatetype
                //comboBox2.SelectedItem = selectedObject.GetType(); // Detta är om villa/Skola/shop etc. "Buildingtype"

                disableTextFields();

            }
            else {

                enableTextFields();

                   }

        }

        public void disableTextFields() {
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            cmb_legalForm.Enabled = false;
            txt_id.Enabled = false;
            btn_upploadImages.Enabled = false;
            txt_streetAddress.Enabled = false;
            txt_zipCode.Enabled = false;
            txt_city.Enabled = false;
            cmb_country.Enabled = false;
            txt_price.Enabled = false;
            txt_dynamic1.Enabled = false;
            txt_dynamic2.Enabled = false;

            btn_save.Enabled = false;
        }

        public void enableTextFields()
        {
            comboBox1.Enabled = true;
            comboBox2.Enabled = true;
            cmb_legalForm.Enabled = true;
            txt_id.Enabled = true;
            btn_upploadImages.Enabled = true;
            txt_streetAddress.Enabled = true;
            txt_zipCode.Enabled = true;
            txt_city.Enabled = true;
            cmb_country.Enabled = true;
            txt_price.Enabled = true;
            txt_dynamic1.Enabled = true;
            txt_dynamic2.Enabled = true;
            
            btn_save.Enabled = true;
        }

    }

}
