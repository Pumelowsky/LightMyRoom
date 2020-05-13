using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Collections.Specialized;
using System.Net;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Net.NetworkInformation;
using System.IO.Ports;

namespace LightMyRoom
{
    public partial class LightMyRoom : Form
    {

        //do_ruszania_form
        int mov;
        int movX;
        int movY;
        bool isConnected = false;
        int r = 0, b = 0, g = 0;
        String[] ports;
        SerialPort port;
      

        private Color defaultColor = Color.FromArgb(0, 0, 0);


        public LightMyRoom()
        {
            InitializeComponent();
            getAvailableComPorts();

            foreach (string port in ports)
            {
                comboBox1.Items.Add(port);
                Console.WriteLine(port);
                if (ports[0] != null)
                {
                    comboBox1.SelectedItem = ports[0];
                }
            }
            string version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            vers.Text += version.Substring(0, 3);
            auth.Text += fvi.CompanyName;
            auth.Text += " | ";
            auth.Text += fvi.LegalCopyright;

            r_val.Text = bunifuSlider1.Value.ToString();
            g_val.Text = bunifuSlider2.Value.ToString();
            b_val.Text = bunifuSlider3.Value.ToString();

            r = bunifuSlider1.Value;
            g = bunifuSlider2.Value;
            b = bunifuSlider3.Value;

            chuj.Text = "DISCONNECTED";
            chuj.ForeColor = Color.Red;

            act_col.ProgressColor = Color.FromArgb(r, g, b);
            modeDropdown.Select();
        }
        
        void getAvailableComPorts()
        {
            ports = SerialPort.GetPortNames();
        }

        private void changeTheme()
        {

        }
        private void connectToArduino()
        {
            string selectedPort = comboBox1.GetItemText(comboBox1.SelectedItem);
            port = new SerialPort(selectedPort, 9600, Parity.None, 8, StopBits.One);
            Console.WriteLine(port.IsOpen);
            isConnected = true;
            port.Open();
            this.SetColor(defaultColor);
            button19.Text = "DISCONNECT FROM SERIAL PORT";
            chuj.Text = "CONNECTED";
            chuj.ForeColor = Color.Green;
            
        }

        private void disconnectFromArduino()
        {
            isConnected = false;
            this.SetColor(defaultColor);
            port.Close();
            button19.Text = "CONNECT TO SERIAL PORT";
            chuj.Text = "DISCONNECTED";
            chuj.ForeColor = Color.Red;
        }




        private void SetColor(Color color)
        {
            // Update color in the panel

            // Write color to Arduino
            port.Write(new[] { color.R, color.G, color.B }, 0, 3);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void close_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Logo_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Process.Start("http://pumelowsky.pl");

        }

        private void auth_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://pumelowsky.pl");
        }

        private void LightMyRoom_Load(object sender, EventArgs e)
        {
           
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }
        private void error_Click(object sender, EventArgs e)
        {

        }

        private void lighting_btn_Click(object sender, EventArgs e)
        {
            arduino_pan.Visible = false;
            panel3.Visible = false;
            lighting_pan.Visible = true;
            lighting_btn.ForeColor = Color.FromArgb(241, 196, 15);
            arduino_btn.ForeColor = Color.FromArgb(236, 240, 241);
            wifi_btn.ForeColor = Color.FromArgb(236, 240, 241);
        }

        private void arduino_btn_Click(object sender, EventArgs e)
        {
            lighting_pan.Visible = false;
            arduino_pan.Visible = true;
            panel3.Visible = false;
            lighting_btn.ForeColor = Color.FromArgb(236, 240, 241);
            arduino_btn.ForeColor = Color.FromArgb(194, 54, 22);
            wifi_btn.ForeColor = Color.FromArgb(236, 240, 241);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void net_lab_Click(object sender, EventArgs e)
        {

        }

        private void bunifuSlider1_ValueChanged(object sender, EventArgs e)
        {
            r_val.Text = bunifuSlider1.Value.ToString();
            r= bunifuSlider1.Value;
            act_col.ProgressColor = Color.FromArgb(r, g, b);
        }

        private void bunifuSlider2_ValueChanged(object sender, EventArgs e)
        {
            g_val.Text = bunifuSlider2.Value.ToString();
            g = bunifuSlider2.Value;
            act_col.ProgressColor = Color.FromArgb(r, g, b);
        }

        private void bunifuSlider3_ValueChanged(object sender, EventArgs e)
        {
            b_val.Text = bunifuSlider3.Value.ToString();
            b = bunifuSlider3.Value;
            act_col.ProgressColor = Color.FromArgb(r, g, b);
        }

        private void upload_btn_Click(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                DialogResult result2 = MessageBox.Show("Error: Device not connected",
                                                       "Error",
                                                       MessageBoxButtons.OK,
                                                       MessageBoxIcon.Error);
            }
            else
            {
                rainbowTimer.Enabled = false;
                flashTimer.Enabled = false;
                policeTimer.Enabled = false;
                int czerw = bunifuSlider1.Value;
                int ziel = bunifuSlider2.Value;
                int nieb = bunifuSlider3.Value;
                this.SetColor(Color.FromArgb(czerw, ziel, nieb));
            }
        }

