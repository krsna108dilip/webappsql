using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using webappsql.Models;

namespace webappsql.Services
{
    public interface ICourseService
    {
        IEnumerable<Course> GetCourses(string connectionString);
    }

    public class CourseService : ICourseService
    {
        private static string db_source = "webapp-server-demo.database.windows.net";
        private static string db_user = "adminuser";
        private static string db_password = "useradmin@12345";
        private static string db_database = "appdb";


        private SqlConnection GetConnection(string connectionString)
        {
            //var _builder = new SqlConnectionStringBuilder();
            //_builder.DataSource = db_source;
            //_builder.UserID = db_user;
            //_builder.Password = db_password;
            //_builder.InitialCatalog = db_database;
            //return new SqlConnection(_builder.ConnectionString);
            return new SqlConnection(connectionString);
        }

        public IEnumerable<Course> GetCourses(string connectionString)
        {

            List<Course> _list = new List<Course>();
            Course _course = new Course
            {
                Id = 1,
                Name = "204",
                Rating = 4
            };
            Course _course1 = new Course
            {
                Id = 2,
                Name = "3.5",
                Rating = 3
            };
            _list.Add(_course);
            _list.Add(_course1);
            //string _statement = "select ID, [Name], Rating from Course";
            //SqlConnection connection = GetConnection(connectionString);

            //connection.Open();
            //SqlCommand sqlCommand = new SqlCommand(_statement, connection);
            //using(SqlDataReader dataReader = sqlCommand.ExecuteReader())
            //{
            //    while (dataReader.Read())
            //    {
            //        Course _course = new Course
            //        {
            //            Id = dataReader.GetInt32(0),
            //            Name = dataReader.GetString(1),
            //            Rating = dataReader.GetDecimal(2)
            //        };

            //        _list.Add(_course);
            //    }
            //}
            //connection.Close();

            return _list;
        }
    }
}
