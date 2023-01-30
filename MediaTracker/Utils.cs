using CoreData;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaTracker
{
    public class Utils
    {
        public static void OpenForm(Form fmParent, Form fmChild)
        {
            fmChild.MdiParent = fmParent;
            fmChild.StartPosition = FormStartPosition.CenterParent;
            fmChild.WindowState = FormWindowState.Maximized;
            fmChild.Show();
        }

        public static void RefreshColumnWidth(ListView lv)
        {
            foreach(ColumnHeader c in lv.Columns)
            {
                c.Width = -2;
            }
        }

        public static void UpdateListViewItem(ref ListViewItem pItem, CSeriesType pType)
        {
            pItem.SubItems.Clear();
            pItem.Text = pType.m_szSeriesType;
            pItem.Tag = pType;
            pItem.SubItems.Add(pType.m_szNotes);
        }
        public static void UpdateListViewItem(ref ListViewItem pItem, CSeries pSeries)
        {
            pItem.SubItems.Clear();
            pItem.Text = pSeries.m_szSeriesTitle;
            pItem.Tag = pSeries;
            pItem.SubItems.Add(pSeries.m_szNotes);

            if (pSeries.m_bPinned) pItem.BackColor = Color.Yellow;
            if (pSeries.m_bFavorite) pItem.BackColor = Color.LightBlue;
            if (pSeries.m_bPinned && pSeries.m_bFavorite) pItem.BackColor = Color.LightGreen;
        }

        public static void UpdateListViewItem(ref ListViewItem pItem, CIssue pIssue)
        {
            pItem.SubItems.Clear();
            pItem.Text = pIssue.m_szIssueTitle;
            pItem.Tag = pIssue;
            pItem.SubItems.Add(pIssue.m_nIssueNumber.ToString());
            pItem.SubItems.Add(pIssue.m_bViewed.ToString());

            string szDate = pIssue.m_dtViewed.ToShortDateString();
            if (pIssue.m_dtViewed.Equals(DateTime.MinValue)) szDate = "";
            pItem.SubItems.Add(szDate);

            pItem.SubItems.Add(pIssue.m_bContinuing.ToString());
            pItem.SubItems.Add(pIssue.m_szNotes);
        }
    }
}
