using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreData
{
    public class CCoreData
    {
        public static string m_szJsonFilePath = "";
        public static CData m_cData;

        public static void Initialize()
        {
            try
            {
                string szJson;

                if (!File.Exists(m_szJsonFilePath))
                {
                    m_cData = new CData();
                    m_cData.m_cSeriesType = new List<CSeriesType>();
                    m_cData.m_cSeries = new List<CSeries>();
                    m_cData.m_cIssues = new List<CIssue>();

                    szJson = JsonConvert.SerializeObject(m_cData);
                    File.WriteAllText(m_szJsonFilePath, szJson);
                }

                szJson = File.ReadAllText(m_szJsonFilePath);
                m_cData = JsonConvert.DeserializeObject<CData>(szJson);

            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
            }
        }

        public static void Save()
        {
            try
            {

                string szJson = JsonConvert.SerializeObject(CCoreData.m_cData);
                File.WriteAllText(m_szJsonFilePath, szJson);

            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
            }
        }

        public static CSeriesType GetSeriesType(int nID)
        {
            List<CSeriesType> lsResults = m_cData.m_cSeriesType.Where((x) =>
           {
               return x.m_nID == nID;
           }).ToList();

            if(lsResults.Count > 0)
            {
                return lsResults[0];
            } else
            {
                return new CSeriesType();
            }
        }

        public static CSeries GetSeries(int nID)
        {
            List<CSeries> lsResults = m_cData.m_cSeries.Where((x) => x.m_nID == nID).ToList();

            if(lsResults.Count > 0)
            {
                return lsResults[0];
            } else
            {
                return new CSeries();
            }
        }

        public static CIssue GetIssue(int nID)
        {
            List<CIssue> lsResults = m_cData.m_cIssues.Where((x) => x.m_nID == nID).ToList();
            if (lsResults.Count > 0)
            {
                return lsResults[0];
            }
            else
            {
                return new CIssue();
            }
        }

        public static List<CSeries> GetSeriesByType(int nTypeID)
        {
            return m_cData.m_cSeries.Where((x) => x.m_nSeriesTypeID == nTypeID).ToList();
        }

        public static List<CIssue> GetIssuesBySeries(int nSeriesID)
        {
            return m_cData.m_cIssues.Where((x) => x.m_nSeriesID == nSeriesID).ToList();
        }

        public static void Add(int type, object obj)
        {
            if (type == CConstants.CLASS_SERIES_TYPE)
            {
                CSeriesType cObj = (CSeriesType)obj;
                if (m_cData.m_cSeriesType.Count > 0) cObj.m_nID = m_cData.m_cSeriesType.Max(x => x.m_nID) + 1;
                else cObj.m_nID = 1;
                m_cData.m_cSeriesType.Add(cObj);
            }
            if (type == CConstants.CLASS_SERIES)
            {
                CSeries cObj = (CSeries)obj;
                if (m_cData.m_cSeries.Count > 0) cObj.m_nID = m_cData.m_cSeries.Max(x => x.m_nID) + 1;
                else cObj.m_nID = 1;
                m_cData.m_cSeries.Add(cObj);
            }
            if (type == CConstants.CLASS_ISSUE)
            {
                CIssue cObj = (CIssue)obj;
                if (m_cData.m_cIssues.Count > 0) cObj.m_nID = m_cData.m_cIssues.Max(x => x.m_nID) + 1;
                else cObj.m_nID = 1;
                m_cData.m_cIssues.Add(cObj);
            }
        }

        public static void Remove(int type, object obj)
        {
            if (type == CConstants.CLASS_SERIES_TYPE)
            {
                CSeriesType cObj = (CSeriesType)obj;
                m_cData.m_cSeriesType.Remove(cObj);
            }
            if (type == CConstants.CLASS_SERIES)
            {
                CSeries cObj = (CSeries)obj;
                m_cData.m_cSeries.Remove(cObj);
            }
            if (type == CConstants.CLASS_ISSUE)
            {
                CIssue cObj = (CIssue)obj;
                m_cData.m_cIssues.Remove(cObj);
            }

        }
    }
    public class CDataModel
    {
        public int m_nID = -1;
        public string m_szNotes = "";

        [Browsable(true)]
        [Category("System")]
        [DisplayName("ID")]
        [JsonIgnore]
        public int nID
        {
            get { return m_nID; }
        }

        [Browsable(true)]
        [Category("Properties")]
        [DisplayName("Notes")]
        [JsonIgnore]
        public string szNotes
        {
            get { return m_szNotes; }
            set { m_szNotes = value; }
        }
    }
    public class CSeriesType : CDataModel
    {
        public string m_szSeriesType;

        public override string ToString()
        {
            return m_szSeriesType;
        }

        [Browsable(true)]
        [Category("Properties")]
        [DisplayName("Series Type")]
        [JsonIgnore]
        public string szSeriesType
        {
            get { return m_szSeriesType; }
            set { m_szSeriesType = value; }
        }

    }
    public class CSeries : CDataModel
    {
        public string m_szSeriesTitle="";
        public int m_nSeriesTypeID=-1;
        public bool m_bFavorite=false;
        public bool m_bPinned=false;

        public override string ToString()
        {
            return m_szSeriesTitle;
        }
        [Browsable(true)]
        [Category("Properties")]
        [DisplayName("Type")]
        [JsonIgnore]
        public string szSeriesType
        {
            get { return CCoreData.GetSeriesType(m_nSeriesTypeID).szSeriesType; }
        }
        [Browsable(true)]
        [Category("Properties")]
        [DisplayName("Series Title")]
        [JsonIgnore]
        public string szSeriesTitle
        {
            get { return m_szSeriesTitle; }
            set { m_szSeriesTitle = value; }
        }
    }
    public class CIssue : CDataModel
    {
        public int m_nIssueNumber=1;
        public string m_szIssueTitle="";
        public bool m_bViewed = false;
        public DateTime m_dtViewed = DateTime.Now;
        public bool m_bContinuing = false;
        public string m_szURL = "";

        public int m_nSeriesID = -1;

        public override string ToString()
        {
            return $"[#{m_nIssueNumber}] {m_szIssueTitle}";
        }
        [Browsable(true)]
        [Category("Properties")]
        [DisplayName("Issue Title")]
        [JsonIgnore]
        public string szIssueTitle
        {
            get
            {
                return m_szIssueTitle;
            }
            set
            {
                m_szIssueTitle = value;
            }
        }
        [Browsable(true)]
        [Category("Properties")]
        [DisplayName("Issue #")]
        [JsonIgnore]
        public int nIssueNumber
        {
            get { return m_nIssueNumber; }
            set { m_nIssueNumber = value;}
        }
        [Browsable(true)]
        [Category("Properties")]
        [DisplayName("Viewed")]
        [JsonIgnore]
        public bool bViewed
        {
            get { return m_bViewed; }
            set { m_bViewed = value; }
        }
        [Browsable(true)]
        [Category("Properties")]
        [DisplayName("Date Viewed")]
        [TypeConverter(typeof(CDateTypeConverter))]
        [JsonIgnore]
        public DateTime dtViewed
        {
            get { return m_dtViewed; }
            set { m_dtViewed = value; }
        }
        [Browsable(true)]
        [Category("Properties")]
        [DisplayName("Continue Watching")]
        [JsonIgnore]
        public bool bContinuing
        {
            get { return m_bContinuing; }
            set { m_bContinuing = value; }
        }
        [Browsable(true)]
        [Category("Properties")]
        [DisplayName("Link")]
        [JsonIgnore]
        public string szURl
        {
            get { return m_szURL; }
            set { m_szURL = value; }
        }
    }
    public class CData
    {
        public List<CSeriesType> m_cSeriesType;
        public List<CSeries> m_cSeries;
        public List<CIssue> m_cIssues;
    }
}
