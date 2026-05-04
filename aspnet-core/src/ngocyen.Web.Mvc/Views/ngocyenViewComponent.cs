using Abp.AspNetCore.Mvc.ViewComponents;

namespace ngocyen.Web.Views
{
    public abstract class ngocyenViewComponent : AbpViewComponent
    {
        protected ngocyenViewComponent()
        {
            LocalizationSourceName = ngocyenConsts.LocalizationSourceName;
        }
    }
}
