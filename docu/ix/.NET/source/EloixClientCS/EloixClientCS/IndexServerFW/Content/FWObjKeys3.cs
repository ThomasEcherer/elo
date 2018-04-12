using System;
using System.Collections.Generic;
using System.Text;
using EloixClient.IndexServer;

namespace EloixClient.IndexServerFW.Content
{
  public class FWObjKeyValues3
  {
    protected FWObjKeys3 xokey;
    public FWObjKeyValues3(FWObjKeys3 xokey)
    {
      this.xokey = xokey;
    }
    public String this[int id]
    {
      get 
      {
        return xokey.FindValue(id, null);
      }
      set
      {
        List<String> v = new List<String>(1);
        v.Add(value);
        xokey.mapValues[id] = v;
      }
    }
    public String this[String name]
    {
      get
      {
        return xokey.FindValue(-1, name);
      }
      set
      {
        String nameL = name.ToLower();
        foreach (ObjKey o in xokey.mapObjKeys.Values)
        {
          if (o.name.ToLower().Equals(nameL))
          {
            this[o.id] = value;
          }
        }
      }
    }

  }

  public class FWObjKeyDatas3
  {
    protected FWObjKeys3 xokey;
    public FWObjKeyDatas3(FWObjKeys3 xokey)
    {
      this.xokey = xokey;
    }
    public List<String> this[int id]
    {
      get
      {
        List<String> v = null;
        xokey.mapValues.TryGetValue(id, out v);
        return v;
      }
      set
      {
        xokey.mapValues[id] = value;
      }
    }
  }

  public class FWObjKeys3
  {
    internal Dictionary<int, List<String>> mapValues;
    internal Dictionary<int, ObjKey> mapObjKeys;

    public FWObjKeys3(ObjKey[] okeys)
    {
      fromArray(okeys);
    }

    protected void fromArray(ObjKey[] okeys)
    {
      if (okeys != null)
      {
        mapValues = new Dictionary<int, List<String>>(okeys.Length);
        mapObjKeys = new Dictionary<int, ObjKey>(okeys.Length);

        foreach (ObjKey o in okeys)
        {
          mapObjKeys[o.id] = o;
          mapValues[o.id] = new List<String>(o.data);
        }
      }
      else
      {
        mapValues = new Dictionary<int, List<String>>();
        mapObjKeys = new Dictionary<int, ObjKey>();
      }
    }

    protected void updateInternalData(bool save)
    {
      if (save)
      {
        foreach (int k in mapValues.Keys)
        {
          ObjKey o = null;
          if (mapObjKeys.TryGetValue(k, out o))
          {
            o.data = mapValues[k].ToArray();
          }
        }
      }
      else
      {
      }
    }

    public ObjKey[] ToArray()
    {
      updateInternalData(true);

      ObjKey[] okeys = new ObjKey[mapObjKeys.Count];
      int i = 0;
      foreach (ObjKey o in mapObjKeys.Values)
      {
        okeys[i++] = o;
      }

      return okeys;
    }

    public ObjKey this[int id]
    {
      get 
      {
        ObjKey o = null;
        List<String> v = null;
        if (mapObjKeys.TryGetValue(id, out o))
        {
          if (mapValues.TryGetValue(id, out v))
          {
            o.data = v.ToArray();
          }
        }
        return o;
      }
      set
      {
        mapObjKeys[id] = value;
        mapValues[id] = value.data != null ? (new List<String>(value.data)) : (new List<String>());
        value.id = id;
      }
    }

    public int Count
    {
      get { return mapObjKeys.Count; }
    }

    public IEnumerator<ObjKey> GetEnumerator()
    {
      updateInternalData(true);
      return mapObjKeys.Values.GetEnumerator();
    }

    public FWObjKeyValues3 Values
    {
      get { return new FWObjKeyValues3(this); }
    }
    public FWObjKeyDatas3 Datas
    {
      get { return new FWObjKeyDatas3(this); }
    }

    public List<String> FindData(int id, String name)
    {
      List<String> v = null;

      if (id >= 0)
      {
        if (mapValues.TryGetValue(id, out v) && v != null)
        {
          return v;
        }
      }

      if (name != null && name.Length != 0)
      {
        String nameL = name.ToLower();
        foreach (ObjKey o in mapObjKeys.Values)
        {
          if (o.name.ToLower().Equals(nameL))
          {
            if (mapValues.TryGetValue(id, out v) && v != null)
            {
              return v;
            }
            break;
          }
        }
      }

      return null;
    }

    public String FindValue(int id, String name)
    {
      List<String> v = FindData(id, name);
      if (v != null && v.Count != 0)
      {
        return v[0];
      }
      else
      {
        return "";
      }
    }

    public void SetNameData(int id, String name, String[] data)
    {
      if (data == null || data.Length == 0) return;
      List<String> v = new List<String>(data.Length);
      foreach (String s in data) v.Add(s);
      SetNameData(id, name, v);
    }

    public void SetNameData(int id, String name, List<String> data)
    {
      List<String> v = FindData(id, name);
      if (v != null)
      {
        v.Clear();
        v.AddRange(data);
      }
      else
      {
        ObjKey okey = new ObjKey();
        okey.id = id;
        okey.name = name;
        this[id] = okey;
        mapValues[id] = data;
      }
    }

    public void SetNameValue(int id, String name, String value)
    {
      List<String> v = new List<String>(1);
      v.Add(value);
      SetNameData(id, name, v);
    }
    
  }
}
