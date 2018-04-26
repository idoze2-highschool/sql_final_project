using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALOrg.Component
{
    public class Filter
    {
        private string name, query, format;
        private Type acceptType;
        private bool valueSet;
        public Filter(string Name, string Query, string Format, Type AcceptType)
        {
            this.Name = Name;
            this.Query = Query;
            this.Format = Format;
            this.AcceptType = AcceptType;
            valueSet = false;
        }
        public bool SetValue(string CheckValue, string FormatValue)
        {
            if (TrySetValue(CheckValue))
            {
                ValueSet = true;
                Query = Query.Replace("[CheckValue]", CheckValue.ToString());
                Format = Format.Replace("[FormatValue]", FormatValue);
            }
            else
                return false;
            return true;
        }
        private bool TrySetValue(string Value)
        {
            try
            {
                Convert.ChangeType(Value, AcceptType);
            }
            catch
            {
                return false;
            }
            return true;
        }
        public string Name { get => name; private set => name = value; }
        public string Query { get => query; private set => query = value; }
        public string Format { get => format; private set => format = value; }
        internal bool ValueSet { get => valueSet; private set => valueSet = value; }
        private Type AcceptType { get => acceptType; set => acceptType = value; }
        public override string ToString()
        {
            return Name;
        }
    }
    public class FilterCollection
    {
        private List<Filter> Filters;
        public FilterCollection()
        {
            Filters = new List<Filter>();
        }
        internal FilterCollection(params Filter[] Filters)
        {
            this.Filters.AddRange(Filters);
        }
        public void Add(Filter Filter)
        {
            Filters.Add(Filter);
        }
        public bool TrySetValue(int Index, string Value, string FormatValue)
        {
            return Filters[Index].SetValue(Value, FormatValue);
        }
        public string[] GetConditions()
        {
            return Filters.Select(F => F.Query).ToArray();
        }
    }
    #region Static Classes
    public static class Filters
    {
        #region User Filters
        public static class User
        {
            public static Filter InGroup = new Filter(
                "InGroup",
                "[UserID] in (SELECT StudentToGroup.[StudentID] as UserID FROM StudentToGroup WHERE (StudentToGroup.[GroupID] = [CheckValue]))",
                "InGroup: " + "[FormatValue]",
                typeof(int)
                );
            public static Filter Type = new Filter(
                "Type",
                "[UserType] = [CheckValue]",
                "Type: " + "[FormatValue]",
                typeof(int)
                );
            public static Filter FNameLike = new Filter(
                "FName Like",
                "[FName] Like %[CheckValue]%",
                "FName-%[FormatValue]%",
                typeof(string)
                );
            public static Filter LNameLike = new Filter(
                "LName Like",
                "[LName] Like %[CheckValue]%",
                "LName-%[FormatValue]%",
                typeof(string)
                );
        }
        #endregion
    }
    public static class FilterCollections
    {
        public static FilterCollection UserFilters = new FilterCollection(
            Filters.User.InGroup,
            Filters.User.Type,
            Filters.User.FNameLike,
            Filters.User.LNameLike
            );
    }
    #endregion
}
