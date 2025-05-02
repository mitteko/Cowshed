using DataPresentation.Entities;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace DataPresentation
{
    public partial class Сowshed : Form
    {
        private Barn barnData;

        public Сowshed()
        {
            InitializeComponent();
        }

        private void loadDataButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XML files (*.xml)|*.xml|JSON files (*.json)|*.json|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                LoadDataFromFile(filePath);
                PopulateTreeView();
            }
        }

        private void LoadDataFromFile(string filePath)
        {
            try
            {
                string fileExtension = Path.GetExtension(filePath).ToLower();
                string fileContent;

                if (fileExtension == ".xml")
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Barn));
                    using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
                    {
                        barnData = (Barn)serializer.Deserialize(fileStream);
                    }
                }
                else if (fileExtension == ".json")
                {
                    fileContent = File.ReadAllText(filePath);
                    barnData = JsonConvert.DeserializeObject<Barn>(fileContent);
                }
                else
                {
                    MessageBox.Show("Неподдерживаемый формат файла.");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки данных: " + ex.Message);
                barnData = null;
            }
        }

        private void PopulateTreeView()
        {
            treeView.Nodes.Clear();
            if (barnData == null) return;

            TreeNode cowsNode = new TreeNode("Коровы");
            foreach (Cow cow in barnData.Cows.Items)
            {
                TreeNode cowNode = new TreeNode(cow.Name);
                cowNode.Tag = cow;
                cowsNode.Nodes.Add(cowNode);
                TreeNode feedingScheduleNode = new TreeNode("Расписание кормления");
                feedingScheduleNode.Tag = cow.FeedingSchedules;
                cowNode.Nodes.Add(feedingScheduleNode);
            }
            treeView.Nodes.Add(cowsNode);

            TreeNode employeesNode = new TreeNode("Работники");
            foreach (Employee employee in barnData.Employees.Items)
            {
                TreeNode employeeNode = new TreeNode(employee.Name);
                employeeNode.Tag = employee;
                employeesNode.Nodes.Add(employeeNode);
            }
            treeView.Nodes.Add(employeesNode);

            TreeNode stallsNode = new TreeNode("Стойла");
            foreach (Stall stall in barnData.Stalls.Items)
            {
                TreeNode stallNode = new TreeNode(stall.Location);
                stallNode.Tag = stall;
                stallsNode.Nodes.Add(stallNode);
            }
            treeView.Nodes.Add(stallsNode);

            treeView.ExpandAll();
        }

        // не смогла разобраться почему не высвечивается в dataGridView 
        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            dataGridViewAll.Columns.Clear();
            dataGridViewAll.Rows.Clear();

            if (e.Node.Tag is Cow cow)
            {
                DisplayCowInGrid(cow);
            }
            else if (e.Node.Tag is Employee employee)
            {
                DisplayEmployeeInGrid(employee);
            }
            else if (e.Node.Tag is Stall stall)
            {
                DisplayStallInGrid(stall);
            }
            else if (e.Node.Tag is List<FeedingSchedule> feedingSchedules)
            {
                DisplayFeedingSchedulesInGrid(feedingSchedules);
            }
        }

        private void DisplayCowInGrid(Cow cow)
        {
            dataGridViewAll.ColumnCount = 2;
            dataGridViewAll.Columns[0].Name = "Свойство";
            dataGridViewAll.Columns[1].Name = "Значение";

            dataGridViewAll.Rows.Add("ID", cow.Id);
            dataGridViewAll.Rows.Add("Имя", cow.Name);
            dataGridViewAll.Rows.Add("Порода", cow.Breed);
            dataGridViewAll.Rows.Add("Возраст", cow.Age);
            dataGridViewAll.Rows.Add("Температура", cow.Health.Temperature);
            dataGridViewAll.Rows.Add("Состояние", cow.Health.Condition);
        }

        private void DisplayEmployeeInGrid(Employee employee)
        {
            dataGridViewAll.ColumnCount = 2;
            dataGridViewAll.Columns[0].Name = "Свойство";
            dataGridViewAll.Columns[1].Name = "Значение";

            dataGridViewAll.Rows.Add("ID", employee.Id);
            dataGridViewAll.Rows.Add("Имя", employee.Name);
            dataGridViewAll.Rows.Add("Должность", employee.Role);
            dataGridViewAll.Rows.Add("Телефон", employee.Contact.Phone);
            dataGridViewAll.Rows.Add("Email", employee.Contact.Email);
            dataGridViewAll.Rows.Add("Город", employee.City);
        }

        private void DisplayStallInGrid(Stall stall)
        {
            dataGridViewAll.ColumnCount = 2;
            dataGridViewAll.Columns[0].Name = "Свойство";
            dataGridViewAll.Columns[1].Name = "Значение";

            dataGridViewAll.Rows.Add("ID", stall.Id);
            dataGridViewAll.Rows.Add("Местоположение", stall.Location);
            dataGridViewAll.Rows.Add("Вместимость", stall.Capacity);
            dataGridViewAll.Rows.Add("Ширина", stall.Size.Width);
            dataGridViewAll.Rows.Add("Длина", stall.Size.Length);
        }

        private void DisplayFeedingSchedulesInGrid(List<FeedingSchedule> feedingSchedules)
        {
            dataGridViewAll.ColumnCount = 6;
            dataGridViewAll.Columns[0].Name = "ID";
            dataGridViewAll.Columns[1].Name = "Cow ID";
            dataGridViewAll.Columns[2].Name = "Тип корма";
            dataGridViewAll.Columns[3].Name = "Время";
            dataGridViewAll.Columns[4].Name = "Количество";
            dataGridViewAll.Columns[5].Name = "Ед. изм.";

            foreach (FeedingSchedule schedule in feedingSchedules)
            {
                dataGridViewAll.Rows.Add(schedule.id, schedule.CowId, schedule.FeedType, schedule.Time, schedule.Amount, schedule.Unit);
            }
        }

        private void detailsButton_Click(object sender, EventArgs e)
        {
            if (treeView.SelectedNode != null && treeView.SelectedNode.Tag != null)
            {
                object selectedObject = treeView.SelectedNode.Tag;

                if (selectedObject is Cow cow)
                {
                    DetailsForm detailsForm = new DetailsForm(cow);
                    detailsForm.ShowDialog();
                }
                else if (selectedObject is Employee employee)
                {
                    DetailsForm detailsForm = new DetailsForm(employee);
                    detailsForm.ShowDialog();
                }
                else if (selectedObject is Stall stall)
                {
                    DetailsForm detailsForm = new DetailsForm(stall);
                    detailsForm.ShowDialog();
                }
            }
        }
    }
}
