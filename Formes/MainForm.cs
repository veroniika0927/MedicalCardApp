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
    public partial class MainForm : Form
    {
        private MedicalDataContainer data;
        private string currentEntityType;

        /// <summary>
        /// Инициализирует главную форму приложения и настраивает обработчики событий
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            ClearAllData();
            InitializeTreeView();
            LoadDataToGrid();

            buttonLoadXML.Click += ButtonLoadXML_Click;
            buttonLoadJSON.Click += ButtonLoadJSON_Click;
            buttonShowDetails.Click += ButtonShowDetails_Click;
            buttonResetData.Click += ButtonResetData_Click;
            treeViewEntities.AfterSelect += TreeViewEntities_AfterSelect;
        }

        /// <summary>
        /// Очищает все данные контейнера и сбрасывает тип текущей сущности на "Врачи"
        /// </summary>
        private void ClearAllData()
        {
            data = new MedicalDataContainer();
            currentEntityType = "Doctors";
        }

        /// <summary>
        /// Инициализирует дерево сущностей с тремя корневыми узлами: Врачи, Пациенты, Болезни
        /// </summary>
        private void InitializeTreeView()
        {
            treeViewEntities.Nodes.Clear();
            treeViewEntities.Nodes.Add(new TreeNode("Врачи") { Tag = "Doctors" });
            treeViewEntities.Nodes.Add(new TreeNode("Пациенты") { Tag = "Patients" });
            treeViewEntities.Nodes.Add(new TreeNode("Болезни") { Tag = "Diseases" });
            treeViewEntities.ExpandAll();
            treeViewEntities.SelectedNode = treeViewEntities.Nodes[0];
        }

        /// <summary>
        /// Загружает данные в таблицу в зависимости от выбранного типа сущности
        /// </summary>
        private void LoadDataToGrid()
        {
            if (currentEntityType == "Doctors")
            {
                dataGridViewEntities.DataSource = data.Doctors.Select(d => new
                {
                    d.Id,
                    ФИО = d.FullName,
                    Специализация = d.Specialization,
                    Телефон = d.Phone,
                    Адрес = d.WorkAddressString,
                    График = d.WorkingDaysString
                }).ToList();
                labelTitle.Text = "Информация о сущностях: ВРАЧИ";
            }
            else if (currentEntityType == "Patients")
            {
                dataGridViewEntities.DataSource = data.Patients.Select(p => new
                {
                    p.Id,
                    ФИО = p.FullName,
                    ДатаРождения = p.BirthDateString,
                    Возраст = p.Age,
                    Телефон = p.Phone,
                    Адрес = p.HomeAddressString,
                    Кровь = p.BloodType
                }).ToList();
                labelTitle.Text = "Информация о сущностях: ПАЦИЕНТЫ";
            }
            else if (currentEntityType == "Diseases")
            {
                dataGridViewEntities.DataSource = data.Diseases.Select(d => new
                {
                    d.Id,
                    Название = d.Name,
                    Тяжесть = d.Severity,
                    Длительность = d.DurationDays > 0 ? $"{d.DurationDays} дней" : "Хроническое",
                    Симптомы = d.SymptomsString,
                    Лечение = d.Treatment.Length > 50 ? d.Treatment.Substring(0, 50) + "..." : d.Treatment
                }).ToList();
                labelTitle.Text = "Информация о сущностях: БОЛЕЗНИ";
            }
        }

        /// <summary>
        /// Обрабатывает выбор узла в дереве сущностей и переключает отображаемый тип данных
        /// </summary>
        private void TreeViewEntities_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag != null)
            {
                currentEntityType = e.Node.Tag.ToString();
                LoadDataToGrid();
            }
        }

        /// <summary>
        /// Открывает диалог выбора XML-файла и загружает данные из него
        /// </summary>
        private void ButtonLoadXML_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Title = "Выберите XML файл";
                dialog.Filter = "XML файлы (*.xml)|*.xml";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    data = DataManager.LoadFromXml(dialog.FileName);
                    LoadDataToGrid();
                    MessageBox.Show($"Загружено из {dialog.FileName}", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        /// <summary>
        /// Открывает диалог выбора JSON-файла и загружает данные из него
        /// </summary>
        private void ButtonLoadJSON_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Title = "Выберите JSON файл";
                dialog.Filter = "JSON файлы (*.json)|*.json";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    data = DataManager.LoadFromJson(dialog.FileName);
                    LoadDataToGrid();
                    MessageBox.Show($"Загружено из {dialog.FileName}", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        /// <summary>
        /// Отображает детальную информацию о выбранной в таблице сущности в новом окне
        /// </summary>
        private void ButtonShowDetails_Click(object sender, EventArgs e)
        {
            if (dataGridViewEntities.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridViewEntities.SelectedRows[0].Cells[0].Value);
                object entity = null;

                if (currentEntityType == "Doctors") entity = data.Doctors.FirstOrDefault(d => d.Id == id);
                else if (currentEntityType == "Patients") entity = data.Patients.FirstOrDefault(p => p.Id == id);
                else if (currentEntityType == "Diseases") entity = data.Diseases.FirstOrDefault(d => d.Id == id);

                if (entity != null)
                {
                    EntityDetailsForm details = new EntityDetailsForm(entity, currentEntityType);
                    details.ShowDialog();
                }
            }
            else MessageBox.Show("Выберите запись", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /// <summary>
        /// Сбрасывает все данные после подтверждения от пользователя
        /// </summary>
        private void ButtonResetData_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Очистить все данные?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ClearAllData();
                LoadDataToGrid();
                MessageBox.Show("Данные очищены", "Сброс", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}