// <auto-generated>

using System;
using System.Collections.Generic;

namespace Tester.Integration.EFCore6.Single_context_many_files
{
    public class StpMultipleResultsReturnModel
    {
        public class ResultSetModel1
        {
            public int codeObjectNo { get; set; }
            public int? applicationNo { get; set; }
        }
        public List<ResultSetModel1> ResultSet1;
        public class ResultSetModel2
        {
            public int Id { get; set; }
            public int PrimaryColourId { get; set; }
            public string CarMake { get; set; }
            public int? computed_column { get; set; }
            public int? computed_column_persisted { get; set; }
        }
        public List<ResultSetModel2> ResultSet2;
        public class ResultSetModel3
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
        public List<ResultSetModel3> ResultSet3;
    }

}
// </auto-generated>
