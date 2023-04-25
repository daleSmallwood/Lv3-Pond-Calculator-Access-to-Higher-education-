using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PondCalc2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Button3_Click(object sender, EventArgs e)
        {
            //do quote
            

            Boolean alertcheck = false;
            bool ok = true;

            float pondLength = 0;
            if (!float.TryParse(tbLength.Text, out pondLength))
            {
                if (alertcheck == false)
                {
                    MessageBox.Show("Please enter your measurements.");
                    alertcheck = true;
                    ok = false;
                }
            }
            if (pondLength < 1f)
            {
                if (alertcheck == false)
                {
                    MessageBox.Show("Length cannot be smaller than 1 metre.");
                    alertcheck = true;
                    ok = false;
                }
            }
            if (pondLength > 20f)
            {
                if (alertcheck == false)
                {
                    MessageBox.Show("Length cannot be greater than 20 metre.");
                    alertcheck = true;
                    ok = false;
                }
            }
            else if (pondLength < 1f)
                {
                MessageBox.Show("Length must be greater than 1.");
                ok = false;
            }
            /*
            {
                pondLength = float.Parse(tbLength.Text);
            };
            */
            float pondWidth = 0;
            if (!float.TryParse(tbWidth.Text, out pondWidth))
            {
                if (alertcheck == false)
                {
                    MessageBox.Show("Please enter your measurements.");
                    alertcheck = true;
                    ok = false;
                }
            }
            if (pondWidth < 1f)
            {
                if (alertcheck == false)
                {
                    MessageBox.Show("Width cannot be smaller than 1 metre.");
                    alertcheck = true;
                    ok = false;
                }
            }
            if (pondWidth > 20f)
            {
                if (alertcheck == false)
                {
                    MessageBox.Show("Width cannot be greater than 20 metre.");
                    alertcheck = true;
                    ok = false;
                }
            }
            else
            {
                //pondWidth = float.Parse(tbWidth.Text);
            };

            float pondDepth = 0;
            if (!float.TryParse(tbDepth.Text, out pondDepth))
            {
                if (alertcheck == false)
                {
                    MessageBox.Show("Please enter your measurements.");
                    alertcheck = true;
                    ok = false;
                }
            }
            if (pondDepth < 1f)
            {
                if (alertcheck == false)
                {
                    MessageBox.Show("Depth cannot be smaller than 1 metre.");
                    alertcheck = true;
                    ok = false;
                }
            }
            if (pondDepth > 20f)
            {
                if (alertcheck == false)
                {
                    MessageBox.Show("Depth cannot be greater than 20 metre.");
                    alertcheck = true;
                    ok = false;
                }
            }
            else
            {
                //pondDepth = float.Parse(tbDepth.Text);
            };


            if (ok == true)
            {
                //unit coversion here

                float convRatio = 0;


                if (Lengthconvert.Text == "feet")
                {
                    pondLength = pondLength / 3.281f; //covert to metric
                    pondWidth = pondWidth / 3.281f; //covert to metric
                    pondDepth = pondDepth / 3.281f; //covert to metric
                    tbLength.Text = pondLength.ToString();
                    tbWidth.Text = pondWidth.ToString();
                    tbDepth.Text = pondDepth.ToString();
                    converter_confirmbox.Text = ("converted from feet");


                }

                if (Lengthconvert.Text == "centimetres")
                {
                    pondLength = pondLength / 100; //covert to metric
                    pondWidth = pondWidth / 100; //covert to metric
                    pondDepth = pondDepth / 100; //covert to metric
                    tbLength.Text = pondLength.ToString();
                    tbWidth.Text = pondWidth.ToString();
                    tbDepth.Text = pondDepth.ToString();
                    converter_confirmbox.Text = ("converted from cm");


                }

                if (Lengthconvert.Text == "inches")
                {
                    pondLength = pondLength / 39.37f; //covert to metric
                    pondWidth = pondWidth / 39.37f; //covert to metric
                    pondDepth = pondDepth / 39.37f; //covert to metric
                    tbLength.Text = pondLength.ToString();
                    tbWidth.Text = pondWidth.ToString();
                    tbDepth.Text = pondDepth.ToString();
                    converter_confirmbox.Text = ("converted from inches");


                }


                //calculations

                float perimeter = pondLength * 2 + pondWidth * 2;
                float volume = pondLength * pondWidth * pondDepth;
                float area = pondLength * pondWidth;



                // Measurement


                float costOfHole = volume * 50;

                float costOfLiner = (pondLength + 2 * pondDepth + 1) * (pondWidth + 2 * pondDepth + 1) * 3;

                float costOfUnderlay = (pondLength + 2 * pondDepth + 1) * (pondWidth + 2 * pondDepth + 1) * 2;
                float extraCost = 0;
                float grandTotal = (costOfHole + costOfLiner + costOfUnderlay + extraCost);

                // Materials
                float edgeCost = 0;
                if (comboBox1.Text == "Concrete Paving 0.5m x 0.5m (£0.75/ea)") { edgeCost = (perimeter * 2) * 0.75f; }
                if (comboBox1.Text == "Stone Paving 0.5m x 0.5m (£2.20/ea)") { edgeCost = (perimeter * 2) * 2.20f; }
                if (comboBox1.Text == "Stone Paving 0.5m x 0.75m (£3.50/ea)") { edgeCost = (perimeter * 2) * 3.50f; }
                if (comboBox1.Text == "Plain Concrete 0.5m Wide (£4/pm)") { edgeCost = (perimeter * 2) * 4.00f; }
                if (comboBox1.Text == "Brick Paving 0.5m Wide (£20/pm)") { edgeCost = (perimeter * 2) * 20.00f; }
                if (comboBox1.Text == "Decking 0.5m Wide (£20/pm)") { edgeCost = (perimeter * 2) * 20.00f; }
                if (comboBox1.Text == "Wall 0.5m High (£60/pm)") { edgeCost = (perimeter * 2) * 60.00f; }
                if (comboBox1.Text == "Loam 0.5m Wide (£80/pm)") { edgeCost = (perimeter * 2) * 80.00f; }
                if (comboBox1.Text == "Clay 0.5m Wide (£90/pm)") { edgeCost = (perimeter * 2) * 90.00f; }

                // Extras

                if (Pump.Checked == true) { extraCost += +100; }
                if (Lights.Checked == true) { extraCost += +75; }
                if (Hornwort.Checked == true) { extraCost += (volume * 5) * 0.75f; }
                if (Mermaid_Plant.Checked == true) { extraCost += (volume * 5) * 0.55f; }
                if (Lilles.Checked == true) { extraCost += (float)Math.Floor(area * 2); }
                if (Flowering.Checked == true) { extraCost += (perimeter * 4 * 2); }
                if (Koi_carps.Checked == true) { extraCost += (volume * 3); }
                if (Algae_eater.Checked == true) { extraCost += (volume * 4); }
                if (Freshwater_mussels.Checked == true) { extraCost += (float)Math.Floor(volume * 5); }
                if (Algae_eater.Checked == true) { extraCost += +20; }

                AreaResult.Text = "" + area.ToString("0.00");
                VolumeResult.Text = "" + volume.ToString("0.00");
                tbQuote.Text = "Total cost brakedown:";
                PerimeterResult.Text = "" + perimeter.ToString("0.00");
                tbTotalResult.Clear();
                tbQuote.AppendText("\r\n Digging cost - £" + costOfHole.ToString("0.00"));
                tbQuote.AppendText("\r\n Liner - £" + costOfLiner.ToString("0.00"));
                tbQuote.AppendText("\r\n Underlay - £" + costOfUnderlay.ToString("0.00"));
                tbQuote.AppendText("\r\n Edging - £" + edgeCost.ToString("0.00"));
                tbQuote.AppendText("\r\n Extras - £" + extraCost.ToString("0.00"));
                tbTotalResult.AppendText("£" + grandTotal.ToString("0.00"));

                tabControl1.SelectedTab = tabPage4;

            }



        }
        //Name input
        private bool validation_name()
        {
            if (tbFirstNameBox.Text == "Please enter First name" || tbFirstNameBox.Text == "")
            {
                tabControl1.SelectedTab = tabPage1;
                return false;
            }
            if (tbLastNameBox.Text == "Please enter Last name" || tbLastNameBox.Text == "")
            {
                tabControl1.SelectedTab = tabPage1;
                return false;
            }
            if (tbAddressBox.Text == "Please enter full address" || tbAddressBox.Text == "")
            {
                tabControl1.SelectedTab = tabPage1;
                return false;
            }
            return true;
            
        }


        private void AreaResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //Pond size
        private void TbLength_Click(object sender, EventArgs e)
        {
            tbLength.Text = "";
        }

        private void TbWidth_Click(object sender, EventArgs e)
        {
            tbWidth.Text = "";
        }

        private void TbDepth_Click(object sender, EventArgs e)
        {
            tbDepth.Text = "";
        }

        private void TabControl1_Click(object sender, EventArgs e)
        {

        }

        private void TotalResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            {

            }
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            {

            }
        }

        private void TbAddressBox_Click(object sender, EventArgs e)
        {
            tbAddressBox.Text = "";
        }

        private void TbAddressBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TbLastNameBox_Click(object sender, EventArgs e)
        {
            tbLastNameBox.Text = "";
        }

        private void TbFirstNameBox_Click(object sender, EventArgs e)
        {
            tbFirstNameBox.Text = "";
        }

        private void Converter_confirmbox_TextChanged(object sender, EventArgs e)
        {
        }

        private void Lengthconvert_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Lengthconvert.Text)
            {
                case "metres": converter_confirmbox.Visible = false;
                    break;
                default: converter_confirmbox.Visible = true;
                    break;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (validation_name() == true)
            {
                tabControl1.SelectedTab = tabPage2;
            }
        }

        private void SubmitButtonExtras_Click(object sender, EventArgs e)
        {

            tabControl1.SelectedTab = tabPage3;
            
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }
        
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(this.tbQuote.Text, this.tbQuote.Font, Brushes.Black, new Point(10, 10) );
        }


        //Save and print button
        private void PrintButton_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog(); printDocument1.PrintPage += printDocument1_PrintPage;
            tabControl1.SelectedTab = tabPage5;

            
        }
        //Exit application
        private void Exit_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void TbLength_TextChanged(object sender, EventArgs e)
        {

        }

        private void PictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.TransparencyKey = BackColor;
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            validation_name();
        }

        private void CheckedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TbQuote_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
