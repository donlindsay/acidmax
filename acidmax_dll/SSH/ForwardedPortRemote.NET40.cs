﻿using System;
using System.Threading;

namespace TCMSSH
{
    /// <summary>
    /// Provides functionality for remote port forwarding
    /// </summary>
    public partial class ForwardedPortRemote
    {
        /// <summary>
        /// Executes the specified action in a separate thread.
        /// </summary>
        /// <param name="action">The action to execute.</param>
        partial void ExecuteThread(Action action)
        {
            ThreadPool.QueueUserWorkItem(o => action());
        }
    }
}
