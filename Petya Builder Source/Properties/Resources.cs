

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Petya_and_GoldenEye_BUILDER.Properties
{
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
  [DebuggerNonUserCode]
  [CompilerGenerated]
  internal class Resources
  {
    private static ResourceManager resourceMan;
    private static CultureInfo resourceCulture;

    internal Resources()
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static ResourceManager ResourceManager
    {
      get
      {
        if (Petya_and_GoldenEye_BUILDER.Properties.Resources.resourceMan == null)
          Petya_and_GoldenEye_BUILDER.Properties.Resources.resourceMan = new ResourceManager("Petya_and_GoldenEye_BUILDER.Properties.Resources", typeof (Petya_and_GoldenEye_BUILDER.Properties.Resources).Assembly);
        return Petya_and_GoldenEye_BUILDER.Properties.Resources.resourceMan;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
      get
      {
        return Petya_and_GoldenEye_BUILDER.Properties.Resources.resourceCulture;
      }
      set
      {
        Petya_and_GoldenEye_BUILDER.Properties.Resources.resourceCulture = value;
      }
    }

    internal static byte[] miha
    {
      get
      {
        return (byte[]) Petya_and_GoldenEye_BUILDER.Properties.Resources.ResourceManager.GetObject(nameof (miha), Petya_and_GoldenEye_BUILDER.Properties.Resources.resourceCulture);
      }
    }
  }
}
