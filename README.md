
# Comandos iniciais:
``` bash
  mkdir projeto_gama_final
  cd projeto_gama_final
  dotnet new webapi
```



# Componentes instalados:
``` bash
  dotnet add package Microsoft.EntityFrameworkCore --version 5.0.2
  dotnet add package Microsoft.EntityFrameworkCore.Tools --version 5.0.2
  dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 5.0.2
  dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design --version 5.0.2
```

# Comandos para migração:
``` bash
dotnet tool install --global dotnet-ef
dotnet ef migrations add ProfissaoAdd
dotnet ef migrations add EnderecoAdd
dotnet ef migrations add ContatoAdd
dotnet ef migrations add CandidatoAdd
dotnet ef database update
```

# Instalação do code generator
``` bash
dotnet tool install -g dotnet-aspnet-codegenerator
```

# Gerando o scaffold de Profissoes
``` bash
dotnet aspnet-codegenerator controller -name ProfissoesController -m Profissao -dc DbContexto --relativeFolderPath Controllers

dotnet aspnet-codegenerator controller -name MarcasController -m Marca -dc DbContexto --relativeFolderPath Controllers

```
