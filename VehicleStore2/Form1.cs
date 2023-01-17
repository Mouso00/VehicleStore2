using VehicleClassLibrary.Models;

namespace VehicleStore2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Store store = new Store();
            Vehicle vehicle = new Vehicle();
            store.AddVehicle(vehicle);
        }

        private void txtbox_maker_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void lst_store_SelectedIndexChanged(object sender, EventArgs e)
        {
            Store store = new Store();
            List<Vehicle> vehiclesList = store.GetVehicles();
            foreach (Vehicle v in vehiclesList)
            {
                vehiclesList.

            }
        }
    }
}