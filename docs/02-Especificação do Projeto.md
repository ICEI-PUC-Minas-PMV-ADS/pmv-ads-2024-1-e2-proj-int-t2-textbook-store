# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>

Definição do problema e ideia de solução a partir da perspectiva do usuário. É composta pela definição do  diagrama de personas, histórias de usuários, requisitos funcionais e não funcionais além das restrições do projeto.

Apresente uma visão geral do que será abordado nesta parte do documento, enumerando as técnicas e/ou ferramentas utilizadas para realizar a especificações do projeto

## Personas

<img width="219" alt="auxiliar admi" src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t2-textbook-store/assets/129327473/f50b0d00-eb3b-400d-b264-f9d5b73fb09a">


**Nome:** Laura Martins

**Idade:** 33 anos

**Filiação:** João Martins Oliveira - 12 anos

**Ocupação:** Auxiliar Administrativa 

**Motivações:** Após conseguir uma bolsa para seu filho em uma escola particular, está em busca de livros usados por serem mais baratos.

**Frustrações:** Seu filho acabou de ingressar na nova escola e ainda não possuem contatos com outros pais para conseguirem livros usados.



<img width="250" alt="eco" src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t2-textbook-store/assets/129327473/937526ba-2c79-49f5-ab01-ace1fbc685cf">


**Nome:** Julio Pereira

**Idade:** 30 anos

**Filiação:** Alice Pereira - 12 anos

**Ocupação:** Ecologista 

**Motivações:** Engajado nas causas ambientais, acredita que a reutilização de livros contribui com a diminuição de lixo gerado.

**Frustrações:** No colégio em que sua filha estuda não possui uma feira de livros usados.



<img width="247" alt="adv" src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t2-textbook-store/assets/129327473/7721d3ae-2f71-4a0a-b824-d1d8e0f2661f">


**Nome:** Claudia Ribeiro

**Idade:** 38 anos

**Filiação:** Beatriz Ribeiro  - 15 anos

**Ocupação:** Advogada 

**Motivações:** Vinda de uma família humilde, busca sempre uma maneira de ajudar os mais necessitados.

**Frustrações:** Possui uma vida muito atarefada com o trabalho e não encontra tempo para se encontrar com outros pais.



<img width="241" alt="corret" src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t2-textbook-store/assets/129327473/51fbf481-7d31-48d9-b73d-dd8349cdf9bb">


**Nome:** Fernando Ferreira

**Idade:** 40 anos

**Filiação:** Felipe Ferreira  - 17 anos

**Ocupação:** Corretor 

**Motivações:** Com os altos custos atuais para se manter o filho na escola, sempre busca vender e comprar livros usados.

**Frustrações:** Dificuldade em encontrar livros em bom estado para seu filho.


Enumere e detalhe as personas da sua solução. Para tanto, baseie-se tanto nos documentos disponibilizados na disciplina e/ou nos seguintes links:

