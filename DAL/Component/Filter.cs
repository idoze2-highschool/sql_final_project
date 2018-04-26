using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALOrg.Components
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
        private Filter(Filter Filter) : this(Filter.Name, Filter.Query, Filter.Format, Filter.AcceptType)
        {

        }
        internal bool SetValue(string CheckValue, string FormatValue)
        {
            if (IsAcceptableValue(CheckValue))
            {
                ValueSet = true;
                Query = Query.Replace("[CheckValue]", CheckValue.ToString());
                Format = Format.Replace("[FormatValue]", FormatValue);
            }
            else
                return false;
            return true;
        }
        private bool IsAcceptableValue(string Value)
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
        public static Filter CloneWithValue(Filter Filter, string CheckValue, string FormatValue)
        {
            Filter newFilter = new Filter(Filter);
            if (newFilter.SetValue(CheckValue, FormatValue))
                return newFilter;
            return Filter;
        }
        public override string ToString()
        {
            return Name;
        }
    }
    public class FilterCollection
    {
        private List<Filter> Filters;
        private int Count = 0;
        public FilterCollection()
        {
            Filters = new List<Filter>();
        }
        public FilterCollection(params Filter[] Filters) : this()
        {
            this.Filters.AddRange(Filters);
        }
        public void Add(Filter Filter, bool SetValue)
        {
            if ((Filter.ValueSet) == SetValue)
            {
                Add(Filter);
            }
        }
        //Base Method
        public void Add(Filter Filter)
        {
            Count++;
            Filters.Add(Filter);
        }
        public Filter Remove(int Index)
        {
            Filter Filter;
            try
            {
              Filter = Filters[Index];
                Filters.RemoveAt(Index);
                Count--;
            }
            catch
            {
                return Components.Filters.NullFilter;
            }
            
            return Filter;

        }
        public string[] GetQueries()
        {
            return Filters.Where(F => F.ValueSet).Select(F => F.Query).ToArray();
        }
        public string[] GetNames()
        {
            return Filters.Select(F => F.Name).ToArray();
        }
        public string[] GetFilterFormats()
        {
            return Filters.Where(F => F.ValueSet).Select(F => F.Format).ToArray();
        }
    }
    #region Static Classes
    public static class Filters
    {
        #region NullFilter
        public static readonly Filter NullFilter = new Filter(
            "NullFilter",
            "",
            "NullFilter",
            typeof(string)
            );
        #endregion
        #region User Filters
        public static class User
        {
            public static readonly Filter InGroup = new Filter(
                "InGroup",
                "Users.[UserID] in (SELECT StudentToGroup.[StudentID] as UserID FROM StudentToGroup WHERE (StudentToGroup.[GroupID] = [CheckValue]))",
                "InGroup: " + "[FormatValue]",
                typeof(int)
                );
            public static readonly Filter Type = new Filter(
                "Type",
                "Users.[UserType] = [CheckValue]",
                "Type: " + "[FormatValue]",
                typeof(int)
                );
            public static readonly Filter FNameLike = new Filter(
                "FName Like",
                "Users.[FName] Like %[CheckValue]%",
                "FName-%[FormatValue]%",
                typeof(string)
                );
            public static readonly Filter LNameLike = new Filter(
                "LName Like",
                "Users.[LName] Like %[CheckValue]%",
                "LName-%[FormatValue]%",
                typeof(string)
                );
        }
        #endregion
        #region Course Filters
        public static class Course
        {
        }
        #endregion
    }
    public static class FilterCollections
    {
        public static readonly FilterCollection NullFilterCollection = new FilterCollection();
        public static readonly FilterCollection UserFilters = new FilterCollection(
            Filters.User.InGroup,
            Filters.User.Type,
            Filters.User.FNameLike,
            Filters.User.LNameLike
            );
        public static readonly FilterCollection CourseFilters = new FilterCollection(
            ); 
    }
    #endregion
}
