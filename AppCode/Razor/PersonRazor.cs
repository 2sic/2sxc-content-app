using System.Collections.Generic;
using System.Linq;
using AppCode.Data;
using Custom.Data;
using ToSic.Sxc.Context;

namespace AppCode.Razor
{
  /// <summary>
  /// todo
  /// </summary>
  public abstract class PersonRazor: AppRazor
  {
    protected List<Person> MyPersons => _myPersons ??= AsList<Person>(MyItems).ToList();
    private List<Person> _myPersons;
  }
}