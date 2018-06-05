using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baseball
{
    public interface IBaseballBat
    {
        void Swing();

        int WeightInGrams { get; set; }
    }
}
