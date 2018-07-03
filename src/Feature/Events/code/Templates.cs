using Sitecore.Data;

namespace Sitecore.Feature.Events
{
  public struct Templates
  {
    public struct Event
    {
      public static readonly ID ID = new ID("{E6462944-AEC7-44F6-A2FD-32FEE675D61F}");
      public struct Fields
      {
        public static readonly ID Title = new ID("{22779A1F-4ECF-45BD-80D2-BC8AF17FBCA3}");
        public static readonly ID Description = new ID("{42FCA202-0AC9-482E-82F4-AEB49413416D}");
        public static readonly ID Date = new ID("{B3294AF2-C63A-4736-97A1-72C9554FE27A}");
        public static readonly ID Venue = new ID("{96E90B46-2E4D-480D-8FD6-0D2EDC587394}");
        public static readonly ID VenueAddress = new ID("{F1D4F441-D78B-441F-B5E5-DE288008F3FE}");
      }
    }
  }
}