using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicList
{
    public partial class Form1 : Form
    {
        static private List<Music> musics = new List<Music>()
        {
            new Music() { Num = 1, Date = "0807", First_music = "Super Shy", First_artist = "NewJeans", Second_music = "Spicy", Second_artist = "aespa" },
            new Music() { Num = 2, Date = "0808", First_music = "Kitsch", First_artist = "IVE", Second_music = "Queencard", Second_artist = "I-DEL" },
            new Music() { Num = 3, Date = "0809", First_music = "Hype boy", First_artist = "NewJeans", Second_music = "Teddy Bear", Second_artist = "STAYC" },
            new Music() { Num = 4, Date = "0810", First_music = "OMG", First_artist = "NewJeans", Second_music = "Steal The Show", Second_artist = "Lauv" },
            new Music() { Num = 5, Date = "0811", First_music = "KNOCK", First_artist = "이채연", Second_music = "손오공", Second_artist = "seventeen" },
            new Music() { Num = 6, Date = "0814", First_music = "오르트구름", First_artist = "윤하", Second_music = "그라데이션", Second_artist = "10cm" },
            new Music() { Num = 7, Date = "0815", First_music = "으아", First_artist = "", Second_music = "Spicy", Second_artist = "aespa" },
            new Music() { Num = 8, Date = "0816", First_music = "으아", First_artist = "NewJeans", Second_music = "Spicy", Second_artist = "aespa" },
            new Music() { Num = 9, Date = "0817", First_music = "으아", First_artist = "NewJeans", Second_music = "Spicy", Second_artist = "aespa" },
            new Music() { Num = 10, Date = "0818", First_music = "으아", First_artist = "NewJeans", Second_music = "Spicy", Second_artist = "aespa" },
            new Music() { Num = 11, Date = "0821", First_music = "으아", First_artist = "NewJeans", Second_music = "Spicy", Second_artist = "aespa" },
            new Music() { Num = 12, Date = "0822", First_music = "으아", First_artist = "NewJeans", Second_music = "Spicy", Second_artist = "aespa" },
            new Music() { Num = 13, Date = "0823", First_music = "으아", First_artist = "NewJeans", Second_music = "Spicy", Second_artist = "aespa" },
            new Music() { Num = 14, Date = "0824", First_music = "으아", First_artist = "NewJeans", Second_music = "Spicy", Second_artist = "aespa" },
            new Music() { Num = 15, Date = "0825", First_music = "으아", First_artist = "NewJeans", Second_music = "Spicy", Second_artist = "aespa" },
            new Music() { Num = 16, Date = "0828", First_music = "으아", First_artist = "NewJeans", Second_music = "Spicy", Second_artist = "aespa" },
            new Music() { Num = 17, Date = "0829", First_music = "으아", First_artist = "NewJeans", Second_music = "Spicy", Second_artist = "aespa" },
            new Music() { Num = 18, Date = "0830", First_music = "으아", First_artist = "NewJeans", Second_music = "Spicy", Second_artist = "aespa" },
            new Music() { Num = 19, Date = "0831", First_music = "으아", First_artist = "NewJeans", Second_music = "Spicy", Second_artist = "aespa" },
            new Music() { Num = 20, Date = "0901", First_music = "으아", First_artist = "NewJeans", Second_music = "Spicy", Second_artist = "aespa" },
            new Music() { Num = 21, Date = "0904", First_music = "으아", First_artist = "NewJeans", Second_music = "Spicy", Second_artist = "aespa" }

        };
        public Form1()
        {
            InitializeComponent();
        }

        // 전체목록
        private void button1_Click(object sender, EventArgs e)
        {
            musicBindingSource.DataSource = from item in musics
                                       select item;
        }

        
        // 이번주 목록
        private void button2_Click_1(object sender, EventArgs e)
        {
            musicBindingSource.DataSource = from item in musics
                                       where item.Num < 6
                                       select item;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // 오늘 노래 목록
        private void button3_Click(object sender, EventArgs e)
        {
            musicBindingSource.DataSource = from item in musics
                                       where item.Num == 4
                                       select item;
        }

        // 첫번째 아티스트 별 목록
        private void button4_Click(object sender, EventArgs e)
        {
            musicBindingSource.DataSource = from item in musics
                                       orderby item.First_artist
                                       select item;
        }

        // 다음주 노래 목록 보기
        private void button5_Click(object sender, EventArgs e)
        {
            musicBindingSource.DataSource = from item in musics
                                       where item.Num < 10 && item.Num > 5
                                       select item;
        }
    }
}
