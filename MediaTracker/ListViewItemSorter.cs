using CoreData;
using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaTracker
{
    public class ListViewItemSorter : IComparer
    {
        private int m_nListViewID;
        private int m_nColumn;
        private SortOrder m_pSortOrder;

        public ListViewItemSorter(int nListViewID, int nColumn, SortOrder pSortOrder)
        {
            m_nListViewID = nListViewID;
            m_nColumn = nColumn;
            m_pSortOrder = pSortOrder;
        }

        public int nListViewID { get { return m_nListViewID; } }
        public int nColumn { get { return m_nColumn; } }
        public SortOrder pSortOrder { get { return m_pSortOrder; } }
        public int Compare(object x, object y)
        {
            int nSort = 1;

            if (m_pSortOrder == SortOrder.Ascending) nSort = -1;
            else nSort = 1;

            switch (m_nListViewID)
            {
                case CConstants.LISTVIEW_SERIES_TYPE:
                    CSeriesType xType = (CSeriesType)GetModel(x);
                    CSeriesType yType = (CSeriesType)GetModel(y);

                    return nSort * xType.m_szSeriesType.CompareTo(yType.m_szSeriesType);
                case CConstants.LISTVIEW_SERIES:
                    CSeries xSeries = (CSeries)GetModel(x);
                    CSeries ySeries = (CSeries)GetModel(y);

                    return nSort * xSeries.m_szSeriesTitle.CompareTo(ySeries.m_szSeriesTitle);
                case CConstants.LISTVIEW_ISSUE:
                    CIssue xIssue = (CIssue)GetModel(x);
                    CIssue yIssue = (CIssue)GetModel(y);

                    return nSort * xIssue.m_szIssueTitle.CompareTo(yIssue.m_szIssueTitle);
                default:
                    return nSort * ((ListViewItem)x).Text.CompareTo(((ListViewItem)y).Text);
            }
        }

        public object GetModel( object obj)
        {
            return ((ListViewItem)obj).Tag;
        }
    }
}
