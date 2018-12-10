using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RandoFormat;

namespace RandoChoose
{
    public partial class Main : Form
    {
        private RandoFile file = new RandoFile(new List<Group>());
        private string path = null;

        public Main()
        {
            InitializeComponent();
            selectDropdown.SelectedIndex = 0;
            addDropdown.SelectedIndex = 0;
            entryDropdown.SelectedIndex = 0;
            Console.WriteLine(groupDropdown.SelectedIndex);
        }

        private void open(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog
            {
                Filter = "RandoChoose File | *.rdc",
                Title = "Select RandoChoose File"
            };
            if (open.ShowDialog() != DialogResult.OK) return;
            selectionTree.Nodes.Clear();
            selectDropdown.Items.Clear();
            addDropdown.Items.Clear();
            entryDropdown.Items.Clear();
            path = open.FileName;
            file = new RandoFile(path);
            foreach (Group g in file.groups)
            {
                TreeNode node = selectionTree.Nodes.Add(g.name);
                selectDropdown.Items.Add(g.name);
                addDropdown.Items.Add(g.name);
                groupDropdown.Items.Add(g.name);
                foreach (string s in g.entries)
                {
                    node.Nodes.Add(s);
                }
            }
            selectDropdown.Items.Add("All");
            selectDropdown.SelectedIndex = 0;
            addDropdown.Items.Add("Tree");
            addDropdown.SelectedIndex = 0;
            entryDropdown.Items.Add("None");
            entryDropdown.SelectedIndex = 0;
            groupDropdown.SelectedIndex = 0;
        }

        private void save(object sender, EventArgs e)
        {
            if (path == null)
            {
                saveAs(sender, e);
                return;
            }
            file.write(path);
        }

        private void saveAs(object sender, EventArgs e)
        {
            SaveFileDialog open = new SaveFileDialog
            {
                Filter = "RandoChoose File | *.rdc"
            };
            if (open.ShowDialog() != DialogResult.OK) return;
            file.write(open.FileName);
        }

        private void roll(object sender, EventArgs e)
        {
            List<string> t = new List<string>();

            if ((string)selectDropdown.SelectedItem == "All")
            {
                foreach (TreeNode a in selectionTree.Nodes)
                {
                    foreach (TreeNode b in a.Nodes)
                    {
                        t.Add(b.Text);
                    }
                }
            }
            else
            {
                TreeNode node = selectionTree.Nodes[selectDropdown.SelectedIndex];
                foreach (TreeNode a in node.Nodes)
                {
                    t.Add(a.Text);
                }
                if (t.Count == 0) return;
            }
            chooseDisplay.Text = t[new Random().Next(t.Count)];
        }

        private void add(object sender, EventArgs e)
        {
            if (addText.Text == "") return;
            if ((string)addDropdown.SelectedItem == "Tree")
            {
                selectionTree.Nodes.Add(addText.Text);
                selectDropdown.Items.Insert(selectDropdown.Items.Count - 1, addText.Text);
                addDropdown.Items.Insert(addDropdown.Items.Count - 1, addText.Text);
                groupDropdown.Items.Insert(groupDropdown.Items.Count, addText.Text);
                file.groups.Add(new Group(addText.Text));
            }
            else
            {
                TreeNode node = selectionTree.Nodes[addDropdown.SelectedIndex];
                Group group = file.groups[addDropdown.SelectedIndex];
                group.entries.Add(addText.Text);
                node.Nodes.Add(addText.Text);
            }
            addText.Text = "";
        }

        private void delete(object sender, EventArgs e)
        {
            if (groupDropdown.SelectedIndex == -1) return;
            if ((string)entryDropdown.SelectedItem == "None")
            {
                TreeNode node = selectionTree.Nodes[groupDropdown.SelectedIndex];
                Group group = file.groups[addDropdown.SelectedIndex];
                selectionTree.Nodes.Remove(node);
                selectDropdown.Items.Remove(group.name);
                addDropdown.Items.Remove(group.name);
                groupDropdown.Items.Remove(group.name);
                file.groups.Remove(group);
            }
            else
            {
                TreeNode node = selectionTree.Nodes[groupDropdown.SelectedIndex].Nodes[entryDropdown.SelectedIndex];
                Group group = file.groups[addDropdown.SelectedIndex];
                string entry = group.entries[entryDropdown.SelectedIndex];
                group.entries.Remove(entry);
                node.Nodes.Remove(node);
                entryDropdown.Items.Remove(entry);
            }
        }

        private void rename(object sender, EventArgs e)
        {
            if (renText.Text == "" || groupDropdown.SelectedIndex == -1) return;
            if ((string)entryDropdown.SelectedItem == "None")
            {
                TreeNode node = selectionTree.Nodes[groupDropdown.SelectedIndex];
                Group group = file.groups[groupDropdown.SelectedIndex];
                int i = groupDropdown.SelectedIndex;
                groupDropdown.Items.Remove(group.name);
                groupDropdown.Items.Insert(i, renText.Text);
                groupDropdown.SelectedIndex = i;
                node.Text = renText.Text;
                group.name = renText.Text;
            }
            else
            {
                TreeNode node = selectionTree.Nodes[groupDropdown.SelectedIndex];
                TreeNode enode = selectionTree.Nodes[groupDropdown.SelectedIndex].Nodes[entryDropdown.SelectedIndex];
                enode.Text = renText.Text;
                Group group = file.groups[groupDropdown.SelectedIndex];
                string entry = group.entries[entryDropdown.SelectedIndex];
                int i = entryDropdown.SelectedIndex;
                group.entries.Remove(entry);
                group.entries.Insert(i, renText.Text);
                entryDropdown.Items.Remove(entry);
                entryDropdown.Items.Insert(i, renText.Text);
                entryDropdown.SelectedIndex = i;
            }
            renText.Text = "";
        }

        private void groupSelected(object sender, EventArgs e)
        {
            entryDropdown.Items.Clear();
            foreach (string i in file.groups[groupDropdown.SelectedIndex].entries)
            {
                entryDropdown.Items.Add(i);
            }
            entryDropdown.Items.Add("None");
            entryDropdown.SelectedIndex = 0;
        }

        private void about(object sender, EventArgs e)
        {
            new About().ShowDialog();
        }
    }
}