> **Links Úteis**:
> - [Rock Content](https://rockcontent.com/blog/personas/)
> - [Hotmart](https://blog.hotmart.com/pt-br/como-criar-persona-negocio/)
> - [O que é persona?](https://resultadosdigitais.com.br/blog/persona-o-que-e/)
> - [Persona x Público-alvo](https://flammo.com.br/blog/persona-e-publico-alvo-qual-a-diferenca/)
> - [Mapa de Empatia](https://resultadosdigitais.com.br/blog/mapa-da-empatia/)
> - [Mapa de Stalkeholders](https://www.racecomunicacao.com.br/blog/como-fazer-o-mapeamento-de-stakeholders/)
>
Lembre-se que você deve ser enumerar e descrever precisamente e personalizada todos os clientes ideais que sua solução almeja.

## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Laura Martins / Fernando Ferreira | Encontrar livros de baixo custo | Que o orçamento não ultrapasse o meu limite disponível |
|Julio Pereira | Reutilizar livros escolares| Contribuir com o meio ambiente |
|Claudia Ribeiro | Vender os livros usados a baixo custo | Os pais que não conseguem comprar livros novos |
|Laura Martins / Fernando Ferreira | Vender os livros usados | Conseguir comprar os livros atuais  |
|Laura Martins / Julio Pereira / Fernando Ferreira | Encontrar livros bem conservados | Que seu/sua filho/filha tenha mais qualidade nos estudos |

Apresente aqui as histórias de usuário que são relevantes para o projeto de sua solução. As Histórias de Usuário consistem em uma ferramenta poderosa para a compreensão e elicitação dos requisitos funcionais e não funcionais da sua aplicação. Se possível, agrupe as histórias de usuário por contexto, para facilitar consultas recorrentes à essa parte do documento.

> **Links Úteis**:
> - [Histórias de usuários com exemplos e template](https://www.atlassian.com/br/agile/project-management/user-stories)
> - [Como escrever boas histórias de usuário (User Stories)](https://medium.com/vertice/como-escrever-boas-users-stories-hist%C3%B3rias-de-usu%C3%A1rios-b29c75043fac)
> - [User Stories: requisitos que humanos entendem](https://www.luiztools.com.br/post/user-stories-descricao-de-requisitos-que-humanos-entendem/)
> - [Histórias de Usuários: mais exemplos](https://www.reqview.com/doc/user-stories-example.html)
> - [9 Common User Story Mistakes](https://airfocus.com/blog/user-story-mistakes/)

## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| O sistema deve apresentar, na página principal, a funcionalidade de cadastro de usuários para que esses consigam criar e gerenciar seu perfil | ALTA | 
|RF-002| O sistema deve permitir que o usuário cadastre e gerencie livros para venda | ALTA |
|RF-003| O sistema deve oferecer uma funcionalidade de filtro/pesquisa para permitir ao usuário localizar livros por critérios diversos | ALTA |
|RF-004| O sistema deve ter um chat para conversação em cada livro para os usuários interagirem entre si | MÉDIA |
|RF-005| O sistema deve permitir que o usuário avalie os livros adquiridos | BAIXA |
|RF-006| O sistema deve permitir que o usuário avalie os vendedores para futuras vendas | BAIXA |
|RF-007| O sistema deve possuir opção de fazer login, sendo o login endereço de e-mail | ALTA |
|RF-008| O sistema deve permitir que o usuário recupere sua senha | ALTA |


### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| A aplicação deve ser responsiva | MÉDIA | 
|RNF-002| A aplicação deve processar requisições do usuário em no máximo 3s |  BAIXA | 

Com base nas Histórias de Usuário, enumere os requisitos da sua solução. Classifique esses requisitos em dois grupos:

- [Requisitos Funcionais
 (RF)](https://pt.wikipedia.org/wiki/Requisito_funcional):
 correspondem a uma funcionalidade que deve estar presente na
  plataforma (ex: cadastro de usuário).
- [Requisitos Não Funcionais
  (RNF)](https://pt.wikipedia.org/wiki/Requisito_n%C3%A3o_funcional):
  correspondem a uma característica técnica, seja de usabilidade,
  desempenho, confiabilidade, segurança ou outro (ex: suporte a
  dispositivos iOS e Android).
Lembre-se que cada requisito deve corresponder à uma e somente uma
característica alvo da sua solução. Além disso, certifique-se de que
todos os aspectos capturados nas Histórias de Usuário foram cobertos.

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O projeto deverá ser entregue até o final do semestre |
|02| Não pode ser desenvolvido um módulo de backend        |


Enumere as restrições à sua solução. Lembre-se de que as restrições geralmente limitam a solução candidata.

> **Links Úteis**:
> - [O que são Requisitos Funcionais e Requisitos Não Funcionais?](https://codificar.com.br/requisitos-funcionais-nao-funcionais/)
> - [O que são requisitos funcionais e requisitos não funcionais?](https://analisederequisitos.com.br/requisitos-funcionais-e-requisitos-nao-funcionais-o-que-sao/)

## Diagrama de Casos de Uso

O diagrama de casos de uso é o próximo passo após a elicitação de requisitos, que utiliza um modelo gráfico e uma tabela com as descrições sucintas dos casos de uso e dos atores. Ele contempla a fronteira do sistema e o detalhamento dos requisitos funcionais com a indicação dos atores, casos de uso e seus relacionamentos. 

As referências abaixo irão auxiliá-lo na geração do artefato “Diagrama de Casos de Uso”.

> **Links Úteis**:
> - [Criando Casos de Uso](https://www.ibm.com/docs/pt-br/elm/6.0?topic=requirements-creating-use-cases)
> - [Como Criar Diagrama de Caso de Uso: Tutorial Passo a Passo](https://gitmind.com/pt/fazer-diagrama-de-caso-uso.html/)
> - [Lucidchart](https://www.lucidchart.com/)
> - [Astah](https://astah.net/)
> - [Diagrams](https://app.diagrams.net/)
