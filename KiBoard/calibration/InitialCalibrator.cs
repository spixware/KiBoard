﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace KiBoard
{
    class InitialCalibrator : Calibrator
    {
        private List<CalibrationPoint> list;


        public InitialCalibrator()
        {
            CalibrationPoint calPoint1 = new CalibrationPoint(new Vector3(1, 0, 1), new Vector3(1, 0, 0));
            CalibrationPoint calPoint2 = new CalibrationPoint(new Vector3(1, 1, 1), new Vector3(1, 1, 0));
            CalibrationPoint calPoint3 = new CalibrationPoint(new Vector3(0, 1, 1), new Vector3(0, 1, 0));
            CalibrationPoint calPoint4 = new CalibrationPoint(new Vector3(0, 0, 1), new Vector3(0, 0, 0));
            list = new List<CalibrationPoint>();
            list.Add(calPoint1);
            list.Add(calPoint2);
            list.Add(calPoint3);
            list.Add(calPoint4);
        }


        public List<CalibrationPoint> getCalibrationPoints()
        {
            return list;
        }

        public bool hasCalibrationPoints()
        {
            int counter = 0;
            foreach (var item in list)
            {
                counter++;
            }

            if (counter == 4)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        //used later to get synchronized joint data per frame
        public void tick()
        {
            throw new NotImplementedException();
        }
    }
}
