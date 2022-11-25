[![Commit](https://img.shields.io/github/commit-activity/m/limup/MerchanCountries)](https://img.shields.io/github/commit-activity/y/limup/MerchanCountries)
[![Size](https://img.shields.io/github/repo-size/limup/MerchanCountries)](https://img.shields.io/github/repo-size/limup/MerchanCountries)
[![limup](https://img.shields.io/github/followers/limup?style=plastic)](https://img.shields.io/github/followers/limup?style=social)

# Projeto 👋
Este projeto tem como objetivo oferecer open source aos devs iniciantes para entender a estrutura de códigos aplicando SOLID, Design Pattern e outras práticas de programação.

# Fork e contribuições
Contribua para o desenvolvimento do sistema, realize o fork.

# Tecnologias
[![My Skills](https://skillicons.dev/icons?i=cs,dotnet,angular,docker,mongodb)](https://skillicons.dev)

## Executando o projeto

Clone o projeto inteiro

```bash
  git clone https://github.com/limup/MerchanCountries.git
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

#### Monog Express

```http
  http://localhost:8081/
```

# TO DO

### Task

- [ ] Testes unitários
- [x] Publish no Docker

- [x] Serviço do linux Daeon (https://rafaelcruz.azurewebsites.net/2020/07/07/construindo-um-windows-service-ou-linux-daemon-com-worker-service-net-core-parte-2/)
	- [x] Armazenamento em Cache - MongoDB
	
	- [x] Consulta Paises (HttpClient)
		- [x] https://restcountries.com/v3.1/all
		- [x] Nome do País, Sigla, Moedas (sigla), Bandeira e Blocos Econômicos), População, Timezone, Moedas (currencies), Línguas (languages), Capital, Blocos econômicos (Regional Blocks) e Países que fazem fronteira (bordering countries);

- [x] WebAPI para disponibilizar para outros canais
	- [x] Acessar o MongoDB com os paices armazenados

- Front Angular
	- [ ] TailwindCSS
	- [x] Exibir Nome do País, Sigla, Moedas (sigla), Bandeira e Blocos 
Econômicos)
	- [x] Ao clicar na Lupa/Mais detalhes exibir um frame: População, Timezone, Moedas (currencies), Línguas (languages), Capital, Blocos econômicos (Regional Blocks) e Países que fazem fronteira (bordering countries);
	- [x] Exibir Rotas Comerciais

-----------------------------------------------

- [x] Alterar a worker para 1h
- [x] Retirar os menus no Angular
- [ ] Aplicar a Tailwind

