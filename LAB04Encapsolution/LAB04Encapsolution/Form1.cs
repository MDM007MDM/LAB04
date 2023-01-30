using LAB4Encapsulation;

namespace LAB04Encapsolution
{
    public partial class Form1 : Form
    {
        Classroom classroom;
        public Form1()
        {
            InitializeComponent();
            classroom = new Classroom("OOP");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputBY = T2.Text;
            string inputName = T1.Text;
            string inputGPA = T3.Text;
            int Year = Int32.Parse(inputBY);
            double iGPA = double.Parse(inputGPA);


            Person person = new Person(inputName, Year, iGPA);


            this.classroom.addPerson2Class(person);
            T8.Text = classroom.showAllPersoninClass();
            T7.Text = classroom.SumAllYearClass();
            T6.Text = classroom.avgMaxGPA();
            T4.Text = classroom.MaxGPA();
            T5.Text = classroom.MinGPA();
            T9.Text = classroom.maxGPAName1();
            T10.Text = classroom.minGPAName1();
        }
    }
}