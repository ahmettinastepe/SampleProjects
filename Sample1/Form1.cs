using System;
using System.Globalization;
using System.Windows.Forms;

namespace Sample1
{
    public partial class Form1 : Form
    {
        CultureInfo turkey = CultureInfo.GetCultureInfo("tr-TR");

        public Form1()
        {
            InitializeComponent();
            cmbDateAppointment.SelectedIndex = 0;
        }

        void AddAppointment()
        {
            if (string.IsNullOrEmpty(txtNameSurname.Text))
            {
                MessageBox.Show("Lütfen Ad Soyad Alanını Doldurun");
                txtNameSurname.Focus();
                return;
            }

            int dateAppointmentSum = (cmbDateAppointment.SelectedIndex + 1) * 7;
            DateTime date = dtInspectionDate.Value.AddDays(dateAppointmentSum);
            int day = (int)date.DayOfWeek;
            DateTime newDate = new DateTime();

            if (turkey.DateTimeFormat.DayNames[day] == "Pazar")
                newDate = date.AddDays(-1);


            string item = $"{txtNameSurname.Text};{newDate.ToLongDateString()}";
            listGivenAppointments.Items.Add(item);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddAppointment();
        }
    }
}