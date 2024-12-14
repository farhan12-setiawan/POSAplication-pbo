using System;
using System.Collections.Generic;

namespace POSApplication.Models;

public partial class Barang
{
    public int Id { get; set; }

    public string Nama { get; set; } = null!;

    public decimal Hargajual { get; set; }

    public int Stok { get; set; }
}
