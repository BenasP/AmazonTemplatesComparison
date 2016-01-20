using System.Collections.Generic;
using System.Linq;

namespace AmazonTemplatesComparer
{
    public class Comparer
    {
        private readonly string firstFilePath;
        private readonly string secondFilePath;

        public Comparer(string firstFilePath, string secondFilePath)
        {
            this.firstFilePath = firstFilePath;
            this.secondFilePath = secondFilePath;
        }

        public void Run()
        {
            var firstFileData = XlsFile.Reader(firstFilePath);
            var secondFileData = XlsFile.Reader(secondFilePath);

            var changes = new List<XlsChanges>();
            foreach (var fData in firstFileData)
            {
                var change = new XlsChanges();
                var sData = secondFileData.FirstOrDefault(p => p.Name == fData.Name);
                if (sData == null)
                {
                    var sValueData = secondFileData.FirstOrDefault(p => p.Value == fData.Value);
                    if (sValueData == null)
                    {
                        change.OldName = fData.Name;
                        change.OldValue = fData.Value;
                        change.IsDeleted = true;
                    }
                    else
                    {
                        change.OldName = fData.Name;
                        change.NewName = sValueData.Name;
                        change.OldValue = fData.Value;
                        change.NewValue = sValueData.Value;
                    }
                    changes.Add(change);
                }
            }

            foreach (var sData in secondFileData)
            {
                var change = new XlsChanges();
                var fData = firstFileData.FirstOrDefault(f => f.Name == sData.Name || f.Value == sData.Value);
                if (fData == null)
                {
                    change.NewName = sData.Name;
                    change.NewValue = sData.Value;
                }
            }

            XlsFile.Writer(changes);
        }
    }

    public class XlsChanges
    {
        public bool IsDeleted { get; set; }

        public string OldName { get; set; }
        public string NewName { get; set; }

        public string OldValue { get; set; }
        public string NewValue { get; set; }
    }
}