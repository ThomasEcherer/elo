using System;
using System.Collections.Generic;
using System.Text;

namespace EloixClient.IndexServer
{
    public class AnyToObject
    {
        public static Object ToObject(Any any)
        {
            Object ret = null;
            switch (any.type)
            {
                case AnyC.TYPE_BOOLEAN:
                    ret = any.booleanValue;
                    break;
                //      case AnyC.TYPE_BYTE:
                //        ret = new Byte( byteValue );
                //        break;
                //      case AnyC.TYPE_SHORT:
                //        ret = new Short( shortValue );
                //        break;
                case AnyC.TYPE_INT:
                    ret = any.intValue;
                    break;
                case AnyC.TYPE_LONG:
                    ret = any.longValue;
                    break;
                case AnyC.TYPE_DOUBLE:
                    ret = any.doubleValue;
                    break;
                case AnyC.TYPE_STRING:
                    ret = (any.stringValue);
                    break;
                case AnyC.TYPE_ARRAY_BYTE:
                    ret = (any.byteArray);
                    break;
                case AnyC.TYPE_ARRAY_ANY:
                    if (any.anyArray != null)
                    {
                        if (any.anyArray.Length != 0)
                        {
                            //            // Object[][] ? ---> byte[] -> JavaNativeArray
                            //            if (anyArray[0].getType() == AnyC.TYPE_ARRAY_ANY) {
                            //              Object[][] arr = new Object[anyArray.length][];
                            //              for (int i = 0; i < arr.length; i++) {
                            //                arr[i] = ( Object[] )anyArray[i].toObject();
                            //              }
                            //              ret = arr;
                            //            }
                            //            else {

                            Object[] arr = new Object[any.anyArray.Length];
                            for (int i = 0; i < arr.Length; i++)
                            {
                                arr[i] = ToObject(any.anyArray[i]);
                            }
                            ret = arr;
                        }
                        else
                        {
                            ret = new Object[0];
                        }
                    }
                    break;
                default: // case AnyC.TYPE_OBJECT:
                    ret = (any.objectValue);
                    break;
            }
            return ret;
        }

        public static Object[][] ToObjectTable(Any any)  {
            Object[][] ret = null;
            switch (any.type) 
            {
                case AnyC.TYPE_BOOLEAN:
                    ret = new Object[][] { new Object[] { any.booleanValue } };
                    break;
        //      case AnyC.TYPE_BYTE:
        //        ret = new Object[][] { new Object[] { new Byte( byteValue ) } };
        //        break;
        //      case AnyC.TYPE_SHORT:
        //        ret = new Object[][] { new Object[] { new Short( shortValue ) } };
        //        break;
                case AnyC.TYPE_INT:
                    ret = new Object[][] { new Object[] { any.intValue } };
                    break;
                case AnyC.TYPE_LONG:
                    ret = new Object[][] { new Object[] { any.longValue } };
                    break;
                case AnyC.TYPE_DOUBLE:
                    ret = new Object[][] { new Object[] { any.doubleValue } };
                    break;
                case AnyC.TYPE_STRING:
                    ret = new Object[][] { new Object[] { any.stringValue } };
                    break;
                case AnyC.TYPE_ARRAY_BYTE:
                    ret = new Object[][] { new Object[] { any.byteArray } };
                    break;
                case AnyC.TYPE_ARRAY_ANY:
                    if (any.anyArray != null) 
                    {
                        if (any.anyArray.Length != 0) 
                        {
                            // Object[][] ?
                            if (any.anyArray[0].type == AnyC.TYPE_ARRAY_ANY) 
                            {
                              Object[][] arr = new Object[any.anyArray.Length][];
                              for (int i = 0; i < arr.Length; i++) 
                              {
                                arr[i] = ( Object[] )ToObject(any.anyArray[i]);
                              }
                              ret = arr;
                            }
                            else 
                            {
                              Object[] arr = new Object[any.anyArray.Length];
                              for (int i = 0; i < arr.Length; i++) 
                              {
                                arr[i] = ToObject(any.anyArray[i]);
                              }
                              ret = new Object[][] { arr };
                            }
                        }
                        else 
                        {
                            ret = new Object[0][];
                        }
                    }
                    break;
                default: // case AnyC.TYPE_OBJECT:
                    ret = new Object[][] { new Object[] { any.objectValue } };
                    break;
            }

            return ret;
        }

