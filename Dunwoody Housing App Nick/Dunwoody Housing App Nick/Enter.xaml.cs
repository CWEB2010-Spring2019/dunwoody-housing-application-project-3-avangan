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
using System.Windows.Shapes;

namespace Dunwoody_Housing_App_Nick
{
    /// <summary>
    /// Interaction logic for Enter.xaml
    /// </summary>
    public partial class Enter : Window
    {

        // Declared Variables 
        public string User;
        public string password;
      
        public Enter()
        {
            InitializeComponent();
        }



        // All the code is run inside the event. This is not like an html form. 
        private void Auth_button_Click(object sender, RoutedEventArgs e)
        {

            /* The actual form textBox needs to have a "Name" added to it and than it's only 
            be triggered on this box however the code entered in the box needs to referanced by the name attribute and triggered or run in button Box . This is called an Event*/

            /* Hint chris used MessageBox.Show("Whatever you want here but ussually a name='' in the form or a variable name");
             He did this because of the common problem that I expieranced immediately . We can never see 
             whatever is stored inside a variable or name within a form until it's " Printed out onto the Screen   " Why Cause it's stored in memory . So use MessageBox.show wherever you want to see what you entered in or whatever is stored in the variable. 
             
             */



            if ((FormUser.Text.ToString() == "home") && (FormPassword.Text.ToString() == "1234"))
            {
                
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();


            }
            else
            {
                Console.WriteLine("Sorry Wrong Username or Password . Please try again ");
            }
        }
        // These Boxes do nothing but leave them alone. They can be used to do a ton of cool things . If ya go to the frontside xamal and click the box and the properties window you will see that it's a ton of events that can be triggered on this box however the code entered in the box needs to referanced by the name attribute and triggered or run in button Box . Event
        private void Username_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Password_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}







