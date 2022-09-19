﻿using CoreData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaTracker
{
    public partial class fmMain : Form
    {
        public fmDataView m_fmDataView;
        public fmMain()
        {
            InitializeComponent();
            this.FormClosed += FmMain_FormClosed;
            lblFilename.Text = CConstants.STATUS_BAR_TEXT;
        }

        private void FmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            CCoreData.Save();
            lblFilename.Text = CConstants.STATUS_BAR_TEXT;
        }

        private void menuNew_Click(object sender, EventArgs e)
        {
            SaveFileDialog ofd = new SaveFileDialog();
            ofd.Filter = CConstants.FILE_DIALOG_FILTER;
            ofd.Title = CConstants.FILE_DIALOG_TITLE_NEW;
            ofd.InitialDirectory = Environment.SpecialFolder.UserProfile.ToString();
            DialogResult result = ofd.ShowDialog();

            if(result == DialogResult.OK)
            {
                CCoreData.m_szJsonFilePath = ofd.FileName;
                CCoreData.Initialize();
                lblFilename.Text = ofd.FileName;

                MessageBox.Show(CConstants.FILE_DIALOG_MSGBOX_NEW);

                if(m_fmDataView == null || m_fmDataView.IsDisposed) m_fmDataView = new fmDataView();
                m_fmDataView.Text = ofd.FileName;
                Utils.OpenForm(this, m_fmDataView);
            } else
            {

            }
        }

        private void menuOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = CConstants.FILE_DIALOG_FILTER;
            ofd.Title = CConstants.FILE_DIALOG_MSGBOX_OPEN;
            ofd.InitialDirectory = Environment.SpecialFolder.UserProfile.ToString();
            DialogResult result = ofd.ShowDialog();

            if (result == DialogResult.OK)
            {
                CCoreData.m_szJsonFilePath = ofd.FileName;
                CCoreData.Initialize();
                lblFilename.Text = ofd.FileName;

                MessageBox.Show(CConstants.FILE_DIALOG_MSGBOX_OPEN);

                if (m_fmDataView == null || m_fmDataView.IsDisposed) m_fmDataView = new fmDataView();
                m_fmDataView.Text = ofd.FileName;
                Utils.OpenForm(this, m_fmDataView);
            }
            else
            {

            }
        }

        private void menuSave_Click(object sender, EventArgs e)
        {
            if(CCoreData.m_cData != null)
            {
                CCoreData.Save();

                MessageBox.Show(CConstants.FILE_DIALOG_MSGBOX_SAVE); 
                
                if (m_fmDataView == null || m_fmDataView.IsDisposed) m_fmDataView = new fmDataView();
                m_fmDataView.Text = CCoreData.m_szJsonFilePath;
                Utils.OpenForm(this, m_fmDataView);
            }
        }

        private void menuSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog ofd = new SaveFileDialog();
            ofd.Filter = CConstants.FILE_DIALOG_FILTER;
            ofd.Title = CConstants.FILE_DIALOG_TITLE_SAVEAS;
            ofd.InitialDirectory = Environment.SpecialFolder.UserProfile.ToString();
            DialogResult result = ofd.ShowDialog();

            if (result == DialogResult.OK && CCoreData.m_cData != null)
            {
                CCoreData.m_szJsonFilePath = ofd.FileName;
                CCoreData.Save();
                lblFilename.Text = ofd.FileName;

                MessageBox.Show(CConstants.FILE_DIALOG_MSGBOX_SAVEAS); 
                
                if (m_fmDataView == null || m_fmDataView.IsDisposed) m_fmDataView = new fmDataView();
                m_fmDataView.Text = ofd.FileName;
                Utils.OpenForm(this, m_fmDataView);
            }
            else
            {

            }
        }

        private void menuSeriesType_Click(object sender, EventArgs e)
        {

        }

        private void menuSeries_Click(object sender, EventArgs e)
        {

        }

        private void menuIssues_Click(object sender, EventArgs e)
        {

        }
    }
}