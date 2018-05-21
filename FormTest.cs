using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try{
                string result = MyCMB.ShowBox("Do you want to exit?\n This Dialog will close automaticaly after 5 sec", "Exit" ,5);
                if (result.Equals("1")){
                    MessageBox.Show("OK Button was Clicked");
                }else if (result.Equals("2")) {
                    MessageBox.Show("Cancel Button was Clicked");
                }
            }catch{ 
        		MessageBox.Show("errrrrrrrrrrrrr");
        	}
        }
        
        void Button2Click(object sender, EventArgs e)
        {
            try{
                string result = MyCMB.ShowBox("Do you want to exit? \n This Dialog will close automaticaly after 10 sec", "Exit" ,10);
                if (result.Equals("1")){
                    MessageBox.Show("OK Button was Clicked");
                }else if (result.Equals("2")) {
                    MessageBox.Show("Cancel Button was Clicked");
                }
            }catch{ }
        }
    }
}