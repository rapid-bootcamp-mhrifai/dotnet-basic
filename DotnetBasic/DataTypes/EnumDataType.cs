using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    public enum EnumDays
    {
        Saturday, Sunday, Monday, Tuesday, Wednesday, Thursday, Friday
    }

    public enum Colors { Red = 1, Green = 2, Blue = 4, Yellow = 8 };

    public enum EnumFileMode
    {
        CreateNew = 1,
        Create = 2,
        Open = 3,
        OpenOrCreate = 4,
        Truncate = 5,
        Append = 6,
    }

    public enum ApprovalStep
    {
        Submitted = 0,
        Requested = 1,
        Readed = 2,
        Approved = 3,
        Rejected = 4
    }

    public class EnumDataType
    {
        public EnumDataType()
        {
        }
    }
}


