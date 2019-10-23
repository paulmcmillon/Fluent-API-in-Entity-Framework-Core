using System.Text;

namespace GroundzKeeper.Data
{
    public static class DataFormatFunctions
    {
        public static string FullName<T>(T firstName, T lastName)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(firstName);
            builder.Append(" ");
            builder.Append(lastName);
            return builder.ToString();
        }
    }
}
