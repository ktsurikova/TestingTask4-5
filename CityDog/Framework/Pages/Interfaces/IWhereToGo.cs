using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Pages.Interfaces
{
    public interface IWhereToGo
    {
        int CountOfAllEvents { get; }
        WhereToGoPage SelectEventType(Events eventName);
    }
}
