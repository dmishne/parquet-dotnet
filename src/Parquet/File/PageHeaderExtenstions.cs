// <copyright file="PageHeaderExtenstions.cs" company="Microsoft">
// Copyright (c) Microsoft Corporation. All rights reserved.
// </copyright>

using Parquet.Thrift;

namespace Parquet.File {
    internal static class PageHeaderExtenstions {
        public static int GetNumValues(this Thrift.PageHeader ph) => ph.Type == PageType.DATA_PAGE ? ph.Data_page_header.Num_values : ph.Data_page_header_v2.Num_values;

        public static Statistics GetStatistics(this Thrift.PageHeader ph) => ph.Type == PageType.DATA_PAGE ? ph.Data_page_header.Statistics : ph.Data_page_header_v2.Statistics;
        
        public static Encoding GetEncoding(this Thrift.PageHeader ph) => ph.Type == PageType.DATA_PAGE ? ph.Data_page_header.Encoding : ph.Data_page_header_v2.Encoding;
    }
}