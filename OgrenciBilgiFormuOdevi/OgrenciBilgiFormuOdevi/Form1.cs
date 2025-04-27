namespace OgrenciBilgiFormuOdevi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnKaydet_Click(object sender, EventArgs e)
        {
            var student = new Student
            {
                FirstName = txtName.Text,
                LastName = txtSurname.Text,
                Department = txtDepartment.Text,
                StudentNumber = maskedtxtNumara.Text
            };

            if (checkBoxErkek.Checked)
            {
                student.Gender = "Erkek";
            }
            else if (checkBoxKadýn.Checked)
            {
                student.Gender = "Kadýn";
            }
            else
            {
                MessageBox.Show("Lütfen cinsiyet seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string errorMessage = ValidateStudent(student);

            if (!string.IsNullOrEmpty(errorMessage))
            {
                MessageBox.Show(errorMessage, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
            var item = new ListViewItem(student.FirstName);
            item.SubItems.Add(student.LastName);
            item.SubItems.Add(student.Department);
            item.SubItems.Add(student.Gender);
            item.SubItems.Add(student.StudentNumber);

            listView1.Items.Add(item);

            txtName.Text = "";
            txtSurname.Text = "";
            txtDepartment.Text = "";

        }

        
        private string ValidateStudent(Student student)
        {
            foreach (var property in student.GetType().GetProperties())
            {
                var attribute = (NotEmptyAttribute)Attribute.GetCustomAttribute(property, typeof(NotEmptyAttribute));

                if (attribute != null)
                {
                    var value = property.GetValue(student)?.ToString();
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        return attribute.ErrorMessage; 
                    }
                }
            }
            return null; 
        }
    }
}

