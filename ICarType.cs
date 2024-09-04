﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePatternCar
{
    public interface ICarType
    {
        public void GetEngineType(string engine);
        public void GetFuelType(string fuel);
    }

}
