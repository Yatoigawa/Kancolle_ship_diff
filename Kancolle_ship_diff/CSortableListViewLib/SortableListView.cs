using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace CSortableListViewLib
{
    [ToolboxBitmap(typeof(SortableListView), "tbxSortableListView")]
    public class SortableListView : ListView
    {
        public enum SortStyles
        {
            SortDefault,
            SortAllColumns,
            SortSelectedColumn
        }

        // The current sort column for selected column sorting.
        private int m_SelectedColumn = -1;

        // m_SortSubitems(i) is the i-th sub-item
        // in the sort order for all column sorting.
        private int[] m_SortSubitems = null;

        // Initialize the sort item order to the order given by the column headers.
        private void SetSortSubitems()
        {
            m_SortSubitems = new int[this.Columns.Count];
            for (int i=0; i<=this.Columns.Count - 1; i++)
            {
                m_SortSubitems[this.Columns[i].DisplayIndex] = i;
            }
        }

        // Whether we sort by all columns, one column, or not at all.
        private SortStyles m_SortStyle = SortStyles.SortDefault;
        public SortStyles SortStyle
        {
            get
            {
                return m_SortStyle;
            }
            set
            {
                m_SortStyle = value;
                // If the current style is SortSelectedColumn,
                // remove the column sort indicator.
                if (m_SortStyle == SortStyles.SortSelectedColumn)
                {
                    if (m_SelectedColumn >= 0)
                    {
                        this.Columns[m_SelectedColumn].ImageKey = null;
                        m_SelectedColumn = -1;
                    }
                }

                // Save the new value.
                m_SortStyle = value;

                switch (m_SortStyle)
                {
                    case SortStyles.SortDefault:
                        this.ListViewItemSorter = null;
                        break;
                    case SortStyles.SortAllColumns:
                        this.ListViewItemSorter = new SortableListView.AllColumnSorter();
                        break;
                    case SortStyles.SortSelectedColumn:
                        this.ListViewItemSorter = new SelectedColumnSorter();
                        break;
                }
            }
        }

        // The user reordered the columns. Resort.
        protected override void OnColumnReordered(System.Windows.Forms.ColumnReorderedEventArgs e)
        {
            // This raises the ColumnReordered event.
            base.OnColumnReordered(e);

            // If the main program canceled, do nothing.
            if (e.Cancel) return;

            // Rebuild the list of sort sub-items.
            SetSortSubitems();

            // Fix the list up to account for the moved column.
            MoveArrayItem(m_SortSubitems, e.OldDisplayIndex, e.NewDisplayIndex);

            // Resort.
            this.Sort();
        }

        // Move an item from position idx_fr to idx_to.
        private void MoveArrayItem(int[] values, int idx_fr, int idx_to)
        {
            int moved_value = values[idx_fr];
            int num_moved = Math.Abs(idx_fr - idx_to);

            if (idx_to < idx_fr)
            {
                Array.Copy(values, idx_to, values, idx_to + 1, num_moved);
            } else {
                Array.Copy(values, idx_fr + 1, values, idx_fr, num_moved);
            }

            values[idx_to] = moved_value;
        }

        // Change the selected sort column.
        protected override void OnColumnClick(ColumnClickEventArgs e)
        {
            base.OnColumnClick(e);

            if (this.SortStyle == SortStyles.SortSelectedColumn)
            {
                // If this is the same sort column, switch the sort order.
                if (e.Column == m_SelectedColumn)
                {
                    if (this.Sorting == SortOrder.Ascending)
                    {
                        this.Sorting = SortOrder.Descending;
                    }
                    else
                    {
                        this.Sorting = SortOrder.Ascending;
                    }
                }

                // Remove the image from the previous sort column.
                if (m_SelectedColumn >= 0)
                {
                    this.Columns[m_SelectedColumn].ImageKey = null;
                }

                // If we're not currently sorting, sort ascending.
                if (this.Sorting == SortOrder.None)
                {
                    this.Sorting = SortOrder.Ascending;
                }

                // Save the new sort column and give it an image.
                m_SelectedColumn = e.Column;
                if (this.Sorting == SortOrder.Descending)
                {
                    this.Columns[m_SelectedColumn].ImageKey = "sortDescending.bmp";
                }
                else
                {
                    this.Columns[m_SelectedColumn].ImageKey = "sortAscending.bmp";
                }

                // Resort.
                this.Sort();
            }
        }
        
        // ---------------------------------------
        // Sort the ListView items by all columns.
        private class AllColumnSorter : System.Collections.IComparer
        {
            #region IComparer Members

            // Compare two ListViewItems.
            public int Compare(object x, object y)
            {
                ListViewItem itemx = (ListViewItem)(x);
                ListViewItem itemy = (ListViewItem)(y);

                // Compare the items' strings.
                if (itemx.ListView.Sorting == SortOrder.Ascending)
                {
                    return String.Compare(ItemString(itemx), ItemString(itemy));
                } else {
                    return -String.Compare(ItemString(itemx), ItemString(itemy));
                }
            }

            #endregion


            // Return a string representing this item as a
            // null-separated list of the item sub-item values.
            private string ItemString(ListViewItem listview_item)
            {
                SortableListView slvw = (SortableListView)listview_item.ListView;

                // Make sure we have the sort sub-items' order.
                if (slvw.m_SortSubitems == null) slvw.SetSortSubitems();

                // Make an array to hold the sort sub-items' values.
                int num_cols = slvw.Columns.Count;
                string[] values = new string[num_cols];

                // Build the list of fields in display order.
                for (int i=0; i<=slvw.m_SortSubitems.Length - 1; i++)
                {
                    int idx = slvw.m_SortSubitems[i];

                    // Get this sub-item's value.
                    string item_value = "";
                    if (idx < listview_item.SubItems.Count)
                    {
                        item_value = listview_item.SubItems[idx].Text;
                    }

                    // Align appropriately.
                    if (slvw.Columns[idx].TextAlign == HorizontalAlignment.Right)
                    {
                        // Pad so numeric values sort properly.
                        values[i] = item_value.PadLeft(20);
                    } else {
                        values[i] = item_value;
                    }
                }

                // Save the sub-item values in display order.
                for (int i=0; i<=slvw.m_SortSubitems.Length - 1; i++)
                {
                    int idx = slvw.m_SortSubitems[i];
                    // Make sure this item has this sub-item.
                    if (idx < listview_item.SubItems.Count)
                    {
                        // Add the sub-item's value.
                        if (slvw.Columns[idx].TextAlign == HorizontalAlignment.Right)
                        {
                            // Pad so numeric values sort properly.
                            values[i] = listview_item.SubItems[idx].Text.PadLeft(20);
                        } else {
                            values[i] = listview_item.SubItems[idx].Text;
                        }
                    }
                }

                // Console.WriteLine(String.Join("|", values));

                // Concatenate the values to build the result.
                return String.Join("\0", values);
            }
        }

        // ---------------------------------------
        // Sort the ListView items by the selected column.
        private class SelectedColumnSorter : System.Collections.IComparer
        {
            #region IComparer Members

            // Compare two ListViewItems.
            public int Compare(object x, object y)
            {
                ListViewItem itemx = (ListViewItem)(x);
                ListViewItem itemy = (ListViewItem)(y);

                // Get the selected column index.
                SortableListView slvw = (SortableListView)itemx.ListView;
                int idx = slvw.m_SelectedColumn;
                if (idx < 0) return 0;

                // Compare the items' strings.
                if (itemx.ListView.Sorting == SortOrder.Ascending)
                {
                    return String.Compare(ItemString(itemx, idx), ItemString(itemy, idx));
                }
                else
                {
                    return -String.Compare(ItemString(itemx, idx), ItemString(itemy, idx));
                }
            }

            #endregion

            // Return a string representing this item's sub-item.
            private string ItemString(ListViewItem listview_item, int idx) 
            {
                SortableListView slvw = (SortableListView)listview_item.ListView;

                // Make sure the item has the needed sub-item.
                string value = "";
                if (idx <= listview_item.SubItems.Count - 1)
                {
                    value = listview_item.SubItems[idx].Text;
                }

                // Return the sub-item's value.
                if (slvw.Columns[idx].TextAlign == HorizontalAlignment.Right)
                {
                    // Pad so numeric values sort properly.
                    return value.PadLeft(20);
                } else {
                    return value;
                }
            }
        }
    }
}
