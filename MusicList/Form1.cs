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
            new Music() { num = 1, date = "0807", first_music = "Super Shy", first_artist = "NewJeans", second_music = "Spicy", second_artist = "aespa" },
            new Music() { num = 2, date = "0808", first_music = "Kitsch", first_artist = "IVE", second_music = "Queencard", second_artist = "I-DEL" },
            new Music() { num = 3, date = "0809", first_music = "Hype boy", first_artist = "NewJeans", second_music = "Teddy Bear", second_artist = "STAYC" },
            new Music() { num = 4, date = "0810", first_music = "OMG", first_artist = "NewJeans", second_music = "Steal The Show", second_artist = "Lauv" },
            new Music() { num = 5, date = "0811", first_music = "KNOCK", first_artist = "이채연", second_music = "손오공", second_artist = "seventeen" },
            new Music() { num = 6, date = "0814", first_music = "오르트구름", first_artist = "윤하", second_music = "그라데이션", second_artist = "10cm" },
            new Music() { num = 7, date = "0815", first_music = "", first_artist = "", second_music = "Spicy", second_artist = "aespa" },
            new Music() { num = 8, date = "0816", first_music = "", first_artist = "NewJeans", second_music = "Spicy", second_artist = "aespa" },
            new Music() { num = 9, date = "0817", first_music = "", first_artist = "NewJeans", second_music = "Spicy", second_artist = "aespa" },
            new Music() { num = 10, date = "0818", first_music = "", first_artist = "NewJeans", second_music = "Spicy", second_artist = "aespa" },
            new Music() { num = 11, date = "0821", first_music = "", first_artist = "NewJeans", second_music = "Spicy", second_artist = "aespa" },
            new Music() { num = 12, date = "0822", first_music = "", first_artist = "NewJeans", second_music = "Spicy", second_artist = "aespa" },
            new Music() { num = 13, date = "0823", first_music = "", first_artist = "NewJeans", second_music = "Spicy", second_artist = "aespa" },
            new Music() { num = 14, date = "0824", first_music = "", first_artist = "NewJeans", second_music = "Spicy", second_artist = "aespa" },
            new Music() { num = 15, date = "0825", first_music = "", first_artist = "NewJeans", second_music = "Spicy", second_artist = "aespa" },
            new Music() { num = 16, date = "0828", first_music = "", first_artist = "NewJeans", second_music = "Spicy", second_artist = "aespa" },
            new Music() { num = 17, date = "0829", first_music = "", first_artist = "NewJeans", second_music = "Spicy", second_artist = "aespa" },
            new Music() { num = 18, date = "0830", first_music = "", first_artist = "NewJeans", second_music = "Spicy", second_artist = "aespa" },
            new Music() { num = 19, date = "0831", first_music = "", first_artist = "NewJeans", second_music = "Spicy", second_artist = "aespa" },
            new Music() { num = 20, date = "0901", first_music = "", first_artist = "NewJeans", second_music = "Spicy", second_artist = "aespa" },
            new Music() { num = 21, date = "0904", first_music = "", first_artist = "NewJeans", second_music = "Spicy", second_artist = "aespa" }

        };
        public Form1()
        {
            InitializeComponent();
        }

        // 전체목록
        private void button1_Click(object sender, EventArgs e)
        {
            BindingSource.DataSource = from item in musics
                                       select item;
        }

        
        // 이번주 목록
        private void button2_Click_1(object sender, EventArgs e)
        {
            BindingSource.DataSource = from item in musics
                                       where item.num < 6 
                                       select item;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // 오늘 노래 목록
        private void button3_Click(object sender, EventArgs e)
        {
            BindingSource.DataSource = from item in musics
                                       where item.num == 4
                                       select item;
        }

        // 첫번째 아티스트 별 목록
        private void button4_Click(object sender, EventArgs e)
        {
            BindingSource.DataSource = from item in musics
                                       orderby item.first_artist
                                       select item;
        }

        // 다음주 노래 목록 보기
        private void button5_Click(object sender, EventArgs e)
        {
            BindingSource.DataSource = from item in musics
                                      where item.num < 10 && item.num > 5
                                      select item;
        }
    }
}
