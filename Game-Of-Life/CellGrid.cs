using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.

namespace Game_Of_Life
{
    public interface CellGrid : IEnumerator<Type T>
    {
        bool getCell(int col, int row);
        void setCell(int col, int row, boolean cell);
        Dimension  getDimension();
        void resize(int col, int row);
        //IEnumeration getEnum();
        void clear();
    }
}
