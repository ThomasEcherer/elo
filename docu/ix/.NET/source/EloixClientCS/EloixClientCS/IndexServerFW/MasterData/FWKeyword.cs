using System;
using System.Collections.Generic;
using EloixClient.IndexServer;

namespace EloixClient.IndexServerFW.MasterData
{
    /// <summary>
    /// This provides a dynamic list for FWKeyword objects.
    /// </summary>
    public class FWKeywordChildren : List<FWKeyword>
    {
        /// <summary>
        /// Parent of the list.
        /// </summary>
        private FWKeyword parentValue;
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="parent">Parent object</param>
        public FWKeywordChildren(FWKeyword parent)
        {
            this.parentValue = parent;
        }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="parent">Parent object</param>
        /// <param name="collection">The contained keywords are copied into the list</param>
        public FWKeywordChildren(FWKeyword parent, IEnumerable<FWKeyword> collection)
        {
            this.parentValue = parent;
            this.AddRange(collection);
        }
        /// <summary>
        /// Access parent object
        /// </summary>
        public FWKeyword Parent
        {
            get { return parentValue; }
            set { parentValue = value; }
        }
        /// <summary>
        /// Remove the child keyword with the given ID.
        /// </summary>
        /// <param name="id">Keyword ID</param>
        public void Remove(String id)
        {
            for (int i = 0; i < Count; i++)
            {
                if (this[i].Id.Equals(id))
                {
                    this.RemoveAt(i);
                    break;
                }
            }
        }
    }

    public class FWKeyword : FWMasterDataBase, IComparable<FWKeyword>
    {
        private FWKeyword parentValue;
        private Keyword keywordValue;
        private FWKeywordChildren childrenValue;
        private KeywordZ keywordZValue;
        private bool readAllChildren;

        public FWKeyword(FWMasterDataInterface ifc, Keyword kw, FWKeyword kwParent)
            : base(ifc)
        {
            this.parentValue = kwParent;
            this.keywordValue = kw;
            this.keywordZValue = KeywordC.mbEdit;
            this.readAllChildren = false;
        }

        public virtual Keyword Core
        {
            get
            {
                if (childrenValue != null)
                {
                    keywordValue.children = MakeChildrenArray();
                }
                return keywordValue;
            }
            set
            {
                keywordValue = value;
                childrenValue = null;
            }
        }

        public virtual String Id
        {
            get { return keywordValue.id; }
            set { keywordValue.id = value; }
        }

        public virtual String Text
        {
            get { return keywordValue.text; }
            set { keywordValue.text = value; }
        }

        public virtual bool Prefixed
        {
            get { return keywordValue.add; }
            set
            {
                keywordValue.add = value;
                if (keywordValue.add) keywordValue.enabled = false;
            }
        }

        public virtual bool Enabled
        {
            get { return keywordValue.enabled; }
            set
            {
                keywordValue.enabled = value;
                if (keywordValue.enabled) keywordValue.add = false;
            }
        }

        public virtual bool Raw
        {
            get { return keywordValue.raw; }
            set { keywordValue.raw = value; }
        }

        public virtual KeywordZ KeywordZ
        {
            get { return keywordZValue; }
            set { keywordZValue = value; }
        }

        public virtual FWKeyword Parent
        {
            get { return parentValue; }
            set { parentValue = value; }
        }

        public virtual bool IsRoot
        {
            get { return Parent == null; }
        }

        public virtual bool ChildrenAvail
        {
            get { return childrenValue != null || keywordValue.children != null; }
        }

        public virtual FWKeywordChildren Children
        {
            get
            {
                FWKeywordChildren ret = childrenValue;
                if (ret == null)
                {
                    UpdateChildren();
                    ret = childrenValue;
                }

                return ret;
            }

            set
            {
                childrenValue = value;
                keywordValue.children = null;
            }
        }

        public virtual void ReadAll()
        {
            if (!readAllChildren)
            {
                readAllChildren = true;
                childrenValue = null;
                keywordValue.children = null;
                UpdateChildren();
            }
        }

        protected virtual void UpdateChildren()
        {
            if (keywordValue.children == null)
            {
                keywordValue = ifc.Conn.Ix.checkoutKeywords(
                  new String[] { keywordValue.id },
                  keywordZValue,
                  readAllChildren ? -1 : 0,
                  LockC.NO)[0];
            }

            if (childrenValue == null)
            {
                childrenValue = MakeChildrenList();
            }

            keywordValue.children = null;
        }

        private FWKeywordChildren MakeChildrenList()
        {
            FWKeywordChildren ret = childrenValue;
            if (keywordValue.children != null)
            {
                ret = new FWKeywordChildren(this);
                foreach (Keyword kwChild in keywordValue.children)
                {
                    FWKeyword kwChildFW = ifc.ClassFactory.NewFWKeyword(kwChild, this);
                    ret.Add(kwChildFW);
                }
            }
            return ret;
        }

        private Keyword[] MakeChildrenArray()
        {
            Keyword[] ret = keywordValue.children;
            if (childrenValue != null)
            {
                ret = new Keyword[childrenValue.Count];
                for (int i = 0; i < childrenValue.Count; i++)
                {
                    ret[i] = childrenValue[i].keywordValue;
                }
            }
            return ret;
        }

        public void UpdateBeforeCheckin()
        {
            if (childrenValue != null)
            {
                foreach (FWKeyword kw in childrenValue)
                {
                    kw.UpdateBeforeCheckin();
                }
                keywordValue.children = MakeChildrenArray();
            }
        }

        public int CompareTo(FWKeyword rhs)
        {
            return this.Text.CompareTo(rhs.Text);
        }

        public virtual void Checkin()
        {
            UpdateBeforeCheckin();
            Conn.Ix.checkinKeywords(new Keyword[] { Core }, LockC.YES);
            Conn.MasterData.Keywords.Invalidate();
        }

        public virtual List<FWKeyword> Find(String keywordText)
        {
            List<FWKeyword> ret = new List<FWKeyword>();
            ReadAll();
            InternalFindRecursive(this, keywordText.ToLower(), ret);
            return ret;
        }

        protected virtual void InternalFindRecursive(FWKeyword kw, String keywordText, List<FWKeyword> ret)
        {
            if (kw.Text.ToLower().StartsWith(keywordText))
            {
                ret.Add(kw);
            }
            foreach (FWKeyword kwChild in kw.Children)
            {
                InternalFindRecursive(kwChild, keywordText, ret);
            }
        }

    }
}
