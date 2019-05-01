using System;
using System.Collections;                   //  ArrayList
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;                          //  StringBuilder
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using Serilog;
using System.Data;                          //  DataTable

/**
 * REFERENCE RSS : http://ajans.dha.com.tr/dha_public_rss.php
 * REFERENCE RSS PARSING: https://www.codeproject.com/Articles/820669/How-to-Parse-RSS-Feeds-in-NET
 */

//  XmlDocument class to download an RSS feed by providing the URL and then load it as an XML file.

namespace HW04
{
    public partial class RSSparsing : System.Web.UI.Page
    {
        public string RSS_SOURCE_URL = @"http://ajans.dha.com.tr/dha_public_rss.php";
        public XmlDocument RSS_XML_DOCUMENT = new XmlDocument();
        ArrayList NEWS_LIST = new ArrayList();
        string LOGGER_FILE_NAME = @"C:\Users\Çamaş\source\repos\HW04\HW04\log.txt";

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                LoadXmlDocument();
                ParseRssNodes();

                gvNews.DataSource = CreateDataTable();
                gvNews.DataBind();
            }
            catch (InvalidExtensionException ie)
            {
                LogError(ie.Message);
            }
            catch (Exception ex)
            {
                LogError(ex.Message);
            }
        }

        private void LogError(string logMessage)
        {
            Log.Logger = new LoggerConfiguration()
                .WriteTo.File(LOGGER_FILE_NAME)
                .CreateLogger();


            Log.Information(logMessage);

            Log.CloseAndFlush();
        }

        private DataTable CreateDataTable()
        {
            DataTable table = new DataTable();

            table.Columns.Add("ID");
            table.Columns.Add("Title");
            table.Columns.Add("Category");

            foreach (News news in NEWS_LIST)
            {
                table.Rows.Add(news.NewsID, news.Title, news.Category);
            }

            return table;
        }

        private void LoadXmlDocument()
        {
            if (!RSS_SOURCE_URL.EndsWith(".php"))
                throw new InvalidExtensionException(RSS_SOURCE_URL.Substring(RSS_SOURCE_URL.LastIndexOf(".")));

            try
            {
                RSS_XML_DOCUMENT.Load(RSS_SOURCE_URL);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        private XmlNodeList GetRssNodes()
        {
            return RSS_XML_DOCUMENT.SelectNodes("rss/channel/item");
        }

        private void ParseRssNodes()
        {
            int id = 0;

            XmlNodeList rssNodes = GetRssNodes();
            foreach (XmlNode rssNode in rssNodes)
            {
                XmlNode rssSubNode = rssNode.SelectSingleNode("title");
                string title = rssSubNode != null ? rssSubNode.InnerText : "";

                rssSubNode = rssNode.SelectSingleNode("description");
                string description = rssSubNode != null ? rssSubNode.InnerText : "";

                rssSubNode = rssNode.SelectSingleNode("category");
                string category = rssSubNode != null ? rssSubNode.InnerText : "";

                rssSubNode = rssNode.SelectSingleNode("author");
                string author = rssSubNode != null ? rssSubNode.InnerText : "";

                rssSubNode = rssNode.SelectSingleNode("pubDate");
                string pubDate = rssSubNode != null ? rssSubNode.InnerText : "";

                rssSubNode = rssNode.SelectSingleNode("image");
                string imageUrl = rssSubNode != null ? rssSubNode.InnerText : "";


                NEWS_LIST.Add(
                    new News(id, title, description, category, author, pubDate, imageUrl)
                    );

                id++;
            }
        }
    }
}