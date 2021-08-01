using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Lab4_Ex2
{
    public partial class EditPerson : Form
    {
        List<Person> pers = new List<Person>();
        public EditPerson()
        {
            InitializeComponent();
        }
        
       
        private void button1_Click(object sender, EventArgs e)
        {
            Person p = new Person();

            EditPersonForm editForm = new EditPersonForm(p);      
            if (editForm.ShowDialog() != DialogResult.OK)
                return;
            p.FirstName = editForm.FirstName;
            p.LastName = editForm.LastName;
            p.Age = editForm.Age;
            pers.Add(p);
            personsListView.VirtualListSize = pers.Count;
            personsListView.Invalidate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (personsListView.SelectedIndices.Count == 0)
                return;
            Person p = pers[personsListView.SelectedIndices[0]];
            EditPersonForm editForm = new EditPersonForm(p);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                personsListView.Invalidate();
            }
        }

        private void personsListView_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        {
            if (e.ItemIndex >= 0 && e.ItemIndex < pers.Count)
            {
                e.Item = new ListViewItem(pers[e.ItemIndex].FirstName);
                e.Item.SubItems.Add(pers[e.ItemIndex].LastName);
                e.Item.SubItems.Add(pers[e.ItemIndex].Age.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                StringBuilder sb = new StringBuilder();
                foreach (Person item in pers)
                {
                    sb.Append("Сотрудник: \n" + item.ToString());
                }
                richTextBox1.Text = sb.ToString();
            }
        }
    }
}
