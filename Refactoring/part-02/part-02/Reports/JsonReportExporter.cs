using System;
using System.Collections.Generic;
using System.Text;

namespace part_02.Reports
{
    public class JsonReportExporter : ReportExporter
    {
        public override string Format(List<string[]> rows)
        {
            var items = rows.Skip(1).Select(r => $"{{\"Id\":\"{r[0]}\",\"Name\":\"{r[1]}\"}}");
            return "[" + string.Join(",", items) + "]";
        }
    }
}
