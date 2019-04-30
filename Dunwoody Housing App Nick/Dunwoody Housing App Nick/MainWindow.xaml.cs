using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
// Make sure you call in the Classes 
using Dunwoody_Housing_App_Nick.classes;


//   This is a good Tutorial ww.lynda.com/MyPlaylist/Watch/20584446/720484?autoplay=true

namespace Dunwoody_Housing_App_Nick
{

    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();


            var EnterNewRes = new res();


        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            // This was just an example chris did to show how the box could  use and changed. Ironically again the code from the TextBox does not go inside here . It goes inside the event that ultimatley triggers it which is the
           
        }


        // Here is the button that will be the Actual Event . When this button is clicked it triggers the events or Code inside it. This is 
        private void Button_Click(object sender, RoutedEventArgs e)

        // This is the Main Submit Button 
        {
            /*  Worker Student  */

            if (Worker.IsChecked == true)

            {
                Worker NewWorkerResident = new Worker(FormFirstName.Text.ToString(), FormLastName.Text.ToString(), Convert.ToInt32(id.Text),
                    Convert.ToInt32(room_txtbx.Text), Convert.ToInt32(floor_combo.Text), Convert.ToDouble(rent.Text));
            }

            /*  Athelete   {
        public athlete(string first, string last, int id, int room, int floor, double rent)  */

            if (Ath.IsChecked==true)

            {
                athlete NewAthleteResident = new athlete (FormFirstName.Text.ToString(), FormLastName.Text.ToString(), Convert.ToInt32(id.Text), Convert.ToInt32(room_txtbx.Text), Convert.ToInt32(floor_combo.Text), Convert.ToDouble(rent.Text));

            }

            // Create a list 

            List<athlete> AtleteList = new List<athlete>();

            /*  Scholarship Student */
            if (scholar.IsChecked == true)
            {
               
                scholar NewScholarShipResident = new scholar(FormFirstName.Text.ToString(), FormLastName.Text.ToString(), Convert.ToInt32(id.Text), Convert.ToInt32(room_txtbx.Text), Convert.ToInt32(floor_combo.Text), Convert.ToDouble(rent.Text)); 
                MessageBox.Show(NewScholarShipResident.ToString());

             
        // Create a list  
        List<scholar> ScholarList = new List<scholar>();

        // Add items using Add method   
        ScholarList.Add(NewScholarShipResident);  
               
            }
            // Once this object is created . How do you referance it ? Or Retrieve the object back ? This Might be in SuperBowl Project. 
            else if (Worker.IsChecked == true)

            {

                Worker NewWorkerResident = new Worker(FormFirstName.Text.ToString(), FormLastName.Text.ToString(), Int32.Parse(id.Text), Int32.Parse(room_txtbx.Text), Int32.Parse(floor_combo.SelectedValue.ToString()), Double.Parse(rent.Text));
                  MessageBox.Show(NewWorkerResident.ToString());
                
            }


            else if (Ath.IsChecked == true)

            {
                athlete NeAth = new athlete (FormFirstName.Text.ToString(), FormLastName.Text.ToString(), int.Parse("id"), int.Parse("room"), int.Parse("floor_combo"), double.Parse("rent"));
                MessageBox.Show(NeAth.ToString());
            }
            }







        private void LastName_TextChanged(object sender, TextChangedEventArgs e)
        {
            // This is Event Handler for the LastName Text Box : Blank Here
            

        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        // Form Name:   Name='Worker' 
        // If this event is triggered it shows the items in floor_combo.items.add
        //student worker only reside on floors 1 - 3

        {
            RadioButton rbWorker = sender as RadioButton;

         
            floor_combo.Items.Add(1);
            floor_combo.Items.Add(2);
            floor_combo.Items.Add(3);

        }
   
        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        // FormName : Name='Ath'
        //student athletes reside on floors 4 – 6 
        {
            floor_combo.Items.Add(4);
            floor_combo.Items.Add(5);
            floor_combo.Items.Add(6);

        }

        private void RadioButton_Checked_3(object sender, RoutedEventArgs e)
        // FormName : Name='scholar'
        //scholarship residents reside on floors 7 and 8
        {
            floor_combo.Items.Add(7);
            floor_combo.Items.Add(8);
        }

        private void Floor_combo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            MessageBox.Show(floor_combo.SelectedValue.ToString());
        }

        private void Worker_btn_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            // This is the text box for room number 
            // Name='room'

        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {
            // Rent Box 

        }
    }
}
