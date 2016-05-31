
/// <summary>
/// Kiwi
/// </summary>

namespace KiwiCrawler.Core
{
    using KiwiCrawler.Core;
    using System;
    using System.Collections.Generic;    

    public delegate void DynamicGoNextPageEventHandler(DynamicGoNextPageEventArgs args);
    public class DynamicGoNextPageEventArgs:EventArgs
    {
        public UrlInfo UrlInfo { get; set; }        
        public object ObjInt32PageIndex { get; set; }
        public object ObjBoolIsDomComplated { get; set; }        
        public string Html { get; set; }
    }
}
