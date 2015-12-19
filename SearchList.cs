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
    public partial class SearchList : Form
    {
        private ArrayList _ResultList;
        private int _CurrentIndex;

        public SearchList(ArrayList resultList)
        {
            InitializeComponent();
            _ResultList = resultList;
            _CurrentIndex = 0;
            ShowPerson(_CurrentIndex);
        }

        private void ShowPerson(int index)
        {
            if(index < 0)
            {
                MessageBox.Show("No More Books");
            }

            if(index > (_ResultList.Count - 1))
            {
                MessageBox.Show("No More Books");
            }

            if((index >= 0) && (index < _ResultList.Count))
            {
                Book b = (Book)_ResultList[index];
                Title.Text = b.Title;
                Author.Text = b.Author;
                LCCN.Text = "" + b.LCCN;
                Subject.Text = b.Subject;
                Publisher.Text = b.Publisher;
                Year.Text = b.Year;
                Circulation.Text = b.Circulation;
                _CurrentIndex = index;
            }
        }

        private void Prev_Click(object sender, EventArgs e)
        {
            ShowPerson(_CurrentIndex - 1);
        }

        private void Next_Click(object sender, EventArgs e)
        {
            ShowPerson(_CurrentIndex + 1);
        }

        private void Done_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SearchList_Load(object sender, EventArgs e)
        {

        }
    }
}
