using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicList
{
    internal class Music
    {
        // 번호
        public int Num { get; set; }

        // 날짜
        public String Date { get; set; }

        // 첫번째곡
        public String First_music { get; set; }

        // 첫번째 곡 아티스트
        public String First_artist { get; set; }

        // 두번째곡
        public String Second_music { get; set; }

        // 두번째 곡 아티스트
        public String Second_artist { get; set; }
    }
}
