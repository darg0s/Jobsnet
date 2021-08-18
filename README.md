
# Comandos iniciais:
``` bash
  mkdir projeto_gama_final
  cd projeto_gama_final
  dotnet new webapi
```

# Comandos git:
``` bash
git init
git add .
git commit -m "Iniciando projeto"
code .gitignore # gerei o conteúdo para ignorar como (Windows, Linux, Mac, DotnetCore, VisualStudioCore) no link: https://www.toptal.com/developers/gitignore

git remote add origin git@github.com:Diogenes-Alberto/Jobsnet.git
git branch -M main
git push -u origin main


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
dotnet ef migrations add vagaAdd
dotnet ef database update
```

# Instalação do code generator
``` bash
dotnet tool install -g dotnet-aspnet-codegenerator
```

# Gerando o scaffold de Profissoes
``` bash
dotnet aspnet-codegenerator controller -name VagasController -m Vaga -dc DbContexto --relativeFolderPath Controllers

dotnet aspnet-codegenerator controller -name MarcasController -m Marca -dc DbContexto --relativeFolderPath Controllers

```
