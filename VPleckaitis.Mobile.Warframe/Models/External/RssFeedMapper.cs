using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using VPleckaitis.Mobile.Warframe.Helpers;

namespace VPleckaitis.Mobile.Warframe.Models.External
{
    public static class RssFeedMapper
    {
        public static Alert Map<T>(this RssFeedModel entity) where T : Alert
        {
            return new Alert()
            {
                Id = entity.guid,
                Type = entity.author,
                Description = entity.title,
                Start = DateTime.Parse(entity.pubDate)
            };
        }

        public static List<RssFeedModel> Map<T>(this string data) where T : List<RssFeedModel>
        {
            List<RssFeedModel> list = new List<RssFeedModel>();
            XmlDocument dataXml = new XmlDocument();
            dataXml.LoadXml(data);
            if(dataXml.SelectSingleNode("rss/channel")!= null)
            {
                foreach(XmlNode node in dataXml.SelectNodes("rss/channel/item"))
                {
                    list.Add(XmlSerialiserHelper.ConvertNode<RssFeedModel>(node));
                }
            }
            return list;
        }
    }
}
