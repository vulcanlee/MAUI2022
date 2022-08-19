using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MA30.Events
{
    public class NavigateToPageEvent : PubSubEvent<NavigateToPagePayload>
    {

    }

    public class NavigateToPagePayload
    {
        public string Url { get; set; }
    }
}
