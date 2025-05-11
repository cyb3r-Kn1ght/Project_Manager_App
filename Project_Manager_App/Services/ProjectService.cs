using System.Collections.Generic;
using System.Data.SqlClient;
using Project_Manager_App.Models;

namespace Project_Manager_App.Services
{
    public static partial class ProjectService
    {
        private static string connectionString = "Server=26.198.131.10,1433;Database=Proj_Management;User Id=Luan1;Password=luan123;TrustServerCertificate=True;";

        public static List<ProjectData> GetProjectsByUserId(int userId)
        {
            var projectDataList = new List<ProjectData>();
            string query = "SELECT ProjectId, UserId, Title, ImagePath, Progress FROM Projects WHERE UserId = @UserId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserId", userId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var projectData = new ProjectData
                            {
                                ProjectId = (int)reader["ProjectId"],
                                UserId = (int)reader["UserId"],
                                Title = reader["Title"].ToString(),
                                ImagePath = reader["ImagePath"].ToString(),
                                Progress = (int)reader["Progress"]
                            };
                            projectDataList.Add(projectData);
                        }
                    }
                }
            }

            return projectDataList;
        }
    }
}