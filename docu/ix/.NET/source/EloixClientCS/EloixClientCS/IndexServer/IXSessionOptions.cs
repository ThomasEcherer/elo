using System;

namespace EloixClient.IndexServer
{
  /// <summary>
  /// Helper class to wrap class SessionOptions of the IndexServer interface.
  /// </summary>
  public class IXSessionOptions 
  {

    /// <summary>
    /// Converts the properties collections of session options into the 
    /// appropriate IndexServer interface object.
    /// </summary>
    /// <returns></returns>
    public static SessionOptions makeSessOptsObj(IXProperties props)
    {
      SessionOptions opts = new SessionOptions();
      KeyValue[] kvs = opts.options = new KeyValue[props.Count];
      int i = 0;
      foreach (String k in props.Keys)
      {
        KeyValue kv = kvs[i++] = new KeyValue();
        kv.key = k;
        kv.value = props[k];
      }
      return opts;
    }
  
  }
}
