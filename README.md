## Executando o projeto

Clone o projeto inteiro

```bash
  git clone https://github.com/limup/capta-gestao-cliente.git
```

Acesse a pasta

```bash
  cd MerchanCountries
```

Execute o Docker Compose na raiz do projeto

```bash
  docker-compose build
```

Após, Execute o container

```bash
  docker-compose up -d
```

Stop

```bash
  docker-compose stop
```

## Reference

#### Página Inicial

```http
  http://localhost:8085
```

#### Api

```http
  http://localhost:5224/api/MerchanCountries
```
ou

```http
  http://localhost:8084/merchancountriesangular
```

#### Monog Express

```http
  http://localhost:8081/
```