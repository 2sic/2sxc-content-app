namespace AppCode
{
  public static class Styling
  {
    /// <summary>
    /// Bootstrap uses 12 Columns.
    /// This number helps calculate the width of remaining columns.
    /// </summary>
    public const int TotalColumns = 12;

    public const string DefaultRowClass = "mb-4 mb-lg-5";
    public const string LastRowClass = "";

    public static string RowClass(bool isLast) => isLast ? LastRowClass : DefaultRowClass;
  }
}