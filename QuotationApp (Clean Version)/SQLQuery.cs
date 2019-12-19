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

        //***************MATERIAL CALCULATOR FIELDS***************//
        private readonly Rod _blankRod = new Rod("New", 1, 1, 1, 1, 1);
        private readonly Flat _blankFlat = new Flat("New", 1, 1, 1, 1, 1, 1);
        private readonly HollowRod _blankHollowRod = new HollowRod("New", 1, 1, 1, 1, 1, 1);

        public List<Rod> RodList { get; set; }
        public List<Flat> FlatList { get; set; }
        public List <HollowRod> HollowRodList { get; set; }

        //***************QUOTATION FIELDS***************//
        public List<Material> ProductList { get; set; }
        public List<Material> MaterialList { get; set; }

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

            ProductList = new List<Material>();
            MaterialList = new List<Material>();
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
                                    Id = reader.IsDBNull(7) ? 0 : reader.GetInt32(7)
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

        public void GetHollowRods()
        {
            HollowRodList = new List<HollowRod> { _blankHollowRod };
            try
            {
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();
                    StringBuilder sb = new StringBuilder();

                    sb.Append("SELECT * FROM HollowRods;");
                    String sql = sb.ToString();

                    Console.WriteLine(sb.ToString());

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                HollowRod hollowRod = new HollowRod(
                                    reader.IsDBNull(0) ? "Blank" : reader.GetString(0),
                                    reader.IsDBNull(1) ? 0 : reader.GetDouble(1),
                                    reader.IsDBNull(2) ? 0 : reader.GetDouble(2),
                                    reader.IsDBNull(3) ? 0 : reader.GetDouble(3),
                                    reader.IsDBNull(4) ? 0 : reader.GetDouble(4),
                                    reader.IsDBNull(5) ? 0 : reader.GetDouble(5),
                                    reader.IsDBNull(6) ? 0 : reader.GetDouble(6))
                                {
                                    Id = reader.IsDBNull(7) ? 0 : reader.GetInt32(7)
                                };

                                hollowRod.CalculateCost();
                                HollowRodList.Add(hollowRod);
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

        public void AddHollowRod(HollowRod hollowRod)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();

                    StringBuilder sb = new StringBuilder();
                    sb.Append("INSERT INTO HollowRods VALUES ('");
                    sb.Append(hollowRod.Name + "', ");
                    sb.Append(hollowRod.Density + ", ");
                    sb.Append(hollowRod.CostPerKg + ", ");
                    sb.Append(hollowRod.Qty + ", ");
                    sb.Append(hollowRod.DiameterOut + ", ");
                    sb.Append(hollowRod.DiameterIn + ", ");
                    sb.Append(hollowRod.Length + ");");
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

        public void DeleteHollowRod(double id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();

                    StringBuilder sb = new StringBuilder();
                    sb.Append("DELETE FROM HollowRods WHERE ID=" + id.ToString());
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

        public void GetProducts()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    ProductList.Clear();

                    connection.Open();
                    StringBuilder sb = new StringBuilder();

                    sb.Append("SELECT * FROM Sheet1$ WHERE GRP_ID IS NULL;");
                    String sql = sb.ToString();

                    Console.WriteLine(sb.ToString());

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Material material = new Material
                                {
                                    Name = reader.GetString(0),
                                    Material_Cost = reader.IsDBNull(1) ? 0 : (float)reader.GetDouble(1),
                                    Setup_Hr = reader.IsDBNull(2) ? 0 : (float)reader.GetDouble(2),
                                    Setup_Cost = reader.IsDBNull(3) ? 0 : (UInt32)reader.GetDouble(3),
                                    Operation_Hr = reader.IsDBNull(4) ? 0 : (float)reader.GetDouble(4),
                                    Operation_Cost = reader.IsDBNull(5) ? 0 : (UInt32)reader.GetDouble(5),
                                    Markup = reader.IsDBNull(6) ? 0 : (float)reader.GetDouble(6),
                                    Qty = 1,
                                    Id = (float)reader.GetInt32(7),
                                    Grp_Id = reader.IsDBNull(8) ? 0 : (float)reader.GetInt32(8)
                                };

                                material.SetSubTotal();
                                material.SetPricePerPiece();

                                ProductList.Add(material);
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

        public void AddProduct(Material material)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();

                    StringBuilder sb = new StringBuilder();
                    sb.Append("INSERT INTO Sheet1$ VALUES ('");
                    sb.Append(material.Name + "', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL);");
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

        public void DeleteProduct(float id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();

                    StringBuilder sb = new StringBuilder();
                    sb.Append("DELETE FROM Sheet1$ WHERE ID=" + id.ToString());
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

        public void GetMaterials(float id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    MaterialList.Clear();

                    connection.Open();
                    StringBuilder sb = new StringBuilder();

                    //sb.Append("SELECT * FROM JoelProducts");
                    sb.Append("SELECT * FROM Sheet1$ WHERE GRP_ID = " + id.ToString() + ";");
                    String sql = sb.ToString();

                    Console.WriteLine(sb.ToString());

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Material material = new Material
                                {
                                    Name = reader.GetString(0),
                                    //Material_Cost = (float)reader.GetDouble(1),
                                    Material_Cost = reader.IsDBNull(1) ? 0 : (float)reader.GetDouble(1),
                                    //Setup_Hr = (float)reader.GetDouble(2),
                                    //Setup_Cost = (UInt32)reader.GetDouble(3),
                                    //Operation_Hr = (float)reader.GetDouble(4),
                                    //Operation_Cost = (UInt32)reader.GetDouble(5),
                                    //Markup = (float)reader.GetDouble(6),
                                    Setup_Hr = reader.IsDBNull(2) ? 0 : (float)reader.GetDouble(2),
                                    Setup_Cost = reader.IsDBNull(3) ? 0 : (UInt32)reader.GetDouble(3),
                                    Operation_Hr = reader.IsDBNull(4) ? 0 : (float)reader.GetDouble(4),
                                    Operation_Cost = reader.IsDBNull(5) ? 0 : (UInt32)reader.GetDouble(5),
                                    Markup = reader.IsDBNull(6) ? 0 : (float)reader.GetDouble(6),
                                    Qty = reader.IsDBNull(9) ? 0 : (UInt32)reader.GetDouble(9),
                                    Id = (float)reader.GetInt32(7),
                                    Grp_Id = reader.IsDBNull(8) ? 0 : (float)reader.GetInt32(8)
                                };

                                material.SetSubTotal();
                                material.SetPricePerPiece();

                                MaterialList.Add(material);
                                Console.WriteLine("hey");
                            }
                            Console.WriteLine("heywala");
                        }
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
