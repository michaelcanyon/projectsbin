using System;
using BenchmarkDotNet.Reports;
using BenchmarkDotNet.Running;

namespace BenchmarkDotNet.Columns
{
    public class ParamsColumnWidth : IColumn
    {
        // private readonly Func<int,int,int> getTag;
        string[] values;
        public string Id { get; }
        public string ColumnName { get; }

        public ParamsColumnWidth(string columnName)
        {
            // this.getTag = getTag;
            ColumnName = columnName;
            Id = nameof(TagColumn) + "." + ColumnName;
        }

        public bool IsDefault(Summary summary, BenchmarkCase benchmarkCase) => false;
        public string GetValue(Summary summary, BenchmarkCase benchmarkCase)
        {
            values = benchmarkCase.Parameters.ValueInfo.Split(',', '=', ' ', '[', ']');
            foreach (var item in values)
            {
                try
                {
                    Convert.ToInt32(item);
                    return item;
                }
                catch
                { }
            }
            return "None definition";
        }
        public bool IsAvailable(Summary summary) => true;
        public bool AlwaysShow => true;
        public ColumnCategory Category => ColumnCategory.Params;
        public int PriorityInCategory => 0;
        public bool IsNumeric => false;
        public UnitType UnitType => UnitType.Dimensionless;
        public string Legend => $"Custom '{ColumnName}' tag column";
        public string GetValue(Summary summary, BenchmarkCase benchmarkCase, SummaryStyle style) => GetValue(summary, benchmarkCase);
        public override string ToString() => ColumnName;
    }

    public class ParamsColumnHeight : IColumn
    {
        // private readonly Func<int,int,int> getTag;
        string[] values;
        bool NotFirstItem = false;
        public string Id { get; }
        public string ColumnName { get; }
        public ParamsColumnHeight(string columnName)
        {
            // this.getTag = getTag;
            ColumnName = columnName;
            Id = nameof(TagColumn) + "." + ColumnName;
        }
        public bool IsDefault(Summary summary, BenchmarkCase benchmarkCase) => false;
        public string GetValue(Summary summary, BenchmarkCase benchmarkCase)
        {
            values = benchmarkCase.Parameters.ValueInfo.Split(',', '=', ' ', '[', ']');
            foreach (var item in values)
            {
                try
                {
                    Convert.ToInt32(item);
                    if (NotFirstItem == true)
                    {
                        NotFirstItem = false;
                        return item;

                    }
                    else
                        NotFirstItem = true;
                }
                catch
                { }
            }
            return "None definition";
        }

        public bool IsAvailable(Summary summary) => true;
        public bool AlwaysShow => true;
        public ColumnCategory Category => ColumnCategory.Params;
        public int PriorityInCategory => 0;
        public bool IsNumeric => false;
        public UnitType UnitType => UnitType.Dimensionless;
        public string Legend => $"Custom '{ColumnName}' tag column";
        public string GetValue(Summary summary, BenchmarkCase benchmarkCase, SummaryStyle style) => GetValue(summary, benchmarkCase);
        public override string ToString() => ColumnName;
    }
}