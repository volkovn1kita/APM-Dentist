using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase_APM_Dentist
{
    public partial class EmployeeForm : Form
    {
        Register_form registerForm = new Register_form();
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EmployeeForm_Load(object sender, EventArgs e)
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

        private void button4_Click_1(object sender, EventArgs e)
        {
            registerForm.Show();
            Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            employeeBindingSource.MoveNext();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            employeeBindingSource.MovePrevious();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            employeeBindingSource.MoveFirst();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            employeeBindingSource.MoveLast();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            registerForm.Show();
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            favorBindingSource.MoveLast();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            favorBindingSource.MoveFirst();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            favorBindingSource.MovePrevious();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            favorBindingSource.MoveNext();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            registerForm.Show();
            Visible = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            appointmentBindingSource.MoveLast();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            appointmentBindingSource.MoveFirst();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            appointmentBindingSource.MovePrevious();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            appointmentBindingSource.MoveNext();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            registerForm.Show();
            Visible = false;
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            patientBindingSource.MoveLast();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            patientBindingSource.MoveFirst();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            patientBindingSource.MovePrevious();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            patientBindingSource.MoveNext();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            positionBindingSource.MoveNext();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            positionBindingSource.MovePrevious();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            positionBindingSource.MoveFirst();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            positionBindingSource.MoveLast();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            registerForm.Show();
            Visible = false;
        }
    }
}
