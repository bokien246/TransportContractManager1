namespace TransportContractManager.Models
{
    public class Contract
    {
        public string MaHD { get; set; }
        public string MaKH { get; set; }
        public DateTime NgayUpload { get; set; }
        public DateTime NgayHieuLuc { get; set; }
        public DateTime NgayHetHieuLuc { get; set; }
        public string MaPTTT { get; set; }
        public string LinkTaiLieu { get; set; }

        // Optional: Hiển thị tên khách hàng trong Grid
        public string TenKhachHang { get; set; }
    }
}
