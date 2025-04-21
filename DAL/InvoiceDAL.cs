// Xử lý dữ liệu thanh toán
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

public class InvoiceDAL
{
    private string connectionString;

    public InvoiceDAL(string connectionString)
    {
        this.connectionString = connectionString;
    }

    public List<Invoice> GetAllInvoices()
    {
        List<Invoice> invoices = new List<Invoice>();

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = "SELECT * FROM HOA_DON";
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Invoice invoice = new Invoice
                {
                    MaCanHo = reader["MA_CAN_HO"].ToString(),
                    MaKhachHang = reader["MA_KHACH_HANG"].ToString(),
                    MaHopDong = reader["MA_HOP_DONG"].ToString(),
                    MaHoaDon = reader["MA_HOA_DON"].ToString(),
                    NgayThanhToan = reader["NGAY_THANH_TOAN"] as DateTime?,
                    TienNha = (int)reader["TIEN_NHA"],
                    TienDien = reader["TIEN_DIEN"] as int?,
                    TienNuoc = reader["TIEN_NUOC"] as int?,
                    PhiDichVu = reader["PHI_DICH_VU"] as int?,
                    TongTien = reader["TONG_TIEN"] as int?
                };
                invoices.Add(invoice);
            }
        }

        return invoices;
    }

    // Thêm hóa đơn
    public bool AddInvoice(Invoice invoice)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = @"INSERT INTO HOA_DON (MA_CAN_HO, MA_KHACH_HANG, MA_HOP_DONG, MA_HOA_DON, NGAY_THANH_TOAN, TIEN_NHA, TIEN_DIEN, TIEN_NUOC, PHI_DICH_VU, TONG_TIEN)
                             VALUES (@MaCanHo, @MaKhachHang, @MaHopDong, @MaHoaDon, @NgayThanhToan, @TienNha, @TienDien, @TienNuoc, @PhiDichVu, @TongTien)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MaCanHo", invoice.MaCanHo);
            command.Parameters.AddWithValue("@MaKhachHang", invoice.MaKhachHang);
            command.Parameters.AddWithValue("@MaHopDong", invoice.MaHopDong);
            command.Parameters.AddWithValue("@MaHoaDon", invoice.MaHoaDon);
            command.Parameters.AddWithValue("@NgayThanhToan", invoice.NgayThanhToan ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@TienNha", invoice.TienNha);
            command.Parameters.AddWithValue("@TienDien", invoice.TienDien ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@TienNuoc", invoice.TienNuoc ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@PhiDichVu", invoice.PhiDichVu ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@TongTien", invoice.TongTien ?? (object)DBNull.Value);

            connection.Open();
            int result = command.ExecuteNonQuery();
            return result > 0;
        }
    }
}
