using System;
using System.Collections.Generic;
using System.Xml;

namespace DynamicMenu
{
    class menuConfig
    {
        List<menus> menuItem = new List<menus>();

        public List<menus> getMenuItems()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("menuItems.serconfig");
            XmlNodeList mItems = doc.SelectNodes("//mmenu");
            foreach (XmlNode item in mItems)
            {
                if (item.HasChildNodes)
                {

                }
                else
                {
                    //menuItem.Add(
                    //   new menus(
                    //       item.Attributes["name"].Value,
                    //       item.Attributes["text"].Value
                    //));
                }
               
            }
          
            return menuItem;
        }

        //public menus isSubMenu(XmlNode item)
        //{
        //    menus subMenu;
        //    if (item.HasChildNodes)
        //    {
        //        XmlNodeList sItems = item.SelectNodes("//smenu");
        //        foreach (XmlNode sitem in sItems)
        //        {
        //            subMenu = new menus(
        //                 sitem.Attributes["name"].Value
        //                , sitem.Attributes["text"].Value
        //                );
        //        }

        //    }
        //    else
        //    {
        //        subMenu = null;
        //    }

        //    return subMenu;
        //}

    }

    class menus
    {
        public String name;
        public String text;
        public menus m;
        public menus(String name, String text)
        {
            this.name = name;
            this.text = text;
        }
        public menus(String name, String text, menus obj)
        {
            this.name = name;
            this.text = text;
            this.m = obj;
        }

    }
}
