using System;
using System.Drawing;
using EloixClient.IndexServer;

namespace EloixClient.IndexServerFW.MasterData
{
    /// <summary>
    /// This class extends the ColorData class with an additional color object.
    /// </summary>
    public class FWColor : FWMasterDataBase
    {
        /// <summary>
        /// IXClient Marker/Color definition
        /// </summary>
        protected ColorData coreVal;

        /// <summary>
        /// RGB Color object
        /// </summary>
        protected Color colorVal;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="ifc">Content interface object, not used yet - just for the sake of symmetry</param>
        /// <param name="colorData">ColorData object from IndexServer API. Used for the calculation of the Color value.</param>
        public FWColor(FWMasterDataInterface ifc, ColorData colorData)
            : base(ifc)
        {
          this.coreVal = colorData;
          int col = colorData.RGB;
          this.colorVal = Color.FromArgb(((col & 0xff) << 16) | (col & 0xff00) | ((col >> 16) & 0xff));
        }

        public virtual ColorData Core
        {
            get { return coreVal; }
        }

        /// <summary>
        /// Gets the name (short description) of the entry.
        /// </summary>
        public virtual String Name
        {
            get { return coreVal.name; }
        }

        /// <summary>
        /// Gets the Guid of the entry.
        /// </summary>
        public virtual String Guid
        {
            get { return coreVal.guid; }
        }

        /// <summary>
        /// Gets the id or kind (as used in the Sord object) of the entry.
        /// </summary>
        public virtual int Id
        {
            get { return coreVal.id; }
        }

        /// <summary>
        /// Gets the Color of the entry.
        /// </summary>
        public virtual Color RGBColor
        {
            get { return colorVal; }
        }

        /// <summary>
        /// Write or Insert this color object.
        /// </summary>
        /// <remarks>The object is inserted, if it's Id == -1 or if it's name is not found in the list of current colors.</remarks>
        public void Checkin()
        {
            ColorData[] colorDatas = Conn.Ix.checkoutColors(LockC.NO);
            int foundIdx = -1;
            if (Id != -1)
            {
                for (int i = 0; i < colorDatas.Length && foundIdx < 0; i++)
                {
                    if (colorDatas[i].id == Id)
                    {
                        foundIdx = i;
                        break;
                    }
                }
            }

            if (foundIdx == -1)
            {
                ColorData[] newArr = new ColorData[colorDatas.Length + 1];
                for (int i = 0; i < colorDatas.Length; i++) newArr[i] = colorDatas[i];
                foundIdx = newArr.Length - 1;
                colorDatas = newArr;
            }

            ColorData coreCopy = colorDatas[foundIdx] = new ColorData(Core);
            
            int col = colorVal.ToArgb();
            coreCopy.RGB = ((col & 0xff) << 16) | (col & 0xff00) | ((col >> 16) & 0xff);

            // Write new Array of colors.
            // This function does not return the new ID. 
            Conn.Ix.checkinColors(colorDatas, LockC.YES);
            
            // Find the written object by name and update internal core object.
            colorDatas = Conn.Ix.checkoutColors(LockC.NO);
            for (int i = 0; i < colorDatas.Length; i++)
            {
                if (this.Name.Equals(colorDatas[i].name))
                {
                    coreVal = colorDatas[i];
                    col = coreVal.RGB;
                    this.colorVal = Color.FromArgb(((col & 0xff) << 16) | (col & 0xff00) | ((col >> 16) & 0xff));
                    break;
                }
            }

            // Invalidate cache
            Conn.MasterData.Colors.Invalidate();
        }

        public void Delete()
        {
            ColorData[] colorDatas = Conn.Ix.checkoutColors(LockC.NO);
            if (colorDatas.Length <= 1) return; //cannot delete system color

            // Find this ColorData object
            int foundIdx = -1;
            for (int i = 0; i < colorDatas.Length; i++)
            {
                if (this.Name.Equals(colorDatas[i].name))
                {
                    foundIdx = i;
                    break;
                }
            }
            if (foundIdx == -1) return;

            // Make new array without this ColorData 
            ColorData[] newArr = new ColorData[colorDatas.Length - 1];
            for (int i = 0, j = 0; i < colorDatas.Length; i++)
            {
                if (i == foundIdx) continue;
                newArr[j++] = colorDatas[i];
            }

            // Write new Array of colors.
            // This function does not return the new ID. 
            Conn.Ix.checkinColors(colorDatas, LockC.YES);

            // Invalidate cache
            Conn.MasterData.Colors.Invalidate();
        }

    }
}
