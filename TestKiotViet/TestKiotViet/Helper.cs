using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestKiotViet
{
    public class Helper
    {
        public int CheckCocaCola(int n)
        {
            try
            {
                var total = n;
                var soDu = 0;
                if (n % 3 == 0)
                {
                    soDu = 1;
                }
                else
                {
                    soDu = n % 3;
                }
                int thamSo = (int)Math.Floor((decimal)n / 3);
                if (thamSo == 1)
                {
                    total += 2;
                }
                else
                {
                    while (thamSo > 1)
                    {

                        total += thamSo;
                        soDu += thamSo % 3;
                        thamSo = (int)Math.Floor((decimal)thamSo / 3);

                        if (thamSo == 1)
                        {
                            total += 1;
                        }
                        if (soDu % 3 == 0)
                        {
                            total += 1;
                            soDu = 1;
                        }
                    }
                }
                return total;
            }
            catch (Exception ex)
            {

                return default(int) ;
            }
        }
    }
}
