using System;

//코드출처: https://gist.github.com/fronteer-kr/14d7f779d52a21ac2f16,
//코드출처: https://blog.naver.com/panchrus_l0/221549318095

namespace WeatherViewer
{
    public struct lamc_parameter
    {
        public double Re;          /* 사용할 지구반경 [ km ]      */
        public double grid;        /* 격자간격        [ km ]      */
        public double slat1;       /* 표준위도        [degree]    */
        public double slat2;       /* 표준위도        [degree]    */
        public double olon;        /* 기준점의 경도   [degree]    */
        public double olat;        /* 기준점의 위도   [degree]    */
        public double xo;          /* 기준점의 X좌표  [격자거리]  */
        public double yo;          /* 기준점의 Y좌표  [격자거리]  */
    };

    internal class LocationTool
    {
        public class WgsToBaseStationCoord
        {
            lamc_parameter map;

            public WgsToBaseStationCoord()
            {
                map.Re = 6371.00877;         // 지도반경
                map.grid = 5.0;              // 격자간격 (km)
                map.slat1 = 30.0;            // 표준위도 1
                map.slat2 = 60.0;            // 표준위도 2
                map.olon = 126.0;            // 기준점 경도
                map.olat = 38.0;             // 기준점 위도
                map.xo = 43;                 // 기준점 X좌표
                map.yo = 136;                // 기준점 Y좌표
            }

            public LatXLonY dfs_xy_conv(double _dLat, double _dLon)
            {
                double DEGARD = Math.PI / 180.0;
                //double RADDEG = 180.0 / Math.PI;

                double re = map.Re / map.grid;
                double slat1 = map.slat1 * DEGARD;
                double slat2 = map.slat2 * DEGARD;
                double olon = map.olon * DEGARD;
                double olat = map.olat * DEGARD;

                double sn = Math.Tan(Math.PI * 0.25 + slat2 * 0.5) / Math.Tan(Math.PI * 0.25 + slat1 * 0.5);
                sn = Math.Log(Math.Cos(slat1) / Math.Cos(slat2)) / Math.Log(sn);
                double sf = Math.Tan(Math.PI * 0.25 + slat1 * 0.5);
                sf = Math.Pow(sf, sn) * Math.Cos(slat1) / sn;
                double ro = Math.Tan(Math.PI * 0.25 + olat * 0.5);
                ro = re * sf / Math.Pow(ro, sn);

                LatXLonY rs = new LatXLonY();
                rs.lat = _dLat;
                rs.lon = _dLon;

                double ra = Math.Tan(Math.PI * 0.25 + _dLat * DEGARD * 0.5);
                ra = re * sf / Math.Pow(ra, sn);
                double theta = _dLon * DEGARD - olon;
                if (theta > Math.PI) theta -= 2.0 * Math.PI;
                if (theta < -Math.PI) theta += 2.0 * Math.PI;
                theta *= sn;
                rs.x = Math.Floor(ra * Math.Sin(theta) + map.xo + 0.5);
                rs.y = Math.Floor(ro - ra * Math.Cos(theta) + map.yo + 0.5);

                return rs;
            }
        }

        public class LatXLonY
        {
            public double lat;
            public double lon;

            public double x;
            public double y;
        }
    }
}
