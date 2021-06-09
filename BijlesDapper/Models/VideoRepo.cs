using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BijlesDapper.Models
{
    public class VideoRepo
    {
        public void AddVideo(Video video)
        {
            string sql = "INSERT INTO Movies1(Title, Genre, TimeFrameInMinutes, Year)" +
                "VALUES(@Title, @Genre, @TimeFrameInMinutes, @Year)";
            using (IDbConnection connection = new SqlConnection(Helper.ConStr("Videos")))
            {
                connection.Query<int>(sql, video).SingleOrDefault();
            }
        }
        public List<Video> GetAllVideos()
        {
            using (IDbConnection connection = new SqlConnection(Helper.ConStr("Videos")))
            {
                return connection.Query<Video>("Select * from Movies1").ToList();
            }
        }

        public void DeleteVideoById(int id)
        {
            using (IDbConnection connection = new SqlConnection(Helper.ConStr("Videos")))
            {
              connection.Execute("Delete from Movies1 where Id=@Id", new { Id = id });
            }

        }
    }
}
