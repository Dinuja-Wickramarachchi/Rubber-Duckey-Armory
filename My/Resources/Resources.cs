

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace rubberDuckyToolKit.My.Resources
{
  [StandardModule]
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
  [DebuggerNonUserCode]
  [CompilerGenerated]
  [HideModuleName]
  internal sealed class Resources
  {
    private static ResourceManager resourceMan;
    private static CultureInfo resourceCulture;

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static ResourceManager ResourceManager
    {
      get
      {
        if (object.ReferenceEquals((object) rubberDuckyToolKit.My.Resources.Resources.resourceMan, (object) null))
          rubberDuckyToolKit.My.Resources.Resources.resourceMan = new ResourceManager("rubberDuckyToolKit.Resources", typeof (rubberDuckyToolKit.My.Resources.Resources).Assembly);
        return rubberDuckyToolKit.My.Resources.Resources.resourceMan;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
      get
      {
        return rubberDuckyToolKit.My.Resources.Resources.resourceCulture;
      }
      set
      {
        rubberDuckyToolKit.My.Resources.Resources.resourceCulture = value;
      }
    }
  }
}
