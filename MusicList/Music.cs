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
        public int num { get; set; }

        // 날짜
        public String date { get; set; }

        // 첫번째곡
        public String first_music { get; set; }

        // 첫번째 곡 아티스트
        public String first_artist { get; set; }

        // 두번째곡
        public String second_music { get; set; }

        // 두번째 곡 아티스트
        public String second_artist { get; set; }
    }
}
