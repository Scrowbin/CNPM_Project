// Xử l dữ liệu người thuê
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

public class ContractDAL
{
    private string connectionString;

    public ContractDAL(string connectionString)
    {
        this.connectionString = connectionString;
    }

    public List<Contract> GetAllContracts()
    {
        List<Contract> contracts = new List<Contract>();

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = "SELECT * FROM HOP_DONG";
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Contract contract = new Contract
                {
                    MaCanHo = reader["MA_CAN_HO"].ToString(),
                    MaKhachHang = reader["MA_KHACH_HANG"].ToString(),
                    MaHopDong = reader["MA_HOP_DONG"].ToString(),
                    NgayBatDau = reader["NGAY_BAT_DAU"] as DateTime?,
                    NgayKetThuc = reader["NGAY_KET_THUC"] as DateTime?,
                    NgayLamHopDong = reader["NGAY_LAM_HOP_DONG"] as DateTime?,
                    TienCoc = reader["TIEN_COC"] as int?
                };
                contracts.Add(contract);
            }
        }

        return contracts;
    }

    // Thêm hợp đồng
    public bool AddContract(Contract contract)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = @"INSERT INTO HOP_DONG (MA_CAN_HO, MA_KHACH_HANG, MA_HOP_DONG, NGAY_BAT_DAU, NGAY_KET_THUC, NGAY_LAM_HOP_DONG, TIEN_COC)
                             VALUES (@MaCanHo, @MaKhachHang, @MaHopDong, @NgayBatDau, @NgayKetThuc, @NgayLamHopDong, @TienCoc)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MaCanHo", contract.MaCanHo);
