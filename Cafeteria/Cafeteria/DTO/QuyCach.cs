using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria
{
    public class QuyCach
    {
        private int maQC;
        private string tenQC;
        public int MaQC { get => maQC; set => maQC = value; }
        public string TenQC { get => tenQC; set => tenQC = value; }
        public QuyCach() { }
        public QuyCach(int maQC, string tenQC)
        {
            this.maQC = maQC;
            this.tenQC = tenQC;
        }
        public override string ToString()
        {
            return maQC + " - " + tenQC;
        }
    }
}
