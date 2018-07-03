using Sitecore.Data.Items;
using Sitecore.Data.Managers;

namespace Sitecore.Feature.Events
{
  public static class HelixMethods
  {
    //Location
    //Sitecore.Foundation.SitecoreExtensions.Extensions.ItemExtensions
    public static bool IsDerived(this Item item, Item templateId)
    {
      if (item == null)
      {
        return false;
      }
      return !templateId.Empty && item.IsDerived(item.Database.Templates[templateId.ToString()]);
    }
    public static bool Is_Derived(this Item item, Item templateItem)
    {
      if (item == null)
      {
        return false;
      }
      if (templateItem == null)
      {
        return false;
      }
      var itemTemplate = TemplateManager.GetTemplate(item);
      return itemTemplate != null && (itemTemplate.ID == templateItem.ID || itemTemplate.DescendsFrom(templateItem.ID));
    }
  }
}