using System.Text;

StringBuilder sb = new StringBuilder();
sb.Append("Book List");
sb.Append(" - Updated");

sb.Replace("Book List", "Library");

Console.WriteLine(sb);
