using System.Collections.Generic;
using System.Linq;
using AppCode.Data;

namespace AppCode.Razor
{
  /// <summary>
  /// Base class for Person Razor templates
  /// </summary>
  public abstract class PersonRazor: AppRazor
  {
    protected List<Person> MyPersons => _myPersons ??= AsList<Person>(MyItems).ToList();
    private List<Person> _myPersons;
  }
}