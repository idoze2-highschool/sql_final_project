using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Component
{
    public class Filter
    {
        private string name, query, format;
        private Type acceptType;
        private bool valueSet;
        private Filter baseFilter;
        private Filter(Filter Filter) : this(Filter.Name, Filter.Query, Filter.Format, Filter.AcceptType)
        {
            baseFilter = Filter;
        }
        //Base Ctor
        public Filter(string Name, string Query, string Format, Type AcceptType)
        {
            this.Name = Name;
            this.Query = Query;
            this.Format = Format;
            this.AcceptType = AcceptType;
            valueSet = false;
            baseFilter = this;
        }
        public Filter Reset()
        {
                return new Filter(baseFilter);
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
        private Filter BaseFilter { get => baseFilter; set => baseFilter = value; }
        public static Filter CloneWithValue(Filter Filter,string Value)
        {
            return CloneWithValue(Filter, Value, Value);
        }
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
        public bool Add(Filter Filter, bool SetValue)
        {
            if ((Filter.ValueSet) == SetValue)
            {
                Add(Filter);
                return true;
            }
            return false;
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
                return Component.Filters.NullFilter;
            }
            
            return Filter;

        }
        public string[] GetQueries()
        {
            if (Filters.Count > 0)
                return Filters.Where(F => F.ValueSet).Select(F => F.Query).ToArray();
            else
                return new string[] { };
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
    
}
