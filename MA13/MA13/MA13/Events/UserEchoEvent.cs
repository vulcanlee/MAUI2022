using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MA13.Events
{
    public class UserEchoEvent : PubSubEvent<UserEchoPayload>
    {

    }

    public class UserEchoPayload
    {
        public string EchoMessage { get; set; }
    }
}
