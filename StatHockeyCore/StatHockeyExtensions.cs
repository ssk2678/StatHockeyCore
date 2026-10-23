using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Html;


namespace StatHockeyCore
{
    public static class StatHockeyExtensions
    {
        
            /// <summary>Converts a photo to a base64 string.</summary>
            /// <param name="html">The extended HtmlHelper.</param>
            /// <param name="fileNameandPath">File path and name.</param>
            /// <returns>Returns a base64 string.</returns>
            public static HtmlString PhotoBase64ImgSrc(this HtmlHelper html, string fileNameandPath)
            {
                var byteArray = File.ReadAllBytes(fileNameandPath);
                var base64 = Convert.ToBase64String(byteArray);

                return new HtmlString(String.Format("data:image/gif;base64,{0}", base64));
            }
        
    }
}
