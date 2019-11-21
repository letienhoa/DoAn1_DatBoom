using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDatBom_DA1
{
    public class DIEM
    {
        private int iD;
        private string name;
        private string diem;

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public string Diem { get => diem; set => diem = value; }

        public DIEM() { }

        public DIEM(DataRow row)
        {
            this.ID = (int)row["Id"];
            this.Name = row["TenNguoiChoi"].ToString();
            this.Diem = row["DiemSo"].ToString();
        }

      
    }
}
