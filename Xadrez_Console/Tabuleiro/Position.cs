using System;

namespace Tabuleiro
{
    class Position
    {
        public int Line { get; set; } //Get e set public significa que estes atributos podem ser acessados e alterados por outras classes
        public int Column { get; set; }

        public Position(int lineValue, int columnValue)
        {
            Line = lineValue;
            Column = columnValue;
        }

        public override string ToString()
        {
            return Line + ", " + Column;
        }
    }
}
