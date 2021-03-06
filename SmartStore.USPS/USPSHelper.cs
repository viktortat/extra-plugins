using System;
using System.Net;
using System.Text;
using System.Web.Routing;
using SmartStore.Core.Domain.Directory;
using SmartStore.Core.Domain.Payments;
using SmartStore.Web.Framework.Plugins;

namespace SmartStore.USPS
{
    /// <summary>
    /// Represents paypal helper
    /// </summary>
    public static class USPSHelper
    {
        /// <summary>
        /// Gets API URL
        /// </summary>
        /// <returns></returns>
        public static string GetApiUrl(bool useSandbox)
        {
            return useSandbox ?
                "http://production.shippingapis.com/ShippingAPITest.dll" :
                "http://production.shippingapis.com/ShippingAPI.dll";

        }

    }
}

