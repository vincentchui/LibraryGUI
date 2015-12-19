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
    public partial class MainForm : Form
    {
        private ContactList contactList;

        public MainForm()
        {
            InitializeComponent();
            contactList = new ContactList();
        }

        private void newToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Serializer serializer = new Serializer();

            SaveFileDialog createFileDialog = new SaveFileDialog();

            createFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"; 

            if(createFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    serializer.CreateNewFile(createFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Serializer serializer = new Serializer();

            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    contactList = serializer.DeSerializeObject(openFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Serializer serializer = new Serializer();

            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    serializer.SerializeObject(saveFileDialog.FileName, contactList);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBookForm addForm = new AddBookForm(contactList);
            addForm.ShowDialog();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm(contactList);
            searchForm.ShowDialog();
        }
    }
}