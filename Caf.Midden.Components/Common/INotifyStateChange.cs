﻿using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caf.Midden.Components.Common
{
    public interface INotifyStateChange
    {
        event Action<ComponentBase, string> StateChanged;
        void NotifyStateChange(ComponentBase source, string property);
    }
}
