namespace laba
{
    partial class Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonOrder = new Button();
            labelDepartureCity = new Label();
            textBoxDepartureCity = new TextBox();
            textBoxArrivalCity = new TextBox();
            dateTimePickerDeparture = new DateTimePicker();
            dateTimePickerReturn = new DateTimePicker();
            labelDeparture = new Label();
            labelReturn = new Label();
            labelArrivalCity = new Label();
            SuspendLayout();
            // 
            // buttonOrder
            // 
            buttonOrder.Location = new Point(27, 270);
            buttonOrder.Name = "buttonOrder";
            buttonOrder.Size = new Size(186, 36);
            buttonOrder.TabIndex = 0;
            buttonOrder.Text = "Заказать";
            buttonOrder.UseVisualStyleBackColor = true;
            buttonOrder.Click += buttonOrder_Click;
            // 
            // labelDepartureCity
            // 
            labelDepartureCity.AutoSize = true;
            labelDepartureCity.Location = new Point(27, 49);
            labelDepartureCity.Name = "labelDepartureCity";
            labelDepartureCity.Size = new Size(82, 15);
            labelDepartureCity.TabIndex = 1;
            labelDepartureCity.Text = "Город вылета";
            // 
            // textBoxDepartureCity
            // 
            textBoxDepartureCity.Location = new Point(138, 41);
            textBoxDepartureCity.Name = "textBoxDepartureCity";
            textBoxDepartureCity.Size = new Size(236, 23);
            textBoxDepartureCity.TabIndex = 2;
            // 
            // textBoxArrivalCity
            // 
            textBoxArrivalCity.Location = new Point(138, 79);
            textBoxArrivalCity.Name = "textBoxArrivalCity";
            textBoxArrivalCity.Size = new Size(236, 23);
            textBoxArrivalCity.TabIndex = 3;
            // 
            // dateTimePickerDeparture
            // 
            dateTimePickerDeparture.Location = new Point(163, 170);
            dateTimePickerDeparture.Name = "dateTimePickerDeparture";
            dateTimePickerDeparture.Size = new Size(236, 23);
            dateTimePickerDeparture.TabIndex = 4;
            // 
            // dateTimePickerReturn
            // 
            dateTimePickerReturn.Location = new Point(163, 210);
            dateTimePickerReturn.Name = "dateTimePickerReturn";
            dateTimePickerReturn.ShowCheckBox = true;
            dateTimePickerReturn.Size = new Size(236, 23);
            dateTimePickerReturn.TabIndex = 5;
            // 
            // labelDeparture
            // 
            labelDeparture.AutoSize = true;
            labelDeparture.Location = new Point(27, 170);
            labelDeparture.Name = "labelDeparture";
            labelDeparture.Size = new Size(106, 15);
            labelDeparture.TabIndex = 6;
            labelDeparture.Text = "Дата вылета(Туда)";
            // 
            // labelReturn
            // 
            labelReturn.AutoSize = true;
            labelReturn.Location = new Point(27, 218);
            labelReturn.Name = "labelReturn";
            labelReturn.Size = new Size(130, 15);
            labelReturn.TabIndex = 7;
            labelReturn.Text = "Дата вылета(Обратно)";
            // 
            // labelArrivalCity
            // 
            labelArrivalCity.AutoSize = true;
            labelArrivalCity.Location = new Point(27, 87);
            labelArrivalCity.Name = "labelArrivalCity";
            labelArrivalCity.Size = new Size(88, 15);
            labelArrivalCity.TabIndex = 8;
            labelArrivalCity.Text = "Город прилета";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(443, 352);
            Controls.Add(labelArrivalCity);
            Controls.Add(labelReturn);
            Controls.Add(labelDeparture);
            Controls.Add(dateTimePickerReturn);
            Controls.Add(dateTimePickerDeparture);
            Controls.Add(textBoxArrivalCity);
            Controls.Add(textBoxDepartureCity);
            Controls.Add(labelDepartureCity);
            Controls.Add(buttonOrder);
            Name = "Register";
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonOrder;
        private Label labelDepartureCity;
        private TextBox textBoxDepartureCity;
        private TextBox textBoxArrivalCity;
        private DateTimePicker dateTimePickerDeparture;
        private DateTimePicker dateTimePickerReturn;
        private Label labelDeparture;
        private Label labelReturn;
        private Label labelArrivalCity;
    }
}