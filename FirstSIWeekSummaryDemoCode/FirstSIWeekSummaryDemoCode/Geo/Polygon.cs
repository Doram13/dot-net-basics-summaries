﻿using System;

namespace FirstSIWeekSummaryDemoCode.Geo
{
    public abstract class Polygon : IComparable
    {
        private int _points;

        protected Polygon(int points)
        {
            _points = points;
        }

        protected Polygon()
        {

        }

        public abstract double Range();
        public abstract double Area();

        public int CompareTo(object polygonObj)
        {
            var otherArea = ((Polygon)polygonObj).Area();
            return Area().CompareTo(otherArea);
        }
    }
}
