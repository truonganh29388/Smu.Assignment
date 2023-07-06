using System.Text;

namespace Smu.Assignment.Manager
{
    public class ShapeDrawer : IShapeDrawer
    {
        public string Draw(string shape, int size, char c = '*')
        {
            switch (shape.ToLower())
            {
                case "square":
                    return DrawSquare(size, c);
                case "triangle":
                    return DrawTriangle(size, c);
                default:
                    return null;
            }
        }

        private string DrawSquare(int size, char c)
        {
            var sb = new StringBuilder();
            var str = new string(c, size);
            for (int i = 0; i < size; i++)
            {
                sb.AppendLine(str);
            }

            return sb.ToString();
        }

        private string DrawTriangle(int size, char c)
        {
            var sb = new StringBuilder();

            for (int i = 0; i < size; i++)
            {
                var str = new string(c, i + 1);
                sb.AppendLine(str);
            }

            return sb.ToString();
        }
    }
}
