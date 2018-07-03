using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CognitoNetSample
{
    public partial class CodeEntry : Form
    {
        
        public CodeEntry(string username,string phonenumber)
        {
            
            InitializeComponent();
            lblusername.Text = username;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            CognitoHelper cognitoHelper = new CognitoHelper();
            bool success= await cognitoHelper.VerifyAccessCode(lblusername.Text, txtcode.Text);
            if (success)
            {
                MessageBox.Show("Able to validate the access code");
                this.Close();
            }
            else
            {
                MessageBox.Show("Unable to validate the access code");
            }
        }
    }
}
