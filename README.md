<h1>AutoHub - Vehicle Management Store</h1>

<h2>Introduction</h2>
<ul>
<li>Autohub allows you to manage the vehicles in your store more faster and efficiently.</li>
<li>The application is built natively for Windows, support from Windows 7 to 11.</li>
<li>With the integration of the SQL Server backend service running locally on your network.</li>
<li>Ensures data integrity and security with private backend management.</li>
</ul>

<h2>Technologis Stack, Frameworks</h2>
<ul>
<li><b>SQL Server</b>: Database hosting, Local database management for data storage and retrieval.</li>
<li><b>Windows Forms (.NET Core App 7.0.17) </b>: Forms,UI/UX, Native desktop application development for Windows.</li>
<li><b>SQL Server</b>: Database hosting, Local database management for data storage and retrieval.</li>
</ul>

<h2>Installment</h2>
<ol>
<li> Download the source code. Apply this command to clone the repo to your local environment <pre> <code> gh repo clone cdCKhang/AutoHub</code></pre></li>
<br>
<li> Set up SQL Server Database. Use the provided query to initialize the database with sample data.</li>
<br>
<li>Replace the connection string variable with your own SQL Connection String. Located in the GetData.cs File in Data Access Layer Folder.
<br> Example of a valid connection string :
<pre><code class="language-csharp">string connection = "@Data Source=TESTSERVER;Initial Catalog=ProjectcnDotNet_CDM;Integrated Security=True;Trust Server Certificate=True";</code></pre></li>
<br>
<li>Click on AutoHub.sln (Visual Studio IDE) to build all the depedencies automatically. Run the code.</li>
</ol>

<h2>Video Demo</h2>


<h2>Screenshots</h2>
<ul>
<li>
    <h3>Login Form</h3>   
</li>



<li>
    <h3>Customer Info</h3>
</li>



<li>
    <h3>Transaction</h3>
</li>



<li>
    <h3>Car Models</h3>
</li>



<li>
    <h3>Manufactueres</h3>
</li>



<li>
    <h3>Sales Peron</h3>
</li>



<li>
    <h3>Statistics</h3>
</li>



</ul>



