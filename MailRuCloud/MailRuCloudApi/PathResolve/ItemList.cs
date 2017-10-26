﻿using System;
using System.Collections.Generic;

namespace YaR.MailRuCloud.Api.PathResolve
{
    public class ItemList
    {
        public IList<ItemLink> Items { get; } = new List<ItemLink>();
    }

    public class ItemLink
    {
        public string Href { get; set; }
        public string MapTo { get; set; }
        public string Name { get; set; }
        public bool IsFile { get; set; }
        public long Size { get; set; }
        public DateTime? CreationDate { get; set; }
    }
}