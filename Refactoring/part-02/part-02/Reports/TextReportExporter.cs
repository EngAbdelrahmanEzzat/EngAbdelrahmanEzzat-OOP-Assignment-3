using System;
using System.Collections.Generic;
using System.Text;

namespace part_02.Reports
{
    public class TextReportExporter : ReportExporter
    {
        public override string Format(List<string[]> rows)
        {
           return string.Join(Environment.NewLine, rows.Select(r => string.Join(" | ", r)));
        }
    }
}
