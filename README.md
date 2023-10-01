# Development History

`dotnet --info`
`dotnet -h`
`dotnet new -h`

List all project templates available
`dotnet new list`

Create new solution
`dotnet new sln`

Create a webapi
`dotnet new webapi -n API`

List solution projects 
`dotnet sln list`

Add project to solution
`dotnet sln add API`

Start API project 
`dotnet run`

Allow https cert
`dotnet dev-certs https --trust`

Install dotnet-ef
`dotnet tool install --global dotnet-ef --version 7.0.11`

Update dotnet-ef
`dotnet tool update --global dotnet-ef --version 7.0.11`

Add migrations
`dotnet-ef migrations add InitialCreate -o Data/Migrations`

Creat database
`dotnet-ef database update`
