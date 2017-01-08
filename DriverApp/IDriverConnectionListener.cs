﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriverApp
{
    public interface IDriverConnectionListener
    {
        void OnConnected();

        void OnDisconnected();
    }
}
