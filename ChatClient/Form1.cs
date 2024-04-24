using ChatClient.View.Interfaces;
using DataTransferObjects.DTO;
using System;
using System.Windows.Forms;

namespace ChatClient
{
    public partial class Form1 : Form, IForm1
    {
        public Form1()
        {
            InitializeComponent();
        }

        public event Action<string, string> OnAutorization;
        public event Action<UserDTO> OnRegistration;

        public void ShowNotification(string message)
        {

        }

        public void Enter()
        {
            groupBox1.Hide();
            groupBox3.Show();   
        }

        private void registration_Click(object sender, EventArgs e)
        {

            UserDTO user = new UserDTO
            {
                Login = textBox1.Text,
                Email = textBox2.Text,

            };


            OnRegistration?.Invoke(user);

        }

        private void auhtorisation_Click(object sender, EventArgs e)
        {

            OnAutorization?.Invoke(textBox1.Text, textBox2.Text);

        }
    }
}