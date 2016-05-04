using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Web;
using Nemiro.OAuth;
using Nemiro.OAuth.LoginForms;
using System.IO;




namespace dropboxRest
{
    public partial class Form1 : Form
    {

        private string CurrentPath = "/";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
            if (String.IsNullOrEmpty(Properties.Settings.Default.AccessToken))
            {
                this.GetAccessToken();
            }
            else
            {
              //  this.GetFiles();
            }
        }

        
        private void GetAccessToken()
        {
            var login = new DropboxLogin("38n9jjy399a6jqa", "dneyth53kc841hb");
            login.Owner = this;
            login.ShowDialog();

            if (login.IsSuccessfully)
            {
                Properties.Settings.Default.AccessToken = login.AccessToken.Value;
                Properties.Settings.Default.Save();
            }
            else 
            {
                MessageBox.Show("error....");
            }
            
        }

   
        private void Upload_Result(RequestResult result)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action<RequestResult>(Upload_Result), result);
                return;
            }
            if (result.StatusCode == 200)
            {
               // this.GetFiles();

            }
            else
            {
                if (result["error"].HasValue)
                {
                    MessageBox.Show(result["error"].ToString());
                }
                else
                {
                    MessageBox.Show(result.ToString());
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            label3.Text = "";
            try
            {
                GenerateTXT(txtTitle.Text, txtURL.Text);
                
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.ToString(), "error");
            }
            
            OAuthUtility.PutAsync(
            "https://content.dropboxapi.com/1/files_put/auto",
            new HttpParameterCollection 
                { 
                    {"access_token", Properties.Settings.Default.AccessToken},                    
                    {"path", Path.Combine(this.CurrentPath,"test.xml").Replace("\\", "/")},
                    {"update","true"},
                    {"autorename","true"},
                    {File.Open("test.xml",FileMode.Open)}
                },
            callback: Upload_Result
            );

            label3.Text = "Done";


        }

        private void GenerateTXT(string titletext, string urltext)
        {


            if (titletext == "")
            {
                titletext = "Movie";
            }
            
            // Write the string to a file.
            System.IO.StreamWriter file = new System.IO.StreamWriter("test.xml");
            file.WriteLine("<?xml version=\"1.0\" encoding=\"UTF-8\" ?>");
            file.WriteLine("<items>");
            file.WriteLine("<playlist_name>Dropbox</playlist_name>");
            file.WriteLine("<channel>");
            file.WriteLine("<title>"+titletext+"</title>");
            file.WriteLine("<stream_url>" + urltext + "</stream_url>");
            file.WriteLine("<logo_30x30></logo_30x30>");
            file.WriteLine("<description>" + titletext + "</description>");
            file.WriteLine("<category_id>1</category_id>");
            file.WriteLine("</channel>");
            file.WriteLine("</items>");
            file.Close();



        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtURL.Text = Clipboard.GetText();
        }

        private void txtTitle_Click(object sender, EventArgs e)
        {
            txtTitle.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {

            OAuthUtility.PostAsync(
            "https://api.dropboxapi.com/1/shares/auto/",
            new HttpParameterCollection 
                { 
                    {"access_token", Properties.Settings.Default.AccessToken},                    
                    {"path", Path.Combine(this.CurrentPath,"test.xml").Replace("\\", "/")},
                    {"short_url","false"}
                },
            callback: Shares_Result
            );
        }

        private void Shares_Result(RequestResult result)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action<RequestResult>(Shares_Result), result);
                return;
            }
            if (result.StatusCode == 200)
            {
                txtShareURL.Text = "";
                txtShareURL.Text = "sample: "+"https://dl.dropboxusercontent.com/s/6xgxm6pah3le3vh/test.xml" + "\n";
                txtShareURL.Text = txtShareURL.Text + "test.xml shared link: "+result["url"].ToString();

               // listBox1.Items.Clear();
                //foreach (UniValue file in result["contents"])
                //{
                //    listBox1.Items.Add(file["path"].ToString());
                //}


            }
            else
            {
                MessageBox.Show("error....");
            }

        }

        
    }
}
