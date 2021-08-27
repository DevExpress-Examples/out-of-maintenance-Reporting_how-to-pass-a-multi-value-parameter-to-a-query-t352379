<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128602150/15.2.7%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T352379)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [XtraReport1.cs](./CS/WindowsFormsApplication3/XtraReport1.cs) (VB: [XtraReport1.vb](./VB/WindowsFormsApplication3/XtraReport1.vb))
<!-- default file list end -->
# How to pass a multi-value parameter to a query


This example illustrates a workaround to use <a href="https://documentation.devexpress.com/#XtraReports/CustomDocument114009">multi-value parameters</a> in a query string.<br><br>At present, <a href="https://documentation.devexpress.com/#XtraReports/CustomDocument17387">query parameters</a> cannot be directly mapped to multi-value report parameters, and this task is solved by adding a WHERE clause to the SQL string in the following way.<br><br>


```sql
SELECT [Categories].[CategoryID], [Categories].[CategoryName] FROM [Categories] [Categories]
WHERE [Categories].[CategoryID] IN (1,2,3)
```


<br>
<p>This example illustrates how to dynamically update the query string using values assigned to a report parameter.</p>

<br/>


