// Xử lý dữ liệu nhà
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

public class HouseDAL
{
    private string connectionString;

    public HouseDAL(string connectionString)
    {
        this.connectionString = connectionString;
    }

    public List<House> GetAllHouses()
    {
        List<House> houses = new List<House>();

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = "SELECT * FROM CAN_HO";
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                House house = new House
                {
                    MaCanHo = reader["MA_CAN_HO"].ToString(),
                    MaChuNha = reader["MA_CHU_NHA"].ToString(),
                    TenCanHo = reader["TEN_CAN_HO"].ToString(),
                    DiaChi = reader["DIA_CHI"].ToString(),
                    LoaiCanHo = reader["LOAI_CAN_HO"] as string,
                    DienTich = reader["DIEN_TICH"] as double?,
                    GiaThueDaiHan = (int)reader["GIA_THUE_DAI_HAN"],
                    GiaThueNganHan = (int)reader["GIA_THUE_NGAN_HAN"]
                };
                houses.Add(house);
            }
        }

        return houses;
    }

    // Thêm căn
