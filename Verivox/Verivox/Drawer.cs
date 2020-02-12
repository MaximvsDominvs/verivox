namespace Verivox
{
    /// <summary>
    /// Class to format strings as a table
    /// </summary>
    public class Drawer
    {
        /// <summary>
        /// Amount of characters in a single cell
        /// </summary>
        private readonly int _cellWidth;
        /// <summary>
        /// Amount of columns in a row
        /// </summary>
        private readonly int _columnsAmount;
        /// <summary>
        /// Instantiate Drawer
        /// </summary>
        /// <param name="cellWidth">amount of characters in a cell (extra string length going to be filled with ' '-char</param>
        /// <param name="columns">amount of columns in a row</param>
        public Drawer(int cellWidth, int columns)
        {
            _cellWidth = cellWidth;
            _columnsAmount = columns;
        }
        /// <summary>
        /// Draw a cell with a string provided alligned in center
        /// </summary>
        /// <param name="str">string to put in a cell (default value - "")</param>
        /// <returns></returns>
        private string DrawCell(string str = "")
        {
            return str.PadRight(_cellWidth - (_cellWidth - str.Length) / 2).PadLeft(_cellWidth);
        }
        /// <summary>
        /// Draw a row of centrally aligned cells surrounded by and separated by symbol '|'
        /// </summary>
        /// <param name="cells">array of cells to render in a row</param>
        /// <returns></returns>
        public string DrawRow(string[] cells)
        {
            string row = "|";
            foreach (var cell in cells)
            {
                row += $"{DrawCell(cell)}|";
            }
            return row;
        }
        /// <summary>
        /// Draw a line of '-' characters
        /// </summary>
        /// <returns></returns>
        public string DrawLine()
        {
            return new string('-', _cellWidth*_columnsAmount + _columnsAmount + 1);
        }
        /// <summary>
        /// Draw a table header
        /// </summary>
        /// <param name="cells">titles for header cells</param>
        /// <returns></returns>
        public string DrawHeader(string[] cells)
        {
            var header = DrawLine() + "\n";
            header += DrawRow(cells) + "\n";
            header += DrawLine() + "\n";
            return header + DrawLine() + "\n";
        }
    }
}
