using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace EloixClient.IndexServer
{
  /// <summary>
  /// Image lists for the icons of folders and documents.
  /// </summary>
  public class SordTypeImageList
  {
    /// <summary>
    /// ImageList with normal, workflow and reference Icons
    /// </summary>
    protected ImageList imageList;

#if NET40
    /// <summary>
    /// List of images of documents and folders specially created for use in wpf applications.
    /// </summary>
    protected System.Collections.ObjectModel.ObservableCollection<System.Windows.Media.Imaging.BitmapImage> wpfImageList;

    /// <summary>
    /// The DeleteObject function deletes a logical pen, brush, font, bitmap, region, or palette, freeing all system resources associated 
    /// with the object. After the object is deleted, the specified handle is no longer valid.
    /// </summary>
    /// <param name="hObject">A handle to a logical pen, brush, font, bitmap, region, or palette.</param>
    /// <returns>
    /// If the function succeeds, the return value is nonzero.
    /// If the specified handle is not valid or is currently selected into a DC, the return value is zero.
    /// </returns>
    [System.Runtime.InteropServices.DllImport("gdi32.dll")]
    [return: System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.Bool)]
    internal static extern bool DeleteObject(IntPtr hObject);

#endif

    /// <summary>
    /// Offset of reference icons in the image list.
    /// </summary>
    protected int referenceIconsOffset;
    
    /// <summary>
    /// Offset of workflow icons int the image list.
    /// </summary>
    protected int workflowIconsOffset;
    
    /// <summary>
    /// Dictionary maps sord.type to image index
    /// </summary>
    protected Dictionary<int, int> mapTypeToImageIdx = new Dictionary<int, int>();
    
    
      
      
      
      
      
      
      
    /// <summary>
    /// Constructor 
    /// </summary>
    /// <param name="sordTypes">Array of SordType objects (documents + folders)</param>
    public SordTypeImageList(SordType[] sordTypes) 
    {
      imageList           = new ImageList();
      imageList.ImageSize = new System.Drawing.Size(16, 16);

#if NET40
      wpfImageList = new System.Collections.ObjectModel.ObservableCollection<System.Windows.Media.Imaging.BitmapImage>();
#endif

      if (sordTypes != null)
      {
        mapTypeToImageIdx = new Dictionary<int, int>();
        makeIcons(sordTypes, 0);
        referenceIconsOffset = imageList.Images.Count;
        makeIcons(sordTypes, 1);
        workflowIconsOffset = imageList.Images.Count;
        makeIcons(sordTypes, 2);

        int upperIndex = imageList.Images.Count;

          // Icons für den Status ausgecheckt erstellen und der Imagelist hinzufügen.
          // Für die Icons werden die Standardicons genommen und ein Overlayicon für
          // den Status hinzugefügt.
        for (int i = 0; i < upperIndex; i++)
        {
            System.Drawing.Image img             = imageList.Images[i];
            System.Drawing.Image overlayImage    = Properties.Icons.Overlay_Checkout.ToBitmap();
            System.Drawing.Bitmap overlayedImage = new System.Drawing.Bitmap(img.Width, img.Height);

            System.Drawing.Graphics graphics = System.Drawing.Graphics.FromImage(overlayedImage);
            graphics.DrawImage(img, 0, 0);
            graphics.DrawImage(overlayImage, 0, 0);
            
            imageList.Images.Add(overlayedImage);

#if NET40
            System.Windows.Media.Imaging.BitmapImage bitmapImage = ToWpfBitmap(overlayedImage);
            wpfImageList.Add(bitmapImage);
#endif
        }

        // Icons für den Status verschlüsselt erstellen und der Imagelist hinzufügen.
        // Für die Icons werden die Standardicons genommen und ein Overlayicon für
        // den Status hinzugefügt.
        for (int i = 0; i < upperIndex; i++)
        {
            System.Drawing.Image img = imageList.Images[i];
            System.Drawing.Image overlayImage = Properties.Icons.Overlay_Verschluesselt.ToBitmap();
            System.Drawing.Bitmap overlayedImage = new System.Drawing.Bitmap(img.Width, img.Height);

            System.Drawing.Graphics graphics = System.Drawing.Graphics.FromImage(overlayedImage);
            graphics.DrawImage(img, 0, 0);
            graphics.DrawImage(overlayImage, 0, 0);

            imageList.Images.Add(overlayedImage);

#if NET40
            System.Windows.Media.Imaging.BitmapImage bitmapImage = ToWpfBitmap(overlayedImage);
            wpfImageList.Add(bitmapImage);
#endif
        }

        // Icons für den Status ausgecheckt und verschlüsselt erstellen und der Imagelist hinzufügen.
        // Für die Icons werden die Standardicons genommen und Overlayicons für
        // den Status hinzugefügt.
        for (int i = 0; i < upperIndex; i++)
        {
            System.Drawing.Image img = imageList.Images[i];
            System.Drawing.Image overlayImage1 = Properties.Icons.Overlay_Checkout.ToBitmap();
            System.Drawing.Image overlayImage2 = Properties.Icons.Overlay_Verschluesselt.ToBitmap();
            System.Drawing.Bitmap overlayedImage = new System.Drawing.Bitmap(img.Width, img.Height);

            System.Drawing.Graphics graphics = System.Drawing.Graphics.FromImage(overlayedImage);
            graphics.DrawImage(img, 0, 0);
            graphics.DrawImage(overlayImage2, 0, 0);
            graphics.DrawImage(overlayImage1, 0, 0);

            imageList.Images.Add(overlayedImage);

#if NET40
            System.Windows.Media.Imaging.BitmapImage bitmapImage = ToWpfBitmap(overlayedImage);
            wpfImageList.Add(bitmapImage);
#endif
        }
      }

    }





#if NET40

    /// <summary>
    /// Converts a <see cref="System.Drawing.Bitmap"/> into a WPF <see cref="BitmapSource"/>.
    /// </summary>
    /// <remarks>Uses GDI to do the conversion. Hence the call to the marshalled DeleteObject.
    /// </remarks>
    /// <param name="source">The source bitmap.</param>
    /// <returns>A BitmapSource</returns>
    public static System.Windows.Media.Imaging.BitmapSource ToBitmapSource(System.Drawing.Bitmap source)
    {
        System.Windows.Media.Imaging.BitmapSource bitSrc = null;

        var hBitmap = source.GetHbitmap();
        
        try
        {
            bitSrc = System.Windows.Interop.Imaging.CreateBitmapSourceFromHBitmap(
                hBitmap,
                IntPtr.Zero,
                System.Windows.Int32Rect.Empty,
                System.Windows.Media.Imaging.BitmapSizeOptions.FromEmptyOptions());
        }
        catch (System.ComponentModel.Win32Exception)
        {
            bitSrc = null;
        }
        finally
        {
            DeleteObject(hBitmap);
        }

        return bitSrc;
    }

    public static System.Windows.Media.Imaging.BitmapImage ToWpfBitmap(System.Drawing.Bitmap bitmap)
    {
        using (MemoryStream stream = new MemoryStream())
        {
            bitmap.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
            
            stream.Position = 0;
            System.Windows.Media.Imaging.BitmapImage result = new System.Windows.Media.Imaging.BitmapImage();
            result.BeginInit();
            result.DecodePixelWidth = 16;
            // According to MSDN, "The default OnDemand cache option retains access to the stream until the image is needed."
            // Force the bitmap to load right now so we can dispose the stream.
            result.CacheOption = System.Windows.Media.Imaging.BitmapCacheOption.OnLoad;
            result.StreamSource = stream;
            result.EndInit();
            result.Freeze();
            return result;
        }
    }

#endif


    /// <summary>
    /// Returns true, if the image lists are valid.
    /// </summary>
    public bool Valid
    {
      get 
      {
        return !imageList.Images.Empty;
      }
    }

    /// <summary>
    /// Creates an ImageList object for the given type of icons.
    /// </summary>
    /// <param name="sordTypes">SordType array</param>
    /// <param name="iconType">Icon type: 0=normal, 1=reference, 2=workflow</param>
    /// 
    protected void makeIcons(SordType[] sordTypes, int iconType)
    {
      foreach (SordType s in sordTypes)
      {
        System.Drawing.Icon icon = null;
        if (s.icon != null)
        {
          byte[] data = null;
          switch (iconType)
          {
            case 0:
              data = s.icon.data;
              break;

            case 1:
              data = s.disabledIcon.data; 
              break;
            case 2:
              data = s.workflowIcon.data;
              break;
          }

          try
          {
              bool existsImgData = (data != null && data.Length > 0);
              if (existsImgData)
              {
                  #if NET40
                      using (MemoryStream imgMemoryStream = new MemoryStream(data, 0, data.Length, false, true))
                      {
                          try
                          {
                                // Creating wpf image
                                System.Windows.Media.Imaging.BitmapImage bitmapImage = new System.Windows.Media.Imaging.BitmapImage();
                                bitmapImage.BeginInit();
                                bitmapImage.DecodePixelWidth = 16;
                                bitmapImage.CacheOption = System.Windows.Media.Imaging.BitmapCacheOption.OnLoad;
                                bitmapImage.StreamSource = imgMemoryStream;
                                bitmapImage.EndInit();
                                bitmapImage.Freeze();
                                wpfImageList.Add(bitmapImage);
                          }
                          catch (Exception)
                          {
                          }
                      }
                  #endif

                  using (MemoryStream imgMemoryStream = new MemoryStream(data, 0, data.Length, false, true))
                  {
                      try
                      {
                          icon = new System.Drawing.Icon(imgMemoryStream, 16, 16);
                          imageList.Images.Add(icon);
                          if (iconType == 0)
                          {
                              mapTypeToImageIdx[s.id] = imageList.Images.Count - 1;
                          }
                      }
                      catch (Exception)
                      {
                      }
                  }
              }
          }
          catch (Exception)
          {
          }
        }
      }
    }

    /// <summary>
    /// Return the index of the sord type in the image lists.
    /// </summary>
    /// <param name="sordType">Sord type</param>
    /// <param name="reference">Return reference icon</param>
    /// <param name="workflow">Return workflow icon</param>
    /// <returns>Image list index</returns>
    public int getImageIndex(int sordType, bool reference, bool workflow)
    {
        return getImageIndex(sordType, reference, workflow, false, false);
    }

    /// <summary>
    /// Return the index of the sord type in the image lists.
    /// </summary>
    /// <param name="sordType">Sord type</param>
    /// <param name="reference">Return reference icon</param>
    /// <param name="workflow">Return workflow icon</param>
    /// <param name="checkedOut">Return checked out icon</param>
    /// <param name="encrypted">Return encrypted icon</param>
    /// <returns>Image list index</returns>
      public int getImageIndex(int sordType, bool reference, bool workflow, bool checkedOut, bool encrypted)
    {
        int idx = 0;
        mapTypeToImageIdx.TryGetValue(sordType, out idx);

        if (checkedOut && encrypted)
        {
            idx += (3 * imageList.Images.Count / 4);
        }
        else if (encrypted)
        {
            idx += (2 * imageList.Images.Count / 4);
        }
        else if (checkedOut)
        {
            idx += imageList.Images.Count / 4;
        }

        if (reference)
        {
            idx += referenceIconsOffset;
        }
        else if (workflow)
        {
            idx += workflowIconsOffset;
        }
        return idx;
    }

    /// <summary>
    /// Image list for normal icons
    /// </summary>
    public ImageList Images
    {
      get { return imageList; }
    }

      #if NET40
          /// <summary>
          /// Returns a reference to image for a specific type of archive element.
          /// </summary>
          /// <param name="sordType">Type of archive element, for that Image have to be returned back.</param>
          /// <param name="reference">True if archive element is reference otherwise false.</param>
          /// <param name="workflow">True if workflow otherwise false.</param>
          /// <param name="checkedOut">True if document is checked out otherwise false.</param>
          /// <param name="encrypted">True if archive entry is encrypted otherwise false.</param>
          /// <returns>
          /// Returns a reference to image for a specific type of archive element or null if no image was found for a specific type of archive element.
          /// </returns>
          public System.Windows.Media.Imaging.BitmapImage GetWpfImageForSordType(int sordType, bool reference, bool workflow, bool checkedOut, bool encrypted)
          {
            int idx = 0;
            mapTypeToImageIdx.TryGetValue(sordType, out idx);

            if (checkedOut && encrypted)
            {
                idx += (3 * imageList.Images.Count / 4);
            }
            else if (encrypted)
            {
                idx += (2 * imageList.Images.Count / 4);
            }
            else if (checkedOut)
            {
                idx += imageList.Images.Count / 4;
            }

            if (reference)
            {
                idx += referenceIconsOffset;
            }
            else if (workflow)
            {
                idx += workflowIconsOffset;
            }

            if (wpfImageList != null && wpfImageList.Count > idx)
                return wpfImageList[idx];
            else
                return null;
          }
      #endif

  }
}
