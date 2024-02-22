using AgeCounter.Models;
using System.Text;

namespace AgeCounter
{
    public partial class MainForm : Form
    {
        static string path = Application.StartupPath + "BirthDate.txt";

        public static Form Form { get; set; }

        public MainForm()
        {
            InitializeComponent();
            Form = this;
            if (File.Exists(path))
            {
                string[] text = File.ReadAllText(path).Split(':');
                int year = int.Parse(text[0]);
                int month = int.Parse(text[1]);
                int day = int.Parse(text[2]);
                int hour = int.Parse(text[3]);
                int minute = int.Parse(text[4]);
                DateTime birthDate = new DateTime(year, month, day, hour, minute, 0);
                ShowCounter(birthDate);
            }
        }

        private async void StartButton_Click(object sender, EventArgs e)
        {
            int hour = int.Parse(TimeMaskedTextBox.Text.Split(':')[0]);
            int minute = int.Parse(TimeMaskedTextBox.Text.Split(':')[1]);
            DateTime dateTime = BirthDateTimePicker.Value;
            DateTime birthDate = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, hour, minute, 0);

            if (SaveCheckBox.Checked)
            {
                var file = File.Open(path, FileMode.OpenOrCreate, FileAccess.Write);
                await file.WriteAsync(UTF8Encoding.UTF8.GetBytes($"{birthDate.Year}:{birthDate.Month}:{birthDate.Day}:{birthDate.Hour}:{birthDate.Minute}"));
                file.Close();
            }

            ShowCounter(birthDate);
        }

        private void ShowCounter(DateTime birthDate)
        {
            TimeSpan differenceDateTime;
            if (birthDate.CompareTo(DateTime.Now) < 0)
                differenceDateTime = DateTime.Now.Subtract(birthDate);
            else
                differenceDateTime = birthDate.Subtract(DateTime.Now);

            int year = differenceDateTime.Days / 365;

            CounterModel counterModel = new CounterModel
            {
                Year = year,
                Day = differenceDateTime.Days - (year * 365),
                Hour = differenceDateTime.Hours,
                Minute = differenceDateTime.Minutes,
                Second = differenceDateTime.Seconds
            };
            Visible = false;
            AgeCounterForm ageCounterForm = new AgeCounterForm(counterModel);
            ageCounterForm.ShowDialog();
        }

        private void ResetButton_Click(object sender, EventArgs e) => File.Delete(path);
    }
}