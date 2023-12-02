using System;
using System.Collections.Generic;

namespace ECommerceMVC.Data;

public partial class YeuThich
{
    public int MaYt { get; set; }

    public int? MaHh { get; set; }

    public string? MaKh { get; set; }

    public DateTime? NgayChon { get; set; }

    public string? MoTa { get; set; }

    public virtual HangHoa? MaHhNavigation { get; set; }

    public virtual KhachHang? MaKhNavigation { get; set; }
}
