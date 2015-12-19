using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBook
{
    public partial class AddBookForm : Form
    {
        private ContactList _ContactList;

        public AddBookForm(ContactList contactList)
        {
            InitializeComponent();
            _ContactList = contactList;
        }

        private void AddPersonForm_Load(object sender, EventArgs e)
        {

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            TitleTextBox.Clear();
            AuthorTextBox.Clear();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if((!TitleTextBox.Text.Equals(""))
                && (!AuthorTextBox.Equals(""))
                && (!SubjectTextBox.Text.Equals(""))
                && (!PublisherTextBox.Text.Equals("")
                && (!YearTextBox.Text.Equals("")
                && (!CirculationTextBox.Text.Equals("")))))
            {
                Book b = new Book(TitleTextBox.Text, AuthorTextBox.Text, SubjectTextBox.Text,
                    PublisherTextBox.Text, YearTextBox.Text, CirculationTextBox.Text);
                _ContactList.AddBook(b);
                TitleTextBox.Clear();
                AuthorTextBox.Clear();
                SubjectTextBox.Clear();
                PublisherTextBox.Clear();
                YearTextBox.Clear();
                CirculationTextBox.Clear();
                CirculationFalseButton.Checked = false;
                CirculationTrueButton.Checked = false;
            }
            else
            {
                MessageBox.Show("Missing Some Requirements");
            }
        }

        private void Done_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CirculationFalseButton_CheckedChanged(object sender, EventArgs e)
        {
            if(CirculationFalseButton.Checked)
            {
                CirculationTextBox.Text = "False";
            }
        }

        private void CirculationTrueButton_CheckedChanged(object sender, EventArgs e)
        {
            if (CirculationTrueButton.Checked)
            {
                CirculationTextBox.Text = "True";
            }
        }
    }
}
