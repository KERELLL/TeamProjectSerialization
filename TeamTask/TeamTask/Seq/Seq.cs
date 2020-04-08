using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seq
{
    [Serializable]
    public class Seq1221
    {
        public double[] _seq1221;

        public Seq1221(int N)
        {
            if (N <= 0)
            {
                throw new SeqException("Количество элементов должно быть положительным числом");
            }

            _seq1221 = new double[N];

            for (int i = 0; i < N; i++)
            {
                _seq1221[i] = 1 / Math.Pow(2, i);
            }
        }
    }
}
