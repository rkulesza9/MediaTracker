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
    public partial class fmProperty : Form
    {
        public ListViewItem m_pListViewItem;
        public int m_nClass;

        public fmProperty()
        {
            InitializeComponent();
            propertyGrid1.PropertyValueChanged += PropertyGrid1_PropertyValueChanged;
        }

        private void PropertyGrid1_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            CCoreData.Save();

            if(m_nClass == CConstants.CLASS_SERIES_TYPE)
                Utils.UpdateListViewItem(ref m_pListViewItem, (CSeriesType) m_pListViewItem.Tag);
            else if(m_nClass == CConstants.CLASS_SERIES)
                Utils.UpdateListViewItem(ref m_pListViewItem, (CSeries) m_pListViewItem.Tag);
            else if(m_nClass == CConstants.CLASS_ISSUE)
                Utils.UpdateListViewItem(ref m_pListViewItem, (CIssue) m_pListViewItem.Tag);
        }

        public void Initialize()
        {
            propertyGrid1.SelectedObject = m_pListViewItem.Tag;
        }

        
    }
}
