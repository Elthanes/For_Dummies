using Amazon.CognitoIdentity;
using Amazon.Runtime;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace CognitoNetSample
{
    public partial class LoginForm : Form
    {
        Amazon.Extensions.CognitoAuthentication.CognitoUser cognitoUser = null;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                CognitoHelper cognitoHelper = new CognitoHelper();
                cognitoUser = await cognitoHelper.ValidateUser(txtusername.Text, txtpassword.Text);
                MessageBox.Show("Login successfully");
                Console.WriteLine(cognitoUser.Username);

                CognitoAWSCredentials credentials = cognitoUser.GetCognitoAWSCredentials(ConfigurationManager.AppSettings["FED_POOL_id"], new AppConfigAWSRegion().Region);
                StringBuilder tokens = new StringBuilder();

                tokens.Append("================Cognito Credentails==================\n");
                tokens.Append("Access Key - " + credentials.GetCredentials().AccessKey);
                tokens.Append("\nSecret - " + credentials.GetCredentials().SecretKey);
                tokens.Append("\nSession Token - " + credentials.GetCredentials().Token);
                tokens.Append("\nUseToken Token - " + credentials.GetCredentials().UseToken.ToString());
                Console.WriteLine(tokens.ToString());

            }
            catch (Exception exp)
            {
                Console.WriteLine(exp);
                MessageBox.Show("Unable to validate the username and password");
            }
        }

        private async void button3_Click(object sender, EventArgs e)
        {
        

             ForgotPassword forgotui = new ForgotPassword();
             forgotui.ShowDialog();

          
        }
        

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CognitoHelper cognitoHelper = new CognitoHelper();

            System.Diagnostics.Process.Start(cognitoHelper.GetCustomHostedURL());
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private async void button4_Click(object sender, EventArgs e)
        {
            try
            {
                CognitoHelper helper = new CognitoHelper();
                /*var req = new Amazon.CognitoIdentityProvider.Model.UpdateUserAttributesRequest();
                req.AccessToken = cognitoUser.SessionTokens.AccessToken;
                var att1 = new Amazon.CognitoIdentityProvider.Model.AttributeType();
                var att2 = new Amazon.CognitoIdentityProvider.Model.AttributeType();
                att2.Name = "custom:test2";
                att1.Name = "custom:Attribut";
                att1.Value = textBox1.Text;
                att2.Value = textBox2.Text;
                req.UserAttributes.Add(att1);
                req.UserAttributes.Add(att2);
                var result = await helper.UpdateAttributes(req);*/
                var bla = helper.getAttributes(cognitoUser).Result.UserAttributes;
                String ans = "";
                foreach(var a in bla)
                {
                    ans += a.Name + " : " + a.Value + Environment.NewLine;
                }
                MessageBox.Show(ans);  
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Some kind of error");
            }
        }
    }
}
