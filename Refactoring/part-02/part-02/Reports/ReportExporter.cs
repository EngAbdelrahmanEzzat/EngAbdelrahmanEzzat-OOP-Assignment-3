using System;
using System.Collections.Generic;
using System.Text;

namespace part_02.Reports
{
    public abstract class ReportExporter
    {
        public void Export(string path)
        {
            var rows = Load();
            if (!Validate(rows))
                throw new InvalidOperationException("Invalid data");
            var content = Format(rows);
            Save(path, content);
        }
        public virtual List<string[]> Load() =>
        [
        ["Id", "Name"],
        ["1", "Keyboard"],
        ["2", "Mouse"]
        ];

        public virtual bool Validate(List<string[]> rows) =>
        rows.Count > 1 && rows[0].Length > 0;

        public abstract string Format(List<string[]> rows);

        public virtual void Save(string path, string content) =>
        File.WriteAllText(path, content);

    }
}
