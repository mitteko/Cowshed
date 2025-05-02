using DataPresentation.Entities;

namespace DataPresentation
{
    public partial class DetailsForm : Form
    {
        public DetailsForm(object obj)
        {
            InitializeComponent();
            if (obj is Cow cow)
            {
                DisplayCowDetails(cow);
            }
            else if (obj is Employee employee)
            {
                DisplayEmployeeDetails(employee);
            }
            else if (obj is Stall stall)
            {
                DisplayStallDetails(stall);
            }
        }

        private void DisplayCowDetails(Cow cow)
        {
            nameLabel.Visible = true;
            breedLabel.Visible = true;
            ageLabel.Visible = true;
            temperatureLabel.Visible = true;
            conditionLabel.Visible = true;

            nameLabel.Text = $"Имя: {cow.Name}";
            breedLabel.Text = $"Порода: {cow.Breed}";
            ageLabel.Text = $"Возраст: {cow.Age}";
            temperatureLabel.Text = $"Температура: {cow.Health.Temperature}";
            conditionLabel.Text = $"Состояние: {cow.Health.Condition}";

            // лишнее
            roleLabel.Visible = false;
            phoneLabel.Visible = false;
            emailLabel.Visible = false;
            cityLabel.Visible = false;
            locationLabel.Visible = false;
            capacityLabel.Visible = false;
            widthLabel.Visible = false;
            lengthLabel.Visible = false;
            empNameLabel.Visible = false;

        }
        private void DisplayEmployeeDetails(Employee employee)
        {
            nameLabel.Visible = true;
            roleLabel.Visible = true;
            phoneLabel.Visible = true;
            emailLabel.Visible = true;
            cityLabel.Visible = true;

            empNameLabel.Text = $"Имя: {employee.Name}";
            roleLabel.Text = $"Должность: {employee.Role}";
            phoneLabel.Text = $"Телефон: {employee.Contact.Phone}";
            emailLabel.Text = $"Email: {employee.Contact.Email}";
            cityLabel.Text = $"Город: {employee.City}";

            // лишнее
            nameLabel.Visible = false;
            breedLabel.Visible = false;
            ageLabel.Visible = false;
            temperatureLabel.Visible = false;
            conditionLabel.Visible = false;
            locationLabel.Visible = false;
            capacityLabel.Visible = false;
            widthLabel.Visible = false;
            lengthLabel.Visible = false;
        }

        private void DisplayStallDetails(Stall stall)
        {
            locationLabel.Visible = true;
            capacityLabel.Visible = true;
            widthLabel.Visible = true;
            lengthLabel.Visible = true;

            locationLabel.Text = $"Местоположение: {stall.Location}";
            capacityLabel.Text = $"Вместимость: {stall.Capacity}";
            widthLabel.Text = $"Ширина: {stall.Size.Width}";
            lengthLabel.Text = $"Длина: {stall.Size.Length}";

            // лишнее
            nameLabel.Visible = false;
            breedLabel.Visible = false;
            ageLabel.Visible = false;
            temperatureLabel.Visible = false;
            conditionLabel.Visible = false;
            roleLabel.Visible = false;
            phoneLabel.Visible = false;
            emailLabel.Visible = false;
            cityLabel.Visible = false;
            empNameLabel.Visible = false;
        }
    }
}
