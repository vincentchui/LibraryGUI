using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBook
{
    public partial class SearchForm : Form
    {
        private ContactList _ContactList;

        public SearchForm(ContactList contactList)
        {
            InitializeComponent();
            _ContactList = contactList;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            SearchTextBox.Clear();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Searching : " + _ContactList.Count());
            MessageBox.Show("Searching For: " + SearchTextBox.Text);
            ArrayList resultList = _ContactList.SearchBySubject(SearchTextBox.Text);

            if(resultList.Count == 0)
            {
                MessageBox.Show("No Books Found");
            }
            else
            {
                SearchList searchList = new SearchList(resultList);
                searchList.Show();
            }
        }

        private void Done_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
