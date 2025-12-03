using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace DataBase_APM_Dentist
{
    public partial class Main_form : Form
    {
        private bool addButtonClicked = false;
        Register_form registerForm = new Register_form();
        public Main_form()
        {
            InitializeComponent();
        }


        private void Main_form_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "DentistDBDataSet1.PatientServicesCost". При необходимости она может быть перемещена или удалена.
            this.PatientServicesCostTableAdapter.Fill(this.DentistDBDataSet1.PatientServicesCost);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "DentistDBDataSet1.AppointmentDetails". При необходимости она может быть перемещена или удалена.
            this.AppointmentDetailsTableAdapter.Fill(this.DentistDBDataSet1.AppointmentDetails);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dentistDBDataSet.position". При необходимости она может быть перемещена или удалена.
            this.positionTableAdapter.Fill(this.dentistDBDataSet.position);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dentistDBDataSet.patient". При необходимости она может быть перемещена или удалена.
            this.patientTableAdapter.Fill(this.dentistDBDataSet.patient);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dentistDBDataSet.appointment". При необходимости она может быть перемещена или удалена.
            this.appointmentTableAdapter.Fill(this.dentistDBDataSet.appointment);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dentistDBDataSet.favor". При необходимости она может быть перемещена или удалена.
            this.favorTableAdapter.Fill(this.dentistDBDataSet.favor);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dentistDBDataSet.employee". При необходимости она может быть перемещена или удалена.
            this.employeeTableAdapter.Fill(this.dentistDBDataSet.employee);

            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            employeeBindingSource2.AddNew();
            addButtonClicked = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            employeeBindingSource2.EndEdit();
            employeeTableAdapter.Update(dentistDBDataSet.employee);
            if (addButtonClicked)
            {
                addButtonClicked = false;
                if (dataGridView1.Rows.Count > 0)
                {
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Selected = true;
                }
            }
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            employeeBindingSource2.RemoveCurrent();
            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.ClearSelection();
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Selected = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            registerForm.Show();
            Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            employeeBindingSource2.MoveFirst();
            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.ClearSelection();
                dataGridView1.Rows[0].Selected = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            employeeBindingSource2.MoveLast();
            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.ClearSelection();
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Selected = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            employeeBindingSource2.MovePrevious();
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;

                if (index > 0)
                {
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[index - 1].Selected = true;
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            employeeBindingSource2.MoveNext();
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;

                if (index < dataGridView1.Rows.Count - 1)
                {
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[index + 1].Selected = true;
                }
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            favorBindingSource2.AddNew();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            favorBindingSource2.EndEdit();
            favorTableAdapter.Update(dentistDBDataSet.favor);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            favorBindingSource2.RemoveCurrent();
            if (dataGridView2.Rows.Count > 0)
            {
                dataGridView2.ClearSelection();
                dataGridView2.Rows[dataGridView2.Rows.Count - 1].Selected = true;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            registerForm.Show();
            Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            favorBindingSource2.MoveFirst();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            favorBindingSource2.MoveLast();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            favorBindingSource2.MovePrevious();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            favorBindingSource2.MoveNext();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            appointmentBindingSource2.AddNew();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            try
            {
                appointmentBindingSource2.EndEdit();
                appointmentTableAdapter.Update(dentistDBDataSet.appointment);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            appointmentBindingSource2.RemoveCurrent();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            registerForm.Show();
            Visible = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            appointmentBindingSource2.MoveFirst();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            appointmentBindingSource2.MoveLast();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            appointmentBindingSource2.MovePrevious();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            appointmentBindingSource2.MoveNext();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            patientBindingSource2.AddNew();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            patientBindingSource2.EndEdit();
            patientTableAdapter.Update(dentistDBDataSet.patient);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            patientBindingSource2.RemoveCurrent();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            registerForm.Show();
            Visible = false;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            patientBindingSource2.MoveFirst();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            patientBindingSource2.MoveLast();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            patientBindingSource2.MovePrevious();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            patientBindingSource2.MoveNext();
        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void button40_Click(object sender, EventArgs e)
        {
            positionBindingSource2.AddNew();
        }

        private void button39_Click(object sender, EventArgs e)
        {
            positionBindingSource2.EndEdit();
            positionTableAdapter.Update(dentistDBDataSet.position);
        }

        private void button38_Click(object sender, EventArgs e)
        {
            positionBindingSource2.RemoveCurrent();
        }

        private void button37_Click(object sender, EventArgs e)
        {
            registerForm.Show();
            Visible = false;
        }

        private void button33_Click(object sender, EventArgs e)
        {
            positionBindingSource2.MoveFirst();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            positionBindingSource2.MoveLast();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            positionBindingSource2.MovePrevious();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            positionBindingSource2.MoveNext();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }
        private void tabPage6_Enter(object sender, EventArgs e)
        {
            /*SqlConnection connection = new SqlConnection("Data Source=Nikitos;Initial Catalog=DentistDB;Integrated Security=True");
            string queryString = "Select * From AppointmentDetails";
            SqlDataAdapter adapter = new SqlDataAdapter(queryString, connection);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            adapter.Dispose();*/
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

    }
}
