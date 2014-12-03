using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GladToHaveYou.Resources.RentalContent
{
    public class RentalContentTexts
    {
        public string Title { get; set; }
        public string HelpText { get; set; }
        public string Keywords { get; set; }
    }
        
    public class RentalContentStringsManager
    {
        public static RentalContentTexts GetText(String tag)
        {
            var key = tag.Replace(".", "_");

            return new RentalContentTexts()
            {
                Title = RentalContentStrings.ResourceManager.GetString(key + "_title"),
                HelpText = RentalContentStrings.ResourceManager.GetString(key + "_helptext"),
                Keywords = RentalContentStrings.ResourceManager.GetString(key + "_keywords"),
            };
        }
    }
}
