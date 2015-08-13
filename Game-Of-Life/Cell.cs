using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Of_Life
{
    /**
 * Every cell in the grid is a Cell-object.
 * So it must be as small as possible.
 * Because every cell is pre-generated, no cells have to be generated when the Game Of Life is played.
 * Whether a cell is alive or not, is not part of the Cell-object.  
 */
    public class Cell
    {
        public short col;
        public short row;
        /**
         * Number of neighbours of this cell.
         * 
         * Determines the next state.
         */
        public byte neighbour;

        /**
         * HASHFACTOR must be larger than the maximum number of columns (that is: the max width of a monitor in pixels).
         * It should also be smaller than 65536. (sqrt(MAXINT)).
         */
        private int HASHFACTOR = 5000;

        /**
         * Constructor
         * @param col column of cell
         * @param row row or cell
         */
        public Cell(int col, int row)
        {
            this.col = (short)col;
            this.row = (short)row;
            neighbour = 0;
        }

        public boolean equals(Object o)
        {
            if (!(o is Cell))
                return false;
            return col == ((Cell)o).col && row == ((Cell)o).row;
        }

        public int hashCode()
        {
            return HASHFACTOR * row + col;
        }

        public String toString()
        {
            return "Cell at (" + col + ", " + row + ") with " + neighbour + " neighbour" + (neighbour == 1 ? "" : "s");
        }
    }
}
