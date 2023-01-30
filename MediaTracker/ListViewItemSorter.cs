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

            if (m_pSortOrder == SortOrder.Ascending) nSort = 1;
            else nSort = -1;

            switch (m_nListViewID)
            {
                case CConstants.LISTVIEW_SERIES_TYPE:
                    CSeriesType xType = (CSeriesType)GetModel(x);
                    CSeriesType yType = (CSeriesType)GetModel(y);

                    if(m_nColumn == 0) return nSort * xType.m_szSeriesType.CompareTo(yType.m_szSeriesType);
                    if(m_nColumn == 1) return nSort * xType.m_szNotes.CompareTo(yType.m_szNotes);
                    return -1;
                case CConstants.LISTVIEW_SERIES:
                    CSeries xSeries = (CSeries)GetModel(x);
                    CSeries ySeries = (CSeries)GetModel(y);

                    int nPinned = xSeries.m_bPinned.CompareTo(ySeries.m_bPinned);
                    if (nPinned != 0) return -1*nPinned;

                    if (m_nColumn == 0) return nSort * xSeries.m_szSeriesTitle.CompareTo(ySeries.m_szSeriesTitle); 
                    if (m_nColumn == 1) return nSort * xSeries.m_szNotes.CompareTo(ySeries.m_szNotes);
                    return -1;
                case CConstants.LISTVIEW_ISSUE:
                    CIssue xIssue = (CIssue)GetModel(x);
                    CIssue yIssue = (CIssue)GetModel(y);

                    if (m_nColumn == 0) return nSort * xIssue.m_szIssueTitle.CompareTo(yIssue.m_szIssueTitle);
                    if (m_nColumn == 1) return nSort * xIssue.m_nIssueNumber.CompareTo(yIssue.m_nIssueNumber);
                    if (m_nColumn == 2) return nSort * xIssue.m_bViewed.CompareTo(yIssue.m_bViewed);
                    if (m_nColumn == 3) return nSort * xIssue.m_dtViewed.CompareTo(yIssue.dtViewed);
                    if (m_nColumn == 4) return nSort * xIssue.m_bContinuing.CompareTo(yIssue.m_bContinuing);
                    if (m_nColumn == 5) return nSort * xIssue.m_szNotes.CompareTo(yIssue.m_szNotes);
                    return -1;
                default:
                    CDataModel xData = (CDataModel)GetModel(x);
                    CDataModel yData = (CDataModel)GetModel(y);

                    return nSort * xData.m_dtLastUpdated.CompareTo(yData.m_dtLastUpdated);
            }
        }

        public object GetModel( object obj)
        {
            return ((ListViewItem)obj).Tag;
        }
    }
}
