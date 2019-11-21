using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDatBom_DA1
{
    public class DiemDAO
    {
        private static DiemDAO instance;

        public static DiemDAO Instance 
        {
            get { if (instance == null) instance = new DiemDAO(); return instance; }
            private set { instance = value; }
        }

        private DiemDAO() { }

        public List<DIEM> LoadDiem()
        {
            List<DIEM> table = new List<DIEM>();
            DataTable data = DbContext.Instance.ExecuteQuery("Select * from DIEM");
            foreach(DataRow item in data.Rows)
            {
                DIEM diem = new DIEM(item);
                table.Add(diem);
            }

            return table;
        }
    }
}
