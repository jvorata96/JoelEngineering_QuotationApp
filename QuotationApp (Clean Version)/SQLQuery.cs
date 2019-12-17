using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuotationApp__Clean_Version_
{
    public class SQLQuery
    {
        private readonly SqlConnectionStringBuilder builder;

        private readonly Rod _blankRod = new Rod("New", 1, 1, 1, 1, 1);
        private readonly Flat _blankFlat = new Flat("New", 1, 1, 1, 1, 1, 1);
        public List<Rod> RodList { get; set; }
        public List<Flat> FlatList { get; set; }


        public SQLQuery()
        {
            RodList = new List<Rod> { _blankRod };
            builder = new SqlConnectionStringBuilder
            {
                DataSource = "joelengineering.database.windows.net",
                UserID = "tony",
                Password = "Jadenonoy_12",
                InitialCatalog = "JoelEngineeringDB"
            };
        }


        public void GetRods()
        {
            RodList = new List<Rod> { _blankRod };
            try
            {
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();
                    StringBuilder sb = new StringBuilder();

                    sb.Append("SELECT * FROM Rods;");
                    String sql = sb.ToString();

                    Console.WriteLine(sb.ToString());

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Rod rod = new Rod(
                                    reader.IsDBNull(0) ? "Blank" : reader.GetString(0),
                                    reader.IsDBNull(1) ? 0 : reader.GetDouble(1),
                                    reader.IsDBNull(2) ? 0 : reader.GetDouble(2),
                                    reader.IsDBNull(3) ? 0 : reader.GetDouble(3),
                                    reader.IsDBNull(4) ? 0 : reader.GetDouble(4),
                                    reader.IsDBNull(5) ? 0 : reader.GetDouble(5))
                                {
                                    Id = reader.IsDBNull(6) ? 0 : reader.GetInt32(6)
                                };

                                rod.CalculateCost();
                                RodList.Add(rod);
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message + ex.Source);
            }
        }

        public void AddRod(Rod rod)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();

                    StringBuilder sb = new StringBuilder();
                    sb.Append("INSERT INTO Rods VALUES ('");
                    sb.Append(rod.Name + "', ");
                    sb.Append(rod.Density + ", ");
                    sb.Append(rod.CostPerKg + ", ");
                    sb.Append(rod.Qty + ", ");
                    sb.Append(rod.Diameter + ", ");
                    sb.Append(rod.Length + ");");
                    String sql = sb.ToString();

                    Console.WriteLine(sb.ToString());

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.ExecuteNonQuery();
                    }

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message + ex.Source);
            }
        }

        public void DeleteRod(double id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();

                    StringBuilder sb = new StringBuilder();
                    sb.Append("DELETE FROM Rods WHERE ID=" + id.ToString());
                    String sql = sb.ToString();

                    Console.WriteLine(sb.ToString());

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.ExecuteNonQuery();
                    }

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message + ex.Source);
            }
        }

        public void GetFlats()
        {
            FlatList = new List<Flat> { _blankFlat };
            try
            {
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();
                    StringBuilder sb = new StringBuilder();

                    sb.Append("SELECT * FROM Flats;");
                    String sql = sb.ToString();

                    Console.WriteLine(sb.ToString());

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Flat flat = new Flat(
                                    reader.IsDBNull(0) ? "Blank" : reader.GetString(0),
                                    reader.IsDBNull(1) ? 0 : reader.GetDouble(1),
                                    reader.IsDBNull(2) ? 0 : reader.GetDouble(2),
                                    reader.IsDBNull(3) ? 0 : reader.GetDouble(3),
                                    reader.IsDBNull(6) ? 0 : reader.GetDouble(6),
                                    reader.IsDBNull(5) ? 0 : reader.GetDouble(5),
                                    reader.IsDBNull(4) ? 0 : reader.GetDouble(4))
                                {
                                    Id = reader.IsDBNull(6) ? 0 : reader.GetInt32(6)
                                };

                                flat.CalculateCost();
                                FlatList.Add(flat);
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message + ex.Source);
            }
        }

        public void AddFlat(Flat flat)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();

                    StringBuilder sb = new StringBuilder();
                    sb.Append("INSERT INTO Flats VALUES ('");
                    sb.Append(flat.Name + "', ");
                    sb.Append(flat.Density + ", ");
                    sb.Append(flat.CostPerKg + ", ");
                    sb.Append(flat.Qty + ", ");
                    sb.Append(flat.Length + ", ");
                    sb.Append(flat.Thickness + ", ");
                    sb.Append(flat.Width + ");");
                    String sql = sb.ToString();

                    Console.WriteLine(sb.ToString());

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.ExecuteNonQuery();
                    }

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message + ex.Source);
            }
        }

        public void DeleteFlat(double id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();

                    StringBuilder sb = new StringBuilder();
                    sb.Append("DELETE FROM Flats WHERE ID=" + id.ToString());
                    String sql = sb.ToString();

                    Console.WriteLine(sb.ToString());

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.ExecuteNonQuery();
                    }

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message + ex.Source);
            }
        }
    }
}
