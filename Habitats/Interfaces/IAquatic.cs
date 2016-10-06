﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoolandia.Habitats
{
  interface IAquatic
  {
    bool isFreshwater { get; set; }
    double waterTemperature { get; set; }
    string filterType { get; set; }
    string pumpType { get; set; }
  }
}
