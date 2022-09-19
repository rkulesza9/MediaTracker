using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreData
{
    public class CCoreData
    {
        public static string m_szJsonFilePath = "default.json";
        public static CData m_cData;

        public static void Initialize()
        {
            try
            {
                if (!File.Exists(m_szJsonFilePath))
                {
                    m_cData = new CData();
                    m_cData.m_cSeriesType = new List<CSeriesType>();
                    m_cData.m_cSeries = new List<CSeries>();
                    m_cData.m_cIssues = new List<CIssue>();

                    string szJson = JsonConvert.SerializeObject(m_cData);
                    File.WriteAllText(m_szJsonFilePath, szJson);
                } else
                {
                    string szJson = File.ReadAllText(m_szJsonFilePath);
                    m_cData = JsonConvert.DeserializeObject<CData>(szJson);
                }

            }catch(Exception e)
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
            return m_cData.m_cSeriesType.Where((x) =>
            {
                return x.m_nID == nID;
            }).First();
        }

        public static CSeries GetSeries(int nID)
        {
            return m_cData.m_cSeries.Where((x) => x.m_nID == nID).First();
        }

        public static CIssue GetIssue(int nID)
        {
            return m_cData.m_cIssues.Where((x) => x.m_nID == nID).First();
        }

        public List<CSeries> GetSeriesByType(int nTypeID)
        {
            return m_cData.m_cSeries.Where((x) => x.m_nSeriesTypeID == nTypeID).ToList();
        }

        public List<CIssue> GetIssuesBySeries(int nSeriesID)
        {
            return m_cData.m_cIssues.Where((x) => x.m_nSeriesID == nSeriesID).ToList();
        }

    }
    public class CSeriesType
    {
        public int m_nID;
        public string m_szSeriesType;

        public override string ToString()
        {
            return m_szSeriesType;
        }
    }
    public class CSeries
    {
        public int m_nID;
        public string m_szSeriesTitle;
        public int m_nSeriesTypeID;
        public override string ToString()
        {
            return m_szSeriesTitle;
        }
    }
    public class CIssue
    {
        public int m_nID;
        public int m_nIssueNumber;
        public string m_szIssueTitle;
        public bool m_bViewed;
        public DateTime m_dtViewed;
        public bool m_bContinuing;

        public int m_nSeriesID;

        public override string ToString()
        {
            return $"[#{m_nIssueNumber}] {m_szIssueTitle}";
        }
    }
    public class CData
    {
        public List<CSeriesType> m_cSeriesType;
        public List<CSeries> m_cSeries;
        public List<CIssue> m_cIssues;
    }
}
