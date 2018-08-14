using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

public enum PageType { Page1, Page2 }
namespace Gymnastic_User
{

    public class MasterDetailPage1MenuItem : Button
    {
        public PageType pageType;
        public MasterDetailPage1MenuItem( string text , PageType pageType)
        {
            Text = text;
            this.pageType = pageType;
        }
    }
}