namespace MusicList
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstmusicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstartistDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secondmusicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secondartistDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musicBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.firstmusicDataGridViewTextBoxColumn,
            this.firstartistDataGridViewTextBoxColumn,
            this.secondmusicDataGridViewTextBoxColumn,
            this.secondartistDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.musicBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(793, 530);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.BindingContextChanged += new System.EventHandler(this.Form1_Load);
            // 
            // numDataGridViewTextBoxColumn
            // 
            this.numDataGridViewTextBoxColumn.DataPropertyName = "Num";
            this.numDataGridViewTextBoxColumn.HeaderText = "Num";
            this.numDataGridViewTextBoxColumn.Name = "numDataGridViewTextBoxColumn";
            this.numDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstmusicDataGridViewTextBoxColumn
            // 
            this.firstmusicDataGridViewTextBoxColumn.DataPropertyName = "First_music";
            this.firstmusicDataGridViewTextBoxColumn.HeaderText = "First_music";
            this.firstmusicDataGridViewTextBoxColumn.Name = "firstmusicDataGridViewTextBoxColumn";
            this.firstmusicDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstartistDataGridViewTextBoxColumn
            // 
            this.firstartistDataGridViewTextBoxColumn.DataPropertyName = "First_artist";
            this.firstartistDataGridViewTextBoxColumn.HeaderText = "First_artist";
            this.firstartistDataGridViewTextBoxColumn.Name = "firstartistDataGridViewTextBoxColumn";
            this.firstartistDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // secondmusicDataGridViewTextBoxColumn
            // 
            this.secondmusicDataGridViewTextBoxColumn.DataPropertyName = "Second_music";
            this.secondmusicDataGridViewTextBoxColumn.HeaderText = "Second_music";
            this.secondmusicDataGridViewTextBoxColumn.Name = "secondmusicDataGridViewTextBoxColumn";
            this.secondmusicDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // secondartistDataGridViewTextBoxColumn
            // 
            this.secondartistDataGridViewTextBoxColumn.DataPropertyName = "Second_artist";
            this.secondartistDataGridViewTextBoxColumn.HeaderText = "Second_artist";
            this.secondartistDataGridViewTextBoxColumn.Name = "secondartistDataGridViewTextBoxColumn";
            this.secondartistDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // musicBindingSource
            // 
            this.musicBindingSource.DataSource = typeof(MusicList.Music);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 84);
            this.button1.TabIndex = 1;
            this.button1.Text = "전체목록";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(177, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 84);
            this.button2.TabIndex = 2;
            this.button2.Text = "이번주 노래 목록 보기";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(342, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 84);
            this.button3.TabIndex = 3;
            this.button3.Text = "오늘 노래 목록 보기";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(507, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(133, 84);
            this.button4.TabIndex = 4;
            this.button4.Text = "첫번째 아티스트별로 보기";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(672, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(133, 84);
            this.button5.TabIndex = 5;
            this.button5.Text = "다음주 노래 목록 보기";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 655);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "3204 김하늘";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridViewTextBoxColumn numDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstmusicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstartistDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn secondmusicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn secondartistDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource musicBindingSource;
    }
}