        private void wifi_btn_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            arduino_pan.Visible = false;
            lighting_pan.Visible = false;
            lighting_btn.ForeColor = Color.FromArgb(236, 240, 241);
            arduino_btn.ForeColor = Color.FromArgb(236, 240, 241);
            wifi_btn.ForeColor = Color.FromArgb(25, 42, 86);
        }

        private void themeSwitch_Click(object sender, EventArgs e)
        {
            if(themeSwitch.Value==false)
            {
               
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["arduino"] == null)
            {
                arduino f = new arduino();
                f.Show();
            }
        }

        int rain_r = 255, rain_g = 0, rain_b = 0;

        private void rainbow_apply_Click(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                DialogResult result2 = MessageBox.Show("Error: Device not connected",
                                                       "Error",
                                                       MessageBoxButtons.OK,
                                                       MessageBoxIcon.Error);
            }
            else
            {
                rainbowTimer.Enabled = true;
                flashTimer.Enabled = false;
                policeTimer.Enabled = false;
                rainbowTimer.Interval = 1;
            }
        }

        private void rainbowTimer_Tick(object sender, EventArgs e)
        {
            this.SetColor(Color.FromArgb(rain_r, rain_g, rain_b));

            if (rain_r > 0 && rain_b == 0)
            {
                rain_r--;
                rain_g++;
            }
            if (rain_g > 0 && rain_r == 0)
            {
                rain_g--;
                rain_b++;
            }
            if (rain_b > 0 && rain_g == 0)
            {
                rain_b--;
                rain_r++;
            }
        }

        private void modeDropdown_onItemSelected(object sender, EventArgs e)
        {
            if(modeDropdown.selectedIndex == 0)
            {
                staticPanel.Visible = true;
                rainbowPanel.Visible = false;
                flashPanel.Visible = false;
                policePanel.Visible = false;
            }
            else
            if (modeDropdown.selectedIndex == 1)
            {
                staticPanel.Visible = false;
                rainbowPanel.Visible = true;
                flashPanel.Visible = false;
                policePanel.Visible = false;

            } 
            else
            if(modeDropdown.selectedIndex == 2)
            { 
                staticPanel.Visible = false;
                rainbowPanel.Visible = false;
                flashPanel.Visible = true;
                policePanel.Visible = false;
            }
            else
            if (modeDropdown.selectedIndex == 3)
            {
                staticPanel.Visible = false;
                rainbowPanel.Visible = false;
                flashPanel.Visible = false;
                policePanel.Visible = true;
            }
        }

        int flash_state = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            if(flash_state == 0)
            {
                flashbtn.ProgressColor = Color.FromArgb(255, 255, 255);
                flash_state = 1;
            }
            else
                if(flash_state == 1)
                {
                    flashbtn.ProgressColor = Color.FromArgb(0, 0, 0);
                    flash_state = 0;
                }
        }
        int police_state = 0;
        private void timer3_Tick(object sender, EventArgs e)
        {
            if (police_state == 0)
            {
                policebtn.ProgressColor = Color.FromArgb(255, 0, 0);
                police_state = 1;
            }
            else
                if (police_state == 1)
                {
                    policebtn.ProgressColor = Color.FromArgb(0, 0, 255);
                    police_state = 0;
                }
        }
        int fl_state = 0;
        private void flashTimer_Tick(object sender, EventArgs e)
        {
            if (fl_state == 0)
            {
                SetColor(Color.FromArgb(255, 255, 255));
                fl_state = 1;
            }
            else
                if (fl_state == 1)
            {
                SetColor(Color.FromArgb(0, 0, 0));
                fl_state = 0;
            }
        }

        private void policeApply_Click(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                DialogResult result2 = MessageBox.Show("Error: Device not connected",
                                                       "Error",
                                                       MessageBoxButtons.OK,
                                                       MessageBoxIcon.Error);
            }
            else
            {
                rainbowTimer.Enabled = false;
                flashTimer.Enabled = false;
                policeTimer.Enabled = true;
            }
        }

        private void flashapply_Click(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                DialogResult result2 = MessageBox.Show("Error: Device not connected",
                                                       "Error",
                                                       MessageBoxButtons.OK,
                                                       MessageBoxIcon.Error);
            }
            else
            {
                rainbowTimer.Enabled = false;
                flashTimer.Enabled = true;
                policeTimer.Enabled = false;
            }
        }
        int pl_state = 0;
        private void policeTimer_Tick(object sender, EventArgs e)
        {
            if (pl_state == 0)
            {
                SetColor(Color.FromArgb(255, 0, 0));
                pl_state = 1;
            }
            else
                if (pl_state == 1)
            {
                SetColor(Color.FromArgb(0, 0, 255));
                pl_state = 0;
            }
        }

        int rainbow_r = 255, rainbow_g = 0, rainbow_b = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            rainbow_btn.ProgressColor = Color.FromArgb(rainbow_r, rainbow_g, rainbow_b);

            if(rainbow_r > 0 && rainbow_b == 0)
            {
                rainbow_r--;
                rainbow_g++;
            }
            if(rainbow_g > 0 && rainbow_r == 0)
            {
                rainbow_g--;
                rainbow_b++;
            }
            if(rainbow_b > 0 && rainbow_g == 0)
            {
                rainbow_b--;
                rainbow_r++;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                connectToArduino();
            }
            else
            {
                disconnectFromArduino();
            }
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }
    }

}
