# dotnet-secrets-example
Projeto para demonstrar o uso da ferramenta dotnet-secrets

A documentação da ferramenta pode ser encontrada em: https://docs.microsoft.com/pt-br/aspnet/core/security/app-secrets?view=aspnetcore-3.1&tabs=windows


## Inicialização

- Inicialize a aplicação com um `dotnet run` dentro do projeto da api
- Em seu navegador, vá até `https://localhost:5001/api/secretMessage`

Você deverá receber um resultado parecido com:

```json
{"secretMessage":null}
```

### Hello World :)

- Desligue a aplicação, se ainda estiver rodando
- Dentro da pasta da api, execute: `dotnet user-secrets set "SECRET_MESSAGE" "Hello World"`
- Reinicie a Api e navegue novamente para `https://localhost:5001/api/secretMessage`

Você deverá receber uma resultado parecido com:

```json
{"secretMessage":"Hello World"}
```



