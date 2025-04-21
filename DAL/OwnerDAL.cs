// Xử lý dữ liệu chủ nhà
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

public class OwnerDAL
{
    private string connectionString;

    public OwnerDAL(string connectionString)
    {
        this.connectionString = connectionString;
    }

    public List<Owner> GetAllOwners()
    {
        List<Owner> owners = new List<Owner>();

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = "SELECT * FROM CHU_NHA";
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Owner owner = new Owner
                {
                    MaChuNha = reader["MA_CHU_NHA"].ToString(),
                    HoTen = reader["HO_TEN"].ToString(),
                    SDT = reader["SDT"] as long?,
                    CCCD = reader["CCCD"].ToString(),
                    Email = reader["EMAIL"] as string
                };
                owners.Add(owner);
            }
        }

        return owners;
    }

    // Thêm chủ nhà
    public bool AddOwner(Owner owner)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = @"INSERT INTO CHU_NHA (MA_CHU_NHA, HO_TEN, SDT, CCCD, EMAIL)
                             VALUES (@MaChuNha, @HoTen, @SDT, @Cccd, @Email)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MaChuNha", owner.MaChuNha);
            command.Parameters.AddWithValue("@HoTen", owner.HoTen);
            command.Parameters.AddWithValue("@SDT", owner.SDT ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@Cccd", owner.CCCD);
            command.Parameters.AddWithValue("@Email", owner.Email ?? (object)DBNull.Value);

            connection.Open();
            int result = command.ExecuteNonQuery();
            return result > 0;
        }
    }
}