        public static Any fromObject(Object obj)
        {
            Any any = new Any();
            if (obj == null)
            {
                any.objectValue = null;
                any.type = AnyC.TYPE_OBJECT;
            }
            else if (obj is bool)
            {
                any.booleanValue = ((bool)obj);
                any.type = AnyC.TYPE_BOOLEAN;
            }
            //    else if (obj is Byte) {
            //      byteValue = (( Byte )obj).byteValue();
            //      type = AnyC.TYPE_BYTE;
            //    }
            //    else if (obj is Short) {
            //      shortValue = (( Short )obj).shortValue();
            //      type = AnyC.TYPE_SHORT;
            //    }
            else if (obj is int)
            {
                any.intValue = ((int)obj);
                any.type = AnyC.TYPE_INT;
            }
            else if (obj is long)
            {
                any.longValue = ((long)obj);
                any.type = AnyC.TYPE_LONG;
            }
            else if (obj is double)
            {
                any.doubleValue = ((double)obj);
                any.type = AnyC.TYPE_DOUBLE;
            }
            else if (obj is String)
            {
                any.stringValue = (String)obj;
                any.type = AnyC.TYPE_STRING;
            }
            else if (obj is byte[])
            {
                any.byteArray = (byte[])obj;
                any.type = AnyC.TYPE_ARRAY_BYTE;
            }
            else if (obj is ValueClass)
            {
                any.objectValue = (ValueClass)obj;
                any.type = AnyC.TYPE_OBJECT;
            }
            else if (obj is Any[])
            {
                any.anyArray = (Any[])obj;
                any.type = AnyC.TYPE_ARRAY_ANY;
            }
            else if (obj is Object[])
            {
                Object[] arr = (Object[])obj;
                any.anyArray = new Any[arr.Length];
                for (int i = 0; i < arr.Length; i++)
                {
                    any.anyArray[i] = fromObject(arr[i]);
                }
                any.type = AnyC.TYPE_ARRAY_ANY;
            }
            else
            {
                throw new ArgumentException("Unsupported type for Any class: " + obj.GetType());
            }

            return any;
        }

        public static String ToString(Any any)
        {
            StringBuilder sbuf = new StringBuilder();
            switch (any.type)
            {
                case AnyC.TYPE_BOOLEAN:
                    sbuf.Append(any.booleanValue);
                    break;
                //      case AnyC.TYPE_BYTE:
                //        sbuf.append( byteValue );
                //        break;
                //      case AnyC.TYPE_SHORT:
                //        sbuf.append( shortValue );
                //        break;
                case AnyC.TYPE_INT:
                    sbuf.Append(any.intValue);
                    break;
                case AnyC.TYPE_LONG:
                    sbuf.Append(any.longValue);
                    break;
                case AnyC.TYPE_DOUBLE:
                    sbuf.Append(any.doubleValue);
                    break;
                case AnyC.TYPE_STRING:
                    sbuf.Append(any.stringValue);
                    break;
                case AnyC.TYPE_ARRAY_BYTE:
                    sbuf.Append(any.byteArray);
                    break;
                case AnyC.TYPE_ARRAY_ANY:
                    if (any.anyArray != null)
                    {
                        sbuf.Append("[");
                        for (int i = 0; i < any.anyArray.Length; i++)
                        {
                            if (i != 0) sbuf.Append(",");
                            sbuf.Append(any.anyArray[i].ToString());
                        }
                        sbuf.Append("]");
                    }
                    else
                    {
                        sbuf.Append("null");
                    }
                    break;
                default: // case AnyC.TYPE_OBJECT:
                    sbuf.Append(any.objectValue);
                    break;
            }
            return sbuf.ToString();
        }

    }
}
