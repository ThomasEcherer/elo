using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using EloixClient.IndexServer;
using EloixClient.IndexServerFW.MasterData;
using EloixClient.IndexServerFW.Utils;

namespace EloixClientUI.Controls
{
  /// <summary>
  /// This component shows a list of users and groups.
  /// </summary>
  public class UserListView : VirtualListView
  {
    /// <summary>
    /// Name column 
    /// </summary>
    public ColumnHeader ColumnHeaderName = new ColumnHeader();
    /// <summary>
    /// Type column (user or group)
    /// </summary>
    public ColumnHeader ColumnHeaderType = new ColumnHeader();
    /// <summary>
    /// ID column
    /// </summary>
    public ColumnHeader ColumnHeaderId = new ColumnHeader();

    /// <summary>
    /// Constructor
    /// </summary>
    public UserListView()
    {
      ColumnHeaderName.Text = EloixClientUI.Properties.Resources.Name;
      ColumnHeaderType.Text = EloixClientUI.Properties.Resources.Type;
      ColumnHeaderId.Text = EloixClientUI.Properties.Resources.ID;
      ColumnHeaderId.TextAlign = HorizontalAlignment.Right;

      ColumnHeaderName.Tag = new ColumnHeaderTag(new FWCompareUserNameByName());
      ColumnHeaderType.Tag = new ColumnHeaderTag(new FWCompareUserNameByType(EloixClientUI.Properties.Resources.User, EloixClientUI.Properties.Resources.Group));
      ColumnHeaderId.Tag = new ColumnHeaderTag(new FWCompareUserNameById());

      base.Columns.Add(ColumnHeaderName);
      base.Columns.Add(ColumnHeaderType);
      base.Columns.Add(ColumnHeaderId);

      base.SmallImageList = new ImageList();
      base.SmallImageList.Images.Add(EloixClientUI.Properties.Resources.ImgUser);
      base.SmallImageList.Images.Add(EloixClientUI.Properties.Resources.ImgGroup);
    }

    /// <summary>
    /// Get the selected user objects.
    /// </summary>
    [Browsable(false)]
    public IEnumerable<UserName> SelectedUsers
    {
      get 
      { 
        return new CastEnumerable<UserName>(SelectedObjects); 
      }
      set
      {
        List<int> listIdx = new List<int>();
        if (value != null)
        {
          Dictionary<int, UserName> mapToSelect = new Dictionary<int, UserName>();
          foreach (UserName un in value)
          {
            mapToSelect[un.id] = un;
          }
          int idx = 0;
          foreach (UserName un in UsersCache)
          {
            if (mapToSelect.Remove(un.id)) listIdx.Add(idx);
            if (mapToSelect.Count == 0) break;
          }
        }
        SelectedIndices = listIdx;
        internalRefresh();
      }
    }

    /// <summary>
    /// Get the selected user IDs.
    /// </summary>
    [Browsable(false)]
    public IEnumerable<int> SelectedUserIds
    {
      get
      {
        List<int> list = new List<int>();
        foreach (UserName un in SelectedUsers)
        {
          list.Add(un.id);
        }
        return list;
      }

      set
      {
        List<int> listIdx = new List<int>();
        if (value != null && UsersCache != null)
        {
          Dictionary<int, int> mapToSelect = new Dictionary<int, int>();
          foreach (int id in value)
          {
            mapToSelect[id] = id;
          }
          int idx = 0;
          foreach (UserName un in UsersCache)
          {
            if (mapToSelect.Remove(un.id)) listIdx.Add(idx);
            if (mapToSelect.Count == 0) break;
            idx++;
          }
        }
        SelectedIndices = listIdx;
        internalRefresh();
      }
    }
    /// <summary>
    /// Get/set the cache object.
    /// </summary>
    [Browsable(false)]
    public IResultCache<UserName> UsersCache
    {
      get { return (IResultCache<UserName>)ObjectsCache; }
      set { ObjectsCache = value; }
    }

    /// <summary>
    /// Empty
    /// </summary>
    protected override void makeColumns()
    {
    }
    /// <summary>
    /// Creates a ListViewItem filled by the given object.
    /// </summary>
    /// <param name="objT">UserName object</param>
    /// <returns>ListViewItem object</returns>
    protected override ListViewItem makeItem(Object objT)
    {
      UserName un = (UserName)objT;

      ListViewItem lv = new ListViewItem();
      lv.ImageIndex = un.type == UserInfoC.TYPE_USER ? 0 : 1;
      lv.Text = un.name;
      lv.SubItems.Add(un.type == UserInfoC.TYPE_USER ? EloixClientUI.Properties.Resources.User : EloixClientUI.Properties.Resources.Group);
      lv.SubItems.Add(Convert.ToString(un.id));

      lv.Tag = un;

      return lv;
    }

    protected override void BeforeSort(List<int> selectedObjectIDs)
    {
        Dictionary<int, object>.ValueCollection values = selection.Values;
        foreach (UserName userName in values)
        {
            selectedObjectIDs.Add(userName.id);
        }
    }

    protected override void AfterSort(object focusedObject, List<int> selectedObjectIDs, List<int> selectedIndizes)
    {
        int focusedItemIndex = -1;

        foreach (int userID in selectedObjectIDs)
        {
            for (int j = 0; j < objectsCacheValue.Count; j++)
            {
                if (objectsCacheValue[j] != null && objectsCacheValue[j] is UserName && ((UserName)objectsCacheValue[j]).id == userID)
                {
                    if (((UserName)objectsCacheValue[j]).id == ((UserName)focusedObject).id) focusedItemIndex = j;
                    selectedIndizes.Add(j);
                    break;
                }
            }
        }

        SelectedIndices = selectedIndizes;
        FocusedItem = Items[focusedItemIndex];
    }
  }
}
