using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace RealEstateAgent
{
    public partial class MainForm : Form
    {
        private Estate estate;
        private EstateManager estateManager;

        public MainForm()
        {
            estateManager = new EstateManager();
            InitializeComponent();
            InitializeComboBoxes(); //Our created method
            InitializeList();
        }

        // Fill the estate comboboxes with values from the different enums
        public void InitializeComboBoxes() {
            cmb_legalForm.DataSource = Enum.GetValues(typeof(LegalForm));
            cmb_country.DataSource = Enum.GetValues(typeof(Countries));
            comboBox2.DataSource = Enum.GetValues(typeof(EstateType));

        }

        //Fills the list with saved objects
        public void InitializeList()
        {
          //  lst_Estates.Items.AddRange(estateManager.ToStringList());// = estateManager.ToStringList();
        }

        //Combobox for EstateType (Commercial/Resedential/Institutional
        //Depending on witch estate type is chooses it sets the label to different text
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
        //Depending on witch building type is chooses it sets the label to different text
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

        //Here we look at witch legalform is selected. If the lealform Rental is choosen 
        // we set the labeltext to "price per month" and in any other case to "Price"
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

        //Converting the text in the id textfield to an int.
        // If it´s ok, success sets to true and result will be returned
        private int readId()
        {

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

        /// Get adddress items from the Address textboxes in the gui
        /// and save the values in an address object that is returned
        private Address readAddress()
        {

            Address address = new(
                txt_streetAddress.Text,
                txt_zipCode.Text,
                txt_city.Text,
                (Countries)cmb_country.SelectedValue
                );

            return address;
        }

        //Returns the selected Legalform
        private LegalForm readLegalForm()
        {

            return (LegalForm)cmb_legalForm.SelectedValue;
        }

        //Converting the text in the price textfield to an int.
        // If it´s ok, success sets to true and result will be returned
        private int readPrice()
        {
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

        private Image readImage()
        {
            return pBox_estateImage.Image;
        }

        //cleares all the textfields
        public void clearTextFields()
        {

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

        public void disableTextFields()
        {
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

        //Upload photo button
        private void btn_upploadImages_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string filePath = openFileDialog1.FileName;
            pBox_estateImage.Image = Image.FromFile(filePath);
        }

        //If the index in the list is greater then -1, the user has choosen an estate 
        // and it should be edited. If it is -1 a new estate object should be created
        private void btn_save_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Du har klickat på save");
                 createObject();
                 checkEstateTypeAndSetAttributes(estate);
                 setTypeSpecificAttributes(estate);
                 setEstateAttributes();
                 estateManager.AddEstate(estate);
                lst_Estates.Items.Clear();
           // lst_Estates.Items.AddRange(estateManager.ToStringList());



        }

        //When clicking the remove button, we remove the selected estete from the list and set the estete to null
        private void btn_remove_Click(object sender, EventArgs e)
        {
           
            
            
           
            clearTextFields();

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            enableTextFields();
        }



        // Create an objectType depending on user input, and set its specific attributes. Save in variable.
        public void createObject() {
            
            Enum buildingTypeSelected = (Enum) comboBox1.SelectedItem;
            estate = createSpecificObjectType(buildingTypeSelected);
            
        }

        // Creates an object type based on user input
        public Estate createSpecificObjectType(Enum typeOfBuilding)
        {
            switch (typeOfBuilding) 
            {
                case CommercialType.Warehouse:
                    Warehouse warehouse = new Warehouse();
                    return warehouse;
                    
                case CommercialType.Shop:
                    Shop shop = new Shop();
                    return shop;

                case ResidentialType.Apartment:
                    Apartment apartment = new Apartment();
                    return apartment;

                case ResidentialType.Villa:
                    Villa villa = new Villa();
                    return villa;

                case ResidentialType.Townhouse:
                    TownHouse townhouse = new TownHouse();
                    return townhouse;

                case InstitutionalType.School:
                    School school = new School();
                    return school;

                case InstitutionalType.University:
                    University university = new University();
                    return university;

                default:
                    return null;
            
            }

        }

        // Sets attributes based on type of object
        public Estate setTypeSpecificAttributes(Estate selectedEstate)
        {
            switch (selectedEstate)
            {
                case Warehouse: 
                    ((Warehouse)selectedEstate).NumberOfShelves = readAttribute2();
                    break;

                case Shop: 
                    ((Shop)selectedEstate).NumberOfElectricalSockets = readAttribute2();
                    break;

                case Apartment:
                    ((Apartment)selectedEstate).Floor = readAttribute2();
                    break;

                case Villa:
                    ((Villa)selectedEstate).GardenArea = readAttribute2();
                    break;

                case TownHouse:
                    ((TownHouse)selectedEstate).NumberOfFloors = readAttribute2();
                    break;

                case School:
                    ((School)selectedEstate).NumberOfClassrooms = readAttribute2();
                    break;

                case University:
                    ((University)selectedEstate).NumberOfOffices = readAttribute2();
                    break;
                default:
                    break;
            }

            return selectedEstate;

        }

        // Checks the baseype of created object and sets its attributes accordingly
        public Estate checkEstateTypeAndSetAttributes(Estate estateObject)
        {
            switch (estateObject)
            {
                case Commercial:
                    ((Commercial)estateObject).SquareMeter = readAttribute1();
                    break;
                case Residential:
                    ((Residential)estateObject).NumberOfRooms = readAttribute1();
                    break;
                case Institutional:
                    ((Institutional)estateObject).NumberOfPeopleAllowed = readAttribute1();
                    break;
                default:
                    break;
            }

            return estateObject;

        }

        //Sets the attributes to an Estateobject
        public Estate setEstateAttributes()
        {
                estate.Id = readId();
                estate.Address = readAddress();
                estate.LegalForm = readLegalForm();
                estate.Price = readPrice();
                estate.EstateImage = readImage();
            
            return estate;
        }

        //To edit an existing estate object. Saves the selected estate in an local estate,
        // sets the estates attributes and updates the list in the gui, then return the estate
        private void editExistingEstateObject()
        {

          /*  estate = (Estate)lst_Estates.SelectedItem;

            checkEstateTypeAndSetAttributes(estate);
            setTypeSpecificAttributes(estate);
            setEstateAttributes();

            lst_Estates.Update(); */
        }




        private void lst_Estates_SelectedIndexChanged(object sender, EventArgs e)
        {
            Debug.WriteLine(lst_Estates.SelectedIndex);
      
          /*  Estate selectedObject = (Estate)lst_Estates.SelectedItem;
            if (selectedObject != null)
            {
                setEstateObjectToComboBoxes(ref selectedObject);
                setEstateObjectToTextfields(ref selectedObject);
                disableTextFields();

            }
            else {

                enableTextFields();

                   } */

        }

        public void setEstateObjectToTextfields(ref Estate selectedObject) {

            pBox_estateImage.Image = selectedObject.EstateImage;

            txt_id.Text = selectedObject.Id.ToString();
            txt_streetAddress.Text = selectedObject.Address.Street.ToString();
            txt_zipCode.Text = selectedObject.Address.ZipCode.ToString();
            txt_city.Text = selectedObject.Address.City.ToString();
            cmb_country.SelectedItem = selectedObject.Address.Country;
            cmb_legalForm.SelectedItem = selectedObject.LegalForm;

            txt_price.Text = selectedObject.Price.ToString();

            txt_dynamic1.Text = getAttribute1FromSelectedObject(selectedObject);
            txt_dynamic2.Text = getAttribute2FromSelectedObject(selectedObject);

        }


        public String getAttribute1FromSelectedObject(Estate selectedObject) 
        {
            switch (selectedObject)
            {
                case Commercial:
                    return ((Commercial)selectedObject).SquareMeter.ToString();
                case Residential:
                    return ((Residential)selectedObject).NumberOfRooms.ToString();
                case Institutional:
                    return ((Institutional)selectedObject).NumberOfPeopleAllowed.ToString();
                default:
                    return null;

            }
        
        }

        public String getAttribute2FromSelectedObject(Estate selectedObject)
        {
            switch (selectedObject)
            {
                case Warehouse:
                    return 
                        ((Warehouse)selectedObject).NumberOfShelves.ToString();
                case Shop:
                    return
                        ((Shop)selectedObject).NumberOfElectricalSockets.ToString();
                case Apartment:
                    return
                        ((Apartment)selectedObject).Floor.ToString();
                case Villa:
                    return
                        ((Villa)selectedObject).GardenArea.ToString();
                case TownHouse:
                    return
                        ((TownHouse)selectedObject).NumberOfFloors.ToString();
                case School:
                    return
                        ((School)selectedObject).NumberOfClassrooms.ToString();
                case University:
                    return
                        ((University)selectedObject).NumberOfOffices.ToString();
                default:
                    return null;

            }

        }

        //Sets the estate object to comboboxes.
        public void setEstateObjectToComboBoxes(ref Estate selectedObject) {

            comboBox2.SelectedItem = getEstateType(selectedObject);
            comboBox1.SelectedItem = getBuildingType(selectedObject);

        }

        public EstateType getEstateType(Estate typeOfEstate) {

            switch (typeOfEstate)
            {
                case Commercial:
                    return EstateType.Commercial;

                case Residential:
                    return EstateType.Residential;

                case Institutional:
                    return EstateType.Institutional;
                default:
                    return EstateType.Commercial;
                   
             
            }
        }

        public Enum getBuildingType(Estate typeOfBuilding) {

            switch (typeOfBuilding) {

                case Warehouse:
                    return CommercialType.Warehouse;
                case Shop:
                    return CommercialType.Shop;
                case Apartment:
                    return ResidentialType.Apartment;
                case Villa:
                    return ResidentialType.Villa;
                case TownHouse:
                    return ResidentialType.Townhouse;
                case School:
                    return InstitutionalType.School;
                case University:
                    return InstitutionalType.University;
                default:
                    return CommercialType.Warehouse;
            
            }
        
        }







        //Dumma metoder som inte går att ta bort!!!!
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

        private void MainForm_Load(object sender, EventArgs e)
        {

        }


        private void pnl_northwest_Paint_1(object sender, PaintEventArgs e)
        {

        }



        //Metoder att ta bort: 

        //Converting the text in the textfield to an int.
        // If it´s ok, success sets to true and result will be returned
        private int readAttribute1()
        {
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

        //Converting the text in the id textfield to an int.
        // If it´s ok, success sets to true and result will be returned
        private int readAttribute2()
        {
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





    }








}
