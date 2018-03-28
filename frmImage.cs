using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RapidAPISDK;

namespace Control_ICL1904
{
    public partial class frmImage : Form
    {
        private static RapidAPI RapidApi = new RapidAPI("spacejunk", "05459df4-a228-4e2a-b08d-53527b71ed2b");
        public frmImage()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmImage_Load(object sender, EventArgs e)
        {
            List<Parameter> body = new List<Parameter>();

            body.Add(new DataParameter("apiKey", ""));
            body.Add(new DataParameter("date", ""));
            body.Add(new DataParameter("highResolution", "True"));


            try
            {
                int cnt1;
                cnt1 = 0;
                Dictionary<string, object> response = RapidApi.Call("NasaAPI", "getPictureOfTheDay", body.ToArray()).Result;
                object payload;
                if (response.TryGetValue("success", out payload))
                {
                    foreach (KeyValuePair<string, object> pair in response)

                    {
                        cnt1++;
                        if (cnt1 == 2)
                        {
                            lbldesc.Text = pair.Value.ToString();
                        }
                        if (cnt1 == 6)
                        {
                            lbltitle.Text = pair.Value.ToString();
                        }
                        if (cnt1 == 3)
                        {
                            image1.Load(pair.Value.ToString());
                        }

                    }

                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}
