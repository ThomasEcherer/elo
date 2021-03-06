﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using EloixClient.IndexServerFW;
using EloixClient.IndexServerFW.Content;
using EloixClientUI.Utils;
using System.IO;

namespace EloixClientUI.Common
{
  /// <summary>
  /// Event arguments for checkin events
  /// </summary>
  public class CheckinEventArgs : EventArgs
  {
    /// <summary>
    /// Parent ID or GUID
    /// </summary>
    public String ParentId;
    /// <summary>
    /// File to checkin
    /// </summary>
    public String File;
    /// <summary>
    /// Sord object
    /// </summary>
    public FWSord Sord;
    /// <summary>
    /// Cancel checkin of this Sord
    /// </summary>
    public bool Cancel;
    /// <summary>
    /// Cancel checkin of this and all subsequent Sords
    /// </summary>
    public bool CancelAll;
    /// <summary>
    /// Index-th. document to checkin 
    /// </summary>
    public int Index;
    /// <summary>
    /// Number of documents to checkin
    /// </summary>
    public int Count;
  }

  /// <summary>
  /// Helper class to checkin documents which file contents are contained in a DataObject.
  /// </summary>
  public class CheckinDocumentHandler
  {
    /// <summary>
    /// Connection to IndexServer
    /// </summary>
    protected FWConnection connVal;
    /// <summary>
    /// Keywording form to be used
    /// </summary>
    protected String maskIdVal;

    /// <summary>
    /// Delegate to declare checkin events
    /// </summary>
    /// <param name="e">CheckinEventArgs object</param>
    public delegate void CheckinHandler(CheckinEventArgs e);
    
    /// <summary>
    /// This event is fired before a document is checked in.
    /// </summary>
    /// <remarks>
    /// It might be used to display a keywording dialog or a version information dialog.
    /// </remarks>
    public event CheckinHandler BeforeCheckin;
    /// <summary>
    /// This event is fired after a document is checked in.
    /// </summary>
    public event CheckinHandler AfterCheckin;

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="conn">Connection to IndexServer</param>
    /// <remarks>
    /// The default document mask defined by the Windows Client is used by default.
    /// </remarks>
    public CheckinDocumentHandler(FWConnection conn)
    {
      Conn = conn;
    }

    /// <summary>
    /// Checkin document 
    /// </summary>
    /// <param name="parentId">Parent ID</param>
    /// <param name="dataObject">COM DataObject</param>
    public virtual void Checkin(String parentId, IDataObject dataObject)
    {
      checkinDataObject(parentId, dataObject);
    }

    /// <summary>
    /// Checkin document 
    /// </summary>
    /// <param name="parentFolder">Parent object</param>
    /// <param name="dataObject">COM DataObject</param>
    public virtual void Checkin(FWFolder parentFolder, IDataObject dataObject)
    {
      checkinDataObject(parentFolder.Guid, dataObject);
    }

    /// <summary>
    /// Connection to IndexServer
    /// </summary>
    public virtual FWConnection Conn
    {
      get
      {
        return connVal;
      }
      set
      {
        this.connVal = value;
        this.maskIdVal = value.Session.UserProfile.DefaultDocumentMaskId;
      }
    }

    /// <summary>
    /// Get/Set the keywording form ID
    /// </summary>
    public virtual String MaskId
    {
      get { return maskIdVal; }
      set { maskIdVal = value; }
    }

    /// <summary>
    /// This function checks wether the given data object contains at least one file.
    /// </summary>
    /// <param name="data">DataObject</param>
    /// <returns>True, if the DataObject contains files.</returns>
    public virtual bool IsFile(IDataObject data)
    {
      bool succ = false;
      if ( data != null)
      {
        // Does the DataObject contain files from the file system?
        if (data.GetDataPresent(DataFormats.FileDrop))
        {
          succ = true;
          String[] filePaths = (String[])data.GetData(DataFormats.FileDrop, false);
          foreach (String f in filePaths)
          {
            if ((File.GetAttributes(f) & FileAttributes.Directory) != 0)
            {
              // cannot checkin folders - there is something more to do for doing this.
              succ = false;
              break;
            }
          }
        }
        // Does the DataObject contain files e.g. from Outlook?
        else if (data.GetDataPresent("FileGroupDescriptorW"))
        {
          succ = true;
        }
      }
      return succ;
    }

