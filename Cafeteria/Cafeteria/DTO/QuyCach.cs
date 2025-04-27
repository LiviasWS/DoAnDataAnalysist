using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria.DTO
{
    public class QuyCach
    {
        private int maQC;
        private string tenQC;

        public QuyCach()
        {
        }

        public QuyCach(int maQC, string tenQC)
        {
            this.maQC = maQC;
            this.tenQC = tenQC;
        }

        public int MaQC { get { return maQC; } set {  maQC = value; } }
        public string TenQC { get {  return tenQC; } set {  tenQC = value; } }
        public override string ToString()
        {
            return maQC + " - " + tenQC;
        }
    }
}
