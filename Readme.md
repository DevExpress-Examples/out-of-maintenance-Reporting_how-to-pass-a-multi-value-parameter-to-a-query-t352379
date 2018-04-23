# How to pass a multi-value parameter to a query


This example illustrates a workaround to use <a href="https://documentation.devexpress.com/#XtraReports/CustomDocument114009">multi-value parameters</a> in a query string.<br><br>At present, <a href="https://documentation.devexpress.com/#XtraReports/CustomDocument17387">query parameters</a> cannot be directly mapped to multi-value report parameters, and this task is solved by adding a WHERE clause to the SQL string in the following way.<br><br>


```sql
SELECT [Categories].[CategoryID], [Categories].[CategoryName] FROM [Categories] [Categories]
WHERE [Categories].[CategoryID] IN (1,2,3)
```


<br>
<p>This example illustrates how to dynamically update the query string using values assigned to a report parameter.</p>

<br/>


