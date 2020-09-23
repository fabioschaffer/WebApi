Aplicativo Web API com as seguintes features:
  - Framework .NET Core 3.1.
  - Autenticação Jwt (JSON Web Token), esquema "Bearer".
  - Métodos acessíveis somente via autenticação ("Authorize").
  - Métodos do tipo HttpGet, HttpPost, HttpPut e HttpDelete.
  - Camada de negócio (Business Layer Logic).
  - Acesso ao banco de dados MS SQL Server.
  
Pacotes Nuget utilizados:
  - Microsoft.AspNetCore.Authentication.JwtBearer
      https://www.nuget.org/packages/Microsoft.AspNetCore.Authentication.JwtBearer/3.1.7
  - Dapper
      https://www.nuget.org/packages/Dapper/2.0.35
  - Microsoft.Data.SqlClient
      https://www.nuget.org/packages/Microsoft.Data.SqlClient/2.0.0
	  
IDE:
  - Visual Studio Community 2019 (versão 16.7.2).