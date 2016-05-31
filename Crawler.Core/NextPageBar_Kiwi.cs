namespace KiwiCrawler.Core
{
    using System;
    public class NextPageBar_Kiwi
    {
        public Int32 PageIndex { get; set; }
        public Int32 PageCount { get; set; }
        public string Xpath { get; set; }
        public string RegularStr { get; set; }
        public NextMode NextPageMode { get; set; }
    }
    public enum NextMode
    {
        Xpath,
        RegularStr
    }
}