    /// <summary>
    /// Checkin one document
    /// </summary>
    /// <param name="parentId">Parent ID</param>
    /// <param name="fname">File path</param>
    /// <param name="index">Index-th. document</param>
    /// <param name="count">Number of documents</param>
    /// <returns></returns>
    protected virtual bool checkinNewDocument(string parentId, string fname, int index, int count)
    {
      FWDocument doc = Conn.Content.CreateDocument(parentId, MaskId);
      doc.Version.File = fname;

      CheckinEventArgs e = new CheckinEventArgs();
      e.Cancel = false;
      e.CancelAll = false;
      e.Sord = doc;
      e.Index = index;
      e.Count = count;
      e.ParentId = parentId;
      e.File = fname;
      
      OnBeforeCheckin(e);
      if (!e.Cancel && !e.CancelAll)
      {
        doc.Checkin();
        OnAfterCheckin(e);
      }

      return e.CancelAll;
    }

    /// <summary>
    /// Fires the event BeforeCheckin
    /// </summary>
    /// <param name="e">Event arguments</param>
    protected virtual void OnBeforeCheckin(CheckinEventArgs e)
    {
      if (BeforeCheckin != null)
      {
        BeforeCheckin(e);
      }
    }

    /// <summary>
    /// Fires the event AfterCheckin
    /// </summary>
    /// <param name="e">Event arguments</param>
    protected virtual void OnAfterCheckin(CheckinEventArgs e)
    {
      if (AfterCheckin != null)
      {
        AfterCheckin(e);
      }
    }

    /// <summary>
    /// Checkin all documents contained in the given DataObject
    /// </summary>
    /// <param name="parentId">Parent ID</param>
    /// <param name="dataObjectCOM">COM DataObject</param>
    protected virtual void checkinDataObject(String parentId, IDataObject dataObjectCOM)
    {
      if (dataObjectCOM != null)
      {
        CheckinEventArgs e = new CheckinEventArgs();
        e.ParentId = parentId;

        if (dataObjectCOM.GetDataPresent("FileGroupDescriptorW"))
        {
          //wrap standard IDataObject in OutlookDataObject
          OutlookDataObject dataObject = new OutlookDataObject(dataObjectCOM);

          //get the names and data streams of the files dropped
          string[] filenames = (string[])dataObject.GetData("FileGroupDescriptorW");
          MemoryStream[] filestreams = (MemoryStream[])dataObject.GetData("FileContents");

          for (int fileIndex = 0; fileIndex < filenames.Length; fileIndex++)
          {
            //use the fileindex to get the name and data stream
            string fname = Conn.Content.TempDir + "\\" + filenames[fileIndex];
            MemoryStream filestream = filestreams[fileIndex];

            //save the file stream using its name 
            FileStream outputStream = File.Create(fname);
            filestream.WriteTo(outputStream);
            outputStream.Close();
            File.SetAttributes(fname, FileAttributes.ReadOnly);

            // checkin
            if (checkinNewDocument(parentId, fname, fileIndex, filenames.Length)) break;
          }
        }
        else if (dataObjectCOM.GetDataPresent(DataFormats.FileDrop))
        {
          string[] filePaths = (string[])dataObjectCOM.GetData(DataFormats.FileDrop, false);
          for (int fileIndex = 0; fileIndex < filePaths.Length; fileIndex++)
          {
            string fname = filePaths[fileIndex];
            if (checkinNewDocument(parentId, fname, fileIndex, filePaths.Length)) break;
          }
        }
      }
    }
  }
}
