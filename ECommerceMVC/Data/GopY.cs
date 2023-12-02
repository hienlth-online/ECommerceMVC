using System;
using System.Collections.Generic;

namespace ECommerceMVC.Data;

public partial class GopY
{
    public string MaGy { get; set; } = null!;

    public int MaCd { get; set; }

    public string NoiDung { get; set; } = null!;

    public DateOnly NgayGy { get; set; }

    public string? HoTen { get; set; }

    public string? Email { get; set; }

    public string? DienThoai { get; set; }

    public bool CanTraLoi { get; set; }

    public string? TraLoi { get; set; }

    public DateOnly? NgayTl { get; set; }

    public virtual ChuDe MaCdNavigation { get; set; } = null!;
}
