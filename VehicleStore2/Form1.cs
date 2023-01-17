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
            Vehicle vehicle = new Vehicle(txtbox_maker.Text, txtbox_model.Text);
            MessageBox.Show("Vehicle details\nMaker: " + vehicle.maker + "\nModel: " + vehicle.model );
        }
    }
}