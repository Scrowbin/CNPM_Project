// Xử lý dữ liệu người thuê
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

public class TenantDAL
{
    private string connectionString;

    public TenantDAL(string connectionString)
    {
        this.connectionString = connectionString;
    }

    // Lấy tất cả người thuê
    public List<Tenant> GetAllTenants()
    {
        List<Tenant> tenants = new List<Tenant>();

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = "SELECT * FROM NGUOI_THUE_NHA";
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Tenant tenant = new Tenant
                {
                    MaKhachHang = reader["MA_KHACH_HANG"].ToString(),
                    HoTen = reader["HO_TEN"].ToString(),
                    SDT = reader["SDT"] as long?,
                    CccdPassport = reader["CCCD_PASSPORT"].ToString(),
                    Email = reader["EMAIL"] as string,
                    QuocTich = reader["QUOC_TICH"] as string,
                    DiaChi = reader["DIA_CHI"] as string
                };
                tenants.Add(tenant);
            }
        }

        return tenants;
    }

    // Lấy thông tin người thuê theo mã khách hàng
    public Tenant GetTenantById(string maKhachHang)
    {
        Tenant tenant = null;

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = "SELECT * FROM NGUOI_THUE_NHA WHERE MA_KHACH_HANG = @MaKhachHang";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MaKhachHang", maKhachHang);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                tenant = new Tenant
                {
                    MaKhachHang = reader["MA_KHACH_HANG"].ToString(),
                    HoTen = reader["HO_TEN"].ToString(),
                    SDT = reader["SDT"] as long?,
                    CccdPassport = reader["CCCD_PASSPORT"].ToString(),
                    Email = reader["EMAIL"] as string,
                    QuocTich = reader["QUOC_TICH"] as string,
                    DiaChi = reader["DIA_CHI"] as string
                };
            }
        }

        return tenant;
    }

    // Thêm người thuê mới
    public bool AddTenant(Tenant tenant)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = @"INSERT INTO NGUOI_THUE_NHA (MA_KHACH_HANG, HO_TEN, SDT, CCCD_PASSPORT, EMAIL, QUOC_TICH, DIA_CHI)
                             VALUES (@MaKhachHang, @HoTen, @SDT, @CccdPassport, @Email, @QuocTich, @DiaChi)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MaKhachHang", tenant.MaKhachHang);
            command.Parameters.AddWithValue("@HoTen", tenant.HoTen);
            command.Parameters.AddWithValue("@SDT", tenant.SDT);
            command.Parameters.AddWithValue("@CccdPassport", tenant.CccdPassport);
            command.Parameters.AddWithValue("@Email", tenant.Email);
            command.Parameters.AddWithValue("@QuocTich", tenant.QuocTich);
            command.Parameters.AddWithValue("@DiaChi", tenant.DiaChi);

            connection.Open();
            int result = command.ExecuteNonQuery();
            return result > 0; // Trả về true nếu thêm thành công
        }
    }

    // Cập nhật thông tin người thuê
    public bool UpdateTenant(Tenant tenant)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = @"UPDATE NGUOI_THUE_NHA 
                             SET HO_TEN = @HoTen, SDT = @SDT, CCCD_PASSPORT = @CccdPassport, EMAIL = @Email, QUOC_TICH = @QuocTich, DIA_CHI = @DiaChi
                             WHERE MA_KHACH_HANG = @MaKhachHang";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MaKhachHang", tenant.MaKhachHang);
            command.Parameters.AddWithValue("@HoTen", tenant.HoTen);
            command.Parameters.AddWithValue("@SDT", tenant.SDT);
            command.Parameters.AddWithValue("@CccdPassport", tenant.CccdPassport);
            command.Parameters.AddWithValue("@Email", tenant.Email);
            command.Parameters.AddWithValue("@QuocTich", tenant.QuocTich);
            command.Parameters.AddWithValue("@DiaChi", tenant.DiaChi);

            connection.Open();
            int result = command.ExecuteNonQuery();
            return result > 0; // Trả về true nếu cập nhật thành công
        }
    }

    // Xóa người thuê theo mã khách hàng
    public bool DeleteTenant(string maKhachHang)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = "DELETE FROM NGUOI_THUE_NHA WHERE MA_KHACH_HANG = @MaKhachHang";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MaKhachHang", maKhachHang);

            connection.Open();
            int result = command.ExecuteNonQuery();
            return result > 0; // Trả về true nếu xóa thành công
        }
    }
}
