namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee(tbUsername.Text,tbPassword.Text);
            if (employee.Login(employee.LoginName, employee.Password))
            {
                MessageBox.Show("Login Berhasil, ID anda adalah " + employee.EmployeeID.ToString());
            }
            else
            {
                MessageBox.Show("Login gagal");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}