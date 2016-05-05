using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace MetarDecoder
{
    public partial class Form1 : Form
    {
        private string metar_vatsim = "http://metar.vatsim.net/metar.php?id=";
        private string metar;
        private string[] metar_split;
        public Form1()
        {
            InitializeComponent();
        }
        

        private string getMetar() //GET METAR FROM VATSIM WEATHER API
        {
            string metar_string = metar_vatsim + txt_icao.Text;
            WebRequest wRequest;
            try
            {
                wRequest = WebRequest.Create(metar_string);
                Stream objStream;
                objStream = wRequest.GetResponse().GetResponseStream();
                StreamReader reader = new StreamReader(objStream);
                string rx = reader.ReadToEnd();
                metar_split = rx.Split(' ');                
                return rx;
            }
            catch(Exception ex){
                return "-1";                
            }

        }

        private string getTimeZulu() //GET TIME ZULU FROM metar_split
        {            
            return metar_split[1];
        }

        private string getWind() //GET WIND FROM metar_split
        {
            return metar_split[2];
        }

        private string getVisibility() //GET VISIBILITY FROM metar_split
        {
            return metar_split[3];
        }

        private void bt_search_Click(object sender, EventArgs e)
        {            
            bt_search.Enabled = false;
            metar = getMetar();           
            bt_search.Enabled = true;
            if (metar != "-1")
            {
                lbl_metar.Text = metar;              

            }
        }
    }
}
