using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MedicalCardApp.Classes;

namespace MedicalCardApp.Formes
{
    public partial class EntityDetailsForm : Form
    {
        /// <summary>
        /// Инициализирует новый экземпляр формы с деталями указанной сущности
        /// </summary>
        public EntityDetailsForm(object entity, string entityType)
        {
            InitializeComponent();
            LoadEntityDetails(entity, entityType);
        }

        /// <summary>
        /// Загружает и отображает детальную информацию о сущности в зависимости от её типа
        /// </summary>
        private void LoadEntityDetails(object entity, string entityType)
        {
            if (entityType == "Doctors" && entity is Doctor d)
            {
                Text = "Информация о враче";
                labelTitle.Text = $"ВРАЧ: {d.FullName}";
                AddRow("ID:", d.Id.ToString());
                AddRow("ФИО:", d.FullName);
                AddRow("Специализация:", d.Specialization);
                AddRow("Телефон:", d.Phone);
                AddRow("Место работы:", d.WorkAddressString);
                AddRow("Рабочие дни:", d.WorkingDaysString);
                if (d.WorkAddress != null)
                {
                    AddSeparator();
                    AddRow("Клиника:", d.WorkAddress.ClinicName);
                    AddRow("Город:", d.WorkAddress.City);
                    AddRow("Улица:", d.WorkAddress.Street);
                    AddRow("Дом:", d.WorkAddress.Building);
                }
            }
            else if (entityType == "Patients" && entity is Patient p)
            {
                Text = "Информация о пациенте";
                labelTitle.Text = $"ПАЦИЕНТ: {p.FullName}";
                AddRow("ID:", p.Id.ToString());
                AddRow("ФИО:", p.FullName);
                AddRow("Дата рождения:", p.BirthDateString);
                AddRow("Возраст:", p.Age.ToString());
                AddRow("Телефон:", p.Phone);
                AddRow("Группа крови:", p.BloodType);
                AddRow("Паспорт:", p.PassportNumber);
                AddRow("Адрес:", p.HomeAddressString);
                if (p.HomeAddress != null)
                {
                    AddSeparator();
                    AddRow("Город:", p.HomeAddress.City);
                    AddRow("Улица:", p.HomeAddress.Street);
                    AddRow("Дом:", p.HomeAddress.Building);
                }
            }
            else if (entityType == "Diseases" && entity is Disease dis)
            {
                Text = "Информация о болезни";
                labelTitle.Text = $"БОЛЕЗНЬ: {dis.Name}";
                AddRow("ID:", dis.Id.ToString());
                AddRow("Название:", dis.Name);
                AddRow("Тяжесть:", dis.Severity);
                AddRow("Код МКБ-10:", dis.IcdCode);
                AddRow("Длительность:", dis.DurationDays > 0 ? $"{dis.DurationDays} дней" : "Хроническое");
                AddRow("Симптомы:", dis.SymptomsString);
                AddRow("Лечение:", dis.Treatment);
            }
        }

        /// <summary>
        /// Добавляет строку с парой "название поля - значение" в панель деталей
        /// </summary>
        private void AddRow(string label, string value)
        {
            Panel p = new Panel { Dock = DockStyle.Top, Height = 35, Margin = new Padding(0, 2, 0, 2) };
            p.Controls.Add(new Label { Text = label, Location = new Point(10, 8), Size = new Size(150, 25), Font = new Font("Segoe UI", 10, FontStyle.Bold) });
            p.Controls.Add(new Label { Text = value, Location = new Point(170, 8), Size = new Size(450, 25), Font = new Font("Segoe UI", 10) });
            panelDetails.Controls.Add(p);
            panelDetails.Controls.SetChildIndex(p, 0);
        }

        /// <summary>
        /// Добавляет визуальный разделитель (серую полосу) между логическими блоками информации
        /// </summary>
        private void AddSeparator()
        {
            Panel p = new Panel { Dock = DockStyle.Top, Height = 30, BackColor = System.Drawing.Color.LightGray };
            panelDetails.Controls.Add(p);
            panelDetails.Controls.SetChildIndex(p, 0);
        }

        /// <summary>
        /// Обработчик нажатия кнопки закрытия формы
        /// </summary>
        private void buttonClose_Click(object sender, EventArgs e) => Close();
    }
}