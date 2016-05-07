using System.Text;

namespace TSIS
{
    public static class Report
    {
        private static StringBuilder _writer = new StringBuilder();

        public static string Writer
        {
            get { return _writer.ToString(); }
            set { _writer.AppendLine(value); }
        }
    }
}