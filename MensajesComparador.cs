﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace concesionarioApp
{
    class MensajesComparador : IComparer
    {
        public int Compare(object x, object y)
        {
            return (new CaseInsensitiveComparer()).Compare(((MensajesChat)x).fecha,
                   ((MensajesChat)y).fecha);
        }
    }
}
