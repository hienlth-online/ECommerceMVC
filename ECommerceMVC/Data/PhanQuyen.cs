using System;
using System.Collections.Generic;

namespace ECommerceMVC.Data;

public partial class PhanQuyen
{
    public int MaPq { get; set; }

    public string? MaPb { get; set; }

    public int? MaTrang { get; set; }

    public bool Them { get; set; }

    public bool Sua { get; set; }

    public bool Xoa { get; set; }

    public bool Xem { get; set; }

    public virtual PhongBan? MaPbNavigation { get; set; }

    public virtual TrangWeb? MaTrangNavigation { get; set; }
}
