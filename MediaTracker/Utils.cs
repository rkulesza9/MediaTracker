﻿using CoreData;
using System;
using System.Collections.Generic;
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
        }
        public static void UpdateListViewItem(ref ListViewItem pItem, CSeries pSeries)
        {
            pItem.SubItems.Clear();
            pItem.Text = pSeries.m_szSeriesTitle;
            pItem.Tag = pSeries;
        }

        public static void UpdateListViewItem(ref ListViewItem pItem, CIssue pIssue)
        {
            pItem.SubItems.Clear();
            pItem.Text = pIssue.m_szIssueTitle;
            pItem.Tag = pIssue;
            pItem.SubItems.Add(pIssue.m_nIssueNumber.ToString());
            pItem.SubItems.Add(pIssue.m_bViewed.ToString());
            pItem.SubItems.Add(pIssue.m_dtViewed.ToShortDateString());
            pItem.SubItems.Add(pIssue.m_bContinuing.ToString());
        }
    }
}
