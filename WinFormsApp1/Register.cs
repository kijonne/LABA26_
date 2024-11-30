using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            dateTimePickerDeparture.Format = DateTimePickerFormat.Custom;
            dateTimePickerDeparture.CustomFormat = "dd.MM.yyyy";

            dateTimePickerReturn.Format = DateTimePickerFormat.Custom;
            dateTimePickerReturn.CustomFormat = "dd.MM.yyyy";
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            string departureCity = textBoxDepartureCity.Text;
            string arrivalCity = textBoxArrivalCity.Text;
            string departureDate = dateTimePickerDeparture.Value.ToString("dd.MM.yyyy");

            
            string orderInfo = $"Билет: {departureDate} {departureCity} - {arrivalCity}";

            
            if (dateTimePickerReturn.Checked)
            {
                string returnDate = dateTimePickerReturn.Value.ToString("dd.MM.yyyy");
                orderInfo += $"\nОбратный билет: {returnDate} {arrivalCity} - {departureCity}";
            }

            
            MessageBox.Show(orderInfo, "Информация о заказе");
        }

    }
}

