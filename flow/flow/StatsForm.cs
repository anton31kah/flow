using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace flow
{
    public partial class StatsForm : Form
    {
        private int sortColumn = -1;

        public StatsForm(Dictionary<string, int> stats)
        {
            InitializeComponent();
            foreach (var entry in stats)
                statsListView.Items.Add(new ListViewItem(new[] { entry.Key, entry.Value.ToString() }));
        }

        private void statsListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column != sortColumn)
            {
                sortColumn = e.Column;
                statsListView.Sorting = SortOrder.Ascending;
            }
            else
                statsListView.Sorting = statsListView.Sorting == SortOrder.Ascending ? SortOrder.Descending : SortOrder.Ascending;
            statsListView.Sort();
            statsListView.ListViewItemSorter = new ListViewItemComparer(e.Column, statsListView.Sorting);
        }
    }

    class ListViewItemComparer : IComparer
    {
        private int col;
        private SortOrder order;
        public ListViewItemComparer()
        {
            col = 0;
            order = SortOrder.Ascending;
        }
        public ListViewItemComparer(int column, SortOrder order)
        {
            col = column;
            this.order = order;
        }
        public int Compare(object x, object y)
        {
            int returnVal = -1;
            bool tryParse = int.TryParse(((ListViewItem)x).SubItems[col].Text, out int number);
            if (tryParse)
            {
                returnVal = Int32.Parse(((ListViewItem)x).SubItems[col].Text).CompareTo(Int32.Parse(((ListViewItem)y).SubItems[col].Text));
            }
            else
            {
                returnVal = String.Compare(((ListViewItem)x).SubItems[col].Text, ((ListViewItem)y).SubItems[col].Text);
            }

            // Determine whether the sort order is descending.
            if (order == SortOrder.Descending)
                // Invert the value returned by String.Compare.
                returnVal *= -1;

            return returnVal;
        }
    }
}
