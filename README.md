# Development History

## Dotnet Project 
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

## Entity Framework 

Install dotnet-ef
`dotnet tool install --global dotnet-ef --version 7.0.11`

Update dotnet-ef
`dotnet tool update --global dotnet-ef --version 7.0.11`

Add migrations
`dotnet-ef migrations add InitialCreate -o Data/Migrations`

Creat database
`dotnet-ef database update`


## Create Angular project
(link1)[https://github.com/nvm-sh/nvm/issues/400]
(link2)[https://docs.npmjs.com/downloading-and-installing-node-js-and-npm]
(link3)[https://angular.io/guide/setup-local]

Install Angular (version 16.2.5)
`npm i -g @angular/cli@16.2.5`

Update node version to support angular version
`nvm install v16.14.0 --reinstall-packages-from=16.13.0`

Create Angular client
`ng new client`

Run client app
`ng serve`

Adding angular bootstrap from [ngx-bootstrap](https://valor-software.com/ngx-bootstrap/#/documentation)

Install font-awesome
`npm install font-awesome`

Install github mkcert as admin using choco in windows [link](https://github.com/FiloSottile/mkcert)

Modify Entity and update migration
`dotnet-ef migrations add UserPasswordAdded`

Apply all migrations
`dotnet-ef database update -v`
