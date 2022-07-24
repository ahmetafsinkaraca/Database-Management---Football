using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ahmet_180201802_week_11_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {   
            // TODO: Bu kod satırı 'dataSet11.Team' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.teamTableAdapter.Fill(this.dataSet11.Team);
            // TODO: Bu kod satırı 'dataSet11.Team' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.teamTableAdapter.Fill(this.dataSet11.Team);
            // TODO: Bu kod satırı 'dataSet11.Enroll' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.enrollTableAdapter.Fill(this.dataSet1.Enroll);
            // TODO: Bu kod satırı 'dataSet11.Parent' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.parentTableAdapter.Fill(this.dataSet1.Parent);
            // TODO: Bu kod satırı 'dataSet11.Coach' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.coachTableAdapter.Fill(this.dataSet1.Coach);
            // TODO: Bu kod satırı 'dataSet1.Player' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.playerTableAdapter.Fill(this.dataSet1.Player);
            // TODO: Bu kod satırı 'dataSet1.Team' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.teamTableAdapter.Fill(this.dataSet1.Team);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.teamTableAdapter.InsertQuery(textBox1.Text, textBox2.Text);
            this.teamTableAdapter.Fill(this.dataSet1.Team);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int PL_ID, T_ID;

            int.TryParse(textBox5.Text, out PL_ID);
            int.TryParse(comboBox1.SelectedValue.ToString(), out T_ID);

            this.playerTableAdapter.InsertQuery(textBox3.Text, textBox4.Text, PL_ID, T_ID);
            this.playerTableAdapter.Fill(this.dataSet1.Player);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int C_ID, T_ID;

            int.TryParse(textBox8.Text, out C_ID);
            int.TryParse(comboBox2.SelectedValue.ToString(), out T_ID);

            this.coachTableAdapter.InsertQuery(textBox6.Text, textBox7.Text, C_ID, T_ID);
            this.coachTableAdapter.Fill(this.dataSet1.Coach);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int PR_ID;
            int.TryParse(textBox11.Text, out PR_ID);
            this.parentTableAdapter.InsertQuery(textBox9.Text, textBox10.Text, PR_ID, textBox12.Text);
            this.parentTableAdapter.Fill(this.dataSet1.Parent);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int PL_ID, PR_ID;
            int.TryParse(comboBox3.SelectedValue.ToString(), out PL_ID);
            int.TryParse(comboBox4.SelectedValue.ToString(), out PR_ID);
            this.enrollTableAdapter.InsertQuery(PL_ID, PR_ID);
            this.enrollTableAdapter.Fill(this.dataSet1.Enroll);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int ID;
            int.TryParse(textBox13.Text, out ID);
            textBox14.Text = this.teamTableAdapter.ScalarQuery(ID);
            textBox15.Text = this.teamTableAdapter.ScalarQuery(ID);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int ID;
            int.TryParse(textBox13.Text, out ID);
            this.teamTableAdapter.UpdateQuery(textBox14.Text, textBox15.Text, ID);
            this.teamTableAdapter.Fill(this.dataSet1.Team);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int ID;
            int.TryParse(textBox13.Text, out ID);
            this.teamTableAdapter.DeleteQuery(ID);
            this.teamTableAdapter.Fill(this.dataSet1.Team);

            this.playerTableAdapter.UpdateQuery_Delete_Team1(ID);
            this.playerTableAdapter.Fill(this.dataSet1.Player);

            this.coachTableAdapter.UpdateQuery_Delete_Team2(ID);
            this.coachTableAdapter.Fill(this.dataSet1.Coach);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int ID;
            int.TryParse(textBox19.Text, out ID);
            textBox16.Text = this.playerTableAdapter.ScalarQuery(ID);
            textBox17.Text = this.playerTableAdapter.ScalarQuery1(ID);

        }

        private void button10_Click(object sender, EventArgs e)
        {
            int Age, ID, T_ID;
            int.TryParse(textBox18.Text, out Age);
            int.TryParse(textBox19.Text, out ID);
            int.TryParse(comboBox1.SelectedValue.ToString(), out T_ID);
            this.playerTableAdapter.UpdateQuery(textBox16.Text, textBox17.Text, Age, ID, T_ID);
            this.playerTableAdapter.Fill(this.dataSet1.Player);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int ID;
            int.TryParse(textBox19.Text, out ID);
            this.playerTableAdapter.DeleteQuery(ID);
            this.playerTableAdapter.Fill(this.dataSet1.Player);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int ID;
            int.TryParse(textBox19.Text, out ID);
            textBox16.Text = this.coachTableAdapter.ScalarQuery(ID);
            textBox17.Text = this.coachTableAdapter.ScalarQuery1(ID);

        }

        private void button13_Click(object sender, EventArgs e)
        {
            int Phone, ID, T_ID;
            int.TryParse(textBox22.Text, out Phone);
            int.TryParse(textBox23.Text, out ID);
            int.TryParse(comboBox2.SelectedValue.ToString(), out T_ID);
            this.coachTableAdapter.UpdateQuery(textBox20.Text, textBox21.Text, Phone, ID, T_ID);
            this.coachTableAdapter.Fill(this.dataSet1.Coach);
        }
        private void button14_Click(object sender, EventArgs e)
        {
            int ID;
            int.TryParse(textBox19.Text, out ID);
            this.coachTableAdapter.DeleteQuery(ID);
            this.coachTableAdapter.Fill(this.dataSet1.Coach);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int ID;
            int.TryParse(textBox28.Text, out ID);
            textBox24.Text = this.parentTableAdapter.ScalarQuery(ID);
            textBox25.Text = this.parentTableAdapter.ScalarQuery1(ID);
            textBox27.Text = this.parentTableAdapter.ScalarQuery2(ID);

        }

        private void button16_Click(object sender, EventArgs e)
        {
            int  ID, Phone;
            int.TryParse(textBox26.Text, out Phone);
            int.TryParse(textBox28.Text, out ID);
            this.parentTableAdapter.UpdateQuery(textBox24.Text, textBox25.Text, Phone, textBox27.Text, ID);
            this.parentTableAdapter.Fill(this.dataSet1.Parent);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            int ID;
            int.TryParse(textBox28.Text, out ID);
            this.parentTableAdapter.DeleteQuery(ID);
            this.parentTableAdapter.Fill(this.dataSet1.Parent);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            int ID;
            int.TryParse(textBox29.Text, out ID);
            textBox24.Text = this.parentTableAdapter.ScalarQuery(ID);
            textBox24.Text = this.parentTableAdapter.ScalarQuery1(ID);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            int ID, PL_ID, PR_ID;
            int.TryParse(textBox29.Text, out ID);
            int.TryParse(comboBox3.SelectedValue.ToString(), out PL_ID);
            int.TryParse(comboBox4.SelectedValue.ToString(), out PR_ID);
            this.enrollTableAdapter.UpdateQuery(PL_ID, PR_ID, ID);
            this.enrollTableAdapter.Fill(this.dataSet1.Enroll);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            int ID;
            int.TryParse(textBox29.Text, out ID);
            this.enrollTableAdapter.DeleteQuery(ID);
            this.enrollTableAdapter.Fill(this.dataSet1.Enroll);
        }
    }
}

 