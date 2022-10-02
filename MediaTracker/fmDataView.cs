using CoreData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaTracker
{
    public partial class fmDataView : Form
    {
        public fmDataView()
        {
            InitializeComponent();
            lvSeriesTypes.DoubleClick += LvSeriesTypes_DoubleClick;
            lvSeries.DoubleClick += LvSeries_DoubleClick;
            lvIssues.DoubleClick += LvIssues_DoubleClick;
            lvSeriesTypes.ColumnClick += LvSeriesTypes_ColumnClick;
            lvSeries.ColumnClick += LvSeries_ColumnClick;
            lvIssues.ColumnClick += LvIssues_ColumnClick;

            PopulateSeriesTypes();
            lvSeriesTypes.ListViewItemSorter = new ListViewItemSorter(CConstants.LISTVIEW_SERIES_TYPE, 0, SortOrder.Ascending);
            lvSeries.ListViewItemSorter = new ListViewItemSorter(CConstants.LISTVIEW_SERIES, 0, SortOrder.Ascending);
            lvIssues.ListViewItemSorter = new ListViewItemSorter(CConstants.LISTVIEW_ISSUE, 0, SortOrder.Ascending);

        }

        private void LvIssues_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            SortOrder pSortOrder = ((ListViewItemSorter)lvIssues.ListViewItemSorter).pSortOrder;
            if (pSortOrder == SortOrder.Ascending) pSortOrder = SortOrder.Descending;
            else pSortOrder = SortOrder.Ascending;
            lvIssues.ListViewItemSorter = new ListViewItemSorter(CConstants.LISTVIEW_ISSUE, e.Column, pSortOrder);

        }

        private void LvSeries_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            SortOrder pSortOrder = ((ListViewItemSorter)lvSeries.ListViewItemSorter).pSortOrder;
            if (pSortOrder == SortOrder.Ascending) pSortOrder = SortOrder.Descending;
            else pSortOrder = SortOrder.Ascending;
            lvSeries.ListViewItemSorter = new ListViewItemSorter(CConstants.LISTVIEW_SERIES, e.Column, pSortOrder);

        }

        private void LvSeriesTypes_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            SortOrder pSortOrder = ((ListViewItemSorter)lvSeriesTypes.ListViewItemSorter).pSortOrder;
            if (pSortOrder == SortOrder.Ascending) pSortOrder = SortOrder.Descending;
            else pSortOrder = SortOrder.Ascending;
            lvSeriesTypes.ListViewItemSorter = new ListViewItemSorter(CConstants.LISTVIEW_SERIES_TYPE, e.Column, pSortOrder);

        }

        private void LvIssues_DoubleClick(object sender, EventArgs e)
        {
            if (lvIssues.SelectedItems.Count > 0) { 

                fmProperty fm = new fmProperty();
                fm.m_pListViewItem = lvIssues.SelectedItems[0];
                fm.m_nClass = CConstants.CLASS_ISSUE;
                fm.Initialize();
                Utils.OpenForm((Form)this.MdiParent, fm);
            }
        }

        private void LvSeries_DoubleClick(object sender, EventArgs e)
        {
            if (lvSeries.SelectedItems.Count > 0)
            {

                fmProperty fm = new fmProperty();
                fm.m_pListViewItem = lvSeries.SelectedItems[0];
                fm.m_nClass = CConstants.CLASS_SERIES;
                fm.Initialize();
                Utils.OpenForm((Form)this.MdiParent, fm);
            }
        }

        private void LvSeriesTypes_DoubleClick(object sender, EventArgs e)
        {
            if(lvSeriesTypes.SelectedItems.Count > 0)
            {

                fmProperty fm = new fmProperty();
                fm.m_pListViewItem = lvSeriesTypes.SelectedItems[0];
                fm.m_nClass = CConstants.CLASS_SERIES_TYPE;
                fm.Initialize();
                Utils.OpenForm(this.MdiParent, fm);
            }
        }

        #region "Populate ListViews"
        private void PopulateSeriesTypes()
        {
            lvSeriesTypes.Items.Clear();

            List<CSeriesType> pAllIssues = CCoreData.m_cData.m_cSeriesType.OrderBy((x) =>
            {
                return x.m_szSeriesType;
            }).ToList();

            foreach (CSeriesType pType in CCoreData.m_cData.m_cSeriesType)
            {
                ListViewItem pItem = new ListViewItem();
                Utils.UpdateListViewItem(ref pItem, pType);
                lvSeriesTypes.Items.Add(pItem);
            }

            Utils.RefreshColumnWidth(lvSeriesTypes);
        }
        private void PopulateSeries(int nTypeID)
        {
            lvSeries.Items.Clear();

            List<CSeries> pAllSeries = CCoreData.GetSeriesByType(nTypeID).OrderBy((x) =>
            {
                return x.m_szSeriesTitle;
            }).ToList();

            foreach (CSeries pSeries in pAllSeries)
            {
                ListViewItem pItem = new ListViewItem();
                Utils.UpdateListViewItem(ref pItem, pSeries);
                lvSeries.Items.Add(pItem);
            }
            Utils.RefreshColumnWidth(lvSeries);
        }
        private void PopulateIssues(int nSeriesID)
        {
            lvIssues.Items.Clear();

            List<CIssue> pAllIssues = CCoreData.GetIssuesBySeries(nSeriesID).OrderByDescending((x) =>
            {
                return x.m_nIssueNumber;
            }).ToList();

            foreach (CIssue pIssue in pAllIssues)
            {
                ListViewItem pItem = new ListViewItem();
                Utils.UpdateListViewItem(ref pItem, pIssue);
                lvIssues.Items.Add(pItem);
            }
            Utils.RefreshColumnWidth(lvIssues);
        }
        #endregion

        private void btnAddSeriesType_Click(object sender, EventArgs e)
        {
            CSeriesType pType = new CSeriesType();
            pType.m_szSeriesType = CConstants.OBJECT_SERIES_TYPE_NEW;
            CCoreData.Add(CConstants.CLASS_SERIES_TYPE, pType);

            ListViewItem pItem = new ListViewItem();
            Utils.UpdateListViewItem(ref pItem, pType);
            lvSeriesTypes.Items.Insert(0,pItem);

            Utils.RefreshColumnWidth(lvSeriesTypes);
        }

        private void btnRmvSeriesType_Click(object sender, EventArgs e)
        {
            if(lvSeriesTypes.SelectedItems.Count > 0)
            {
                CSeriesType pType = (CSeriesType)(lvSeriesTypes.SelectedItems[0].Tag);
                CCoreData.Remove(CConstants.CLASS_SERIES_TYPE, pType);
                lvSeriesTypes.Items.Remove(lvSeriesTypes.SelectedItems[0]);
            }
        }

        private void btnAddSeries_Click(object sender, EventArgs e)
        {
            if (lvSeriesTypes.SelectedItems.Count > 0)
            {
                CSeriesType pType = (CSeriesType)(lvSeriesTypes.SelectedItems[0].Tag);

                CSeries pSeries = new CSeries();
                pSeries.m_nSeriesTypeID = pType.m_nID;
                pSeries.m_szSeriesTitle = CConstants.OBJECT_SERIES_NEW;
                CCoreData.Add(CConstants.CLASS_SERIES, pSeries);

                ListViewItem pItem = new ListViewItem();
                Utils.UpdateListViewItem(ref pItem, pSeries);
                lvSeries.Items.Insert(0, pItem);

                Utils.RefreshColumnWidth(lvSeries);
            }
        }

        private void btnRmvSeries_Click(object sender, EventArgs e)
        {
            if (lvSeries.SelectedItems.Count > 0)
            {
                CSeries pSeries = (CSeries)(lvSeries.SelectedItems[0].Tag);
                CCoreData.Remove(CConstants.CLASS_SERIES, pSeries);
                lvSeries.Items.Remove(lvSeries.SelectedItems[0]);
            }
        }

        private void btnAddIssue_Click(object sender, EventArgs e)
        {
            if (lvSeries.SelectedItems.Count > 0)
            {
                CSeries pSeries = (CSeries)(lvSeries.SelectedItems[0].Tag);

                CIssue pIssue = new CIssue();
                pIssue.m_nSeriesID = pSeries.m_nID;
                pIssue.m_szIssueTitle = CConstants.OBJECT_ISSUE_NEW;
                CCoreData.Add(CConstants.CLASS_ISSUE, pIssue);

                ListViewItem pItem = new ListViewItem();
                pItem.Text = pIssue.m_szIssueTitle;
                pItem.Tag = pIssue;
                lvIssues.Items.Insert(0, pItem);

                Utils.RefreshColumnWidth(lvIssues);
            }
        }

        private void btnRmvIssue_Click(object sender, EventArgs e)
        {
            if (lvIssues.SelectedItems.Count > 0)
            {
                CIssue pIssue = (CIssue)(lvIssues.SelectedItems[0].Tag);
                CCoreData.Remove(CConstants.CLASS_ISSUE, pIssue);
                lvIssues.Items.Remove(lvIssues.SelectedItems[0]);
            }
        }

        private void lvSeriesTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvSeriesTypes.SelectedItems.Count > 0)
            {
                CSeriesType pType = (CSeriesType)(lvSeriesTypes.SelectedItems[0].Tag);
                PopulateSeries(pType.m_nID);
                lvIssues.Items.Clear();
            }
        }

        private void lvSeries_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSeries.SelectedItems.Count > 0)
            {
                CSeries pSeries = (CSeries)(lvSeries.SelectedItems[0].Tag);
                PopulateIssues(pSeries.m_nID);
            }
        }

        private void lblViewOnline_Click(object sender, EventArgs e)
        {
            if (lvIssues.SelectedItems.Count > 0)
            {
                CIssue pIssue = (CIssue)(lvIssues.SelectedItems[0].Tag);
                Process.Start(CConstants.BROWSER_FIREFOX, pIssue.m_szURL);
            }
        }

        private void btnPin_Click(object sender, EventArgs e)
        {
            if(lvSeries.SelectedItems.Count > 0)
            {
                CSeries pSeries = (CSeries) (lvSeries.SelectedItems[0].Tag);
                pSeries.m_bPinned = !pSeries.m_bPinned;

                PopulateSeries(pSeries.m_nSeriesTypeID);
            }
        }

        private void btnFavorite_Click(object sender, EventArgs e)
        {
            if(lvSeries.SelectedItems.Count > 0)
            {
                CSeries pSeries = (CSeries)(lvSeries.SelectedItems[0].Tag);
                pSeries.m_bFavorite = !pSeries.m_bFavorite;

                PopulateSeries(pSeries.m_nSeriesTypeID);
            }
        }
    }
}
