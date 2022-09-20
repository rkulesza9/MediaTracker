using CoreData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            PopulateSeriesTypes();


        }

        #region "Populate ListViews"
        private void PopulateSeriesTypes()
        {
            lvSeriesTypes.Items.Clear();
            foreach(CSeriesType pType in CCoreData.m_cData.m_cSeriesType)
            {
                ListViewItem pItem = new ListViewItem();
                pItem.Text = pType.m_szSeriesType;
                pItem.Tag = pType;
                lvSeriesTypes.Items.Add(pItem);
            }

            Utils.RefreshColumnWidth(lvSeriesTypes);
        }
        private void PopulateSeries(int nTypeID)
        {
            lvSeries.Items.Clear();
            foreach(CSeries pSeries in CCoreData.GetSeriesByType(nTypeID))
            {
                ListViewItem pItem = new ListViewItem();
                pItem.Text = pSeries.m_szSeriesTitle;
                pItem.Tag = pSeries;
                lvSeries.Items.Add(pItem);
            }
            Utils.RefreshColumnWidth(lvSeries);
        }
        private void PopulateIssues(int nSeriesID)
        {
            lvIssues.Items.Clear();
            foreach(CIssue pIssue in CCoreData.GetIssuesBySeries(nSeriesID))
            {
                ListViewItem pItem = new ListViewItem();
                pItem.Text = pIssue.m_szIssueTitle;
                pItem.Tag = pIssue;
                pItem.SubItems.Add(pIssue.m_nIssueNumber.ToString());
                pItem.SubItems.Add(pIssue.m_bViewed.ToString());
                pItem.SubItems.Add(pIssue.m_dtViewed.ToShortDateString());
                pItem.SubItems.Add(pIssue.m_bContinuing.ToString());
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
            pItem.Text = pType.m_szSeriesType;
            pItem.Tag = pType;
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
                pItem.Text = pSeries.m_szSeriesTitle;
                pItem.Tag = pSeries;
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
    }
}
