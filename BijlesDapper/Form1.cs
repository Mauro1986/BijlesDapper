using BijlesDapper.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BijlesDapper
{
    public partial class Form1 : Form
    {
        private int SelectedId = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Video video = new Video();
            video.Title = txtTitle.Text;
            video.Genre = CmbGenre.Text;
            video.TimeFrameInMinutes = int.Parse(TxtTime.Text);
            video.Year = int.Parse(TxtYear.Text);

            VideoRepo repo = new VideoRepo();
            repo.AddVideo(video);
            LoadVideos();

        }

        private void LoadVideos()
        {
            VideoRepo repo = new VideoRepo();
            //VideoGrid.DataSource = null;
            VideoGrid.DataSource = repo.GetAllVideos();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //VideoRepo repo = new VideoRepo();
            //VideoGrid.DataSource = repo.GetAllVideos();
            LoadVideos();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            VideoRepo repo = new VideoRepo();
            repo.DeleteVideoById(SelectedId);
            LoadVideos();
        }

        private void VideoGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedId = int.Parse(VideoGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
        }
    }
}
