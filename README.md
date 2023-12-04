# Proposta de Sistema Escolar
Sistema escolar feito pelo grupo CodeTree ☘️
- Beatriz Bezerra [GitHub](https://github.com/Trizzzb), 
- Pedro Silva [GitHub](https://github.com/PedroHSilva1),
- Patrícia Santos [GitHub](https://github.com/PatriciaNFS).

## 1. Introdução 📕
 O código fornece um sistema de gerenciamento escolar básico, permitindo o cadastro de alunos e funcionários, controle de presença, gestão de notas e um sistema de login para diferentes tipos de usuários. A seguir, detalharemos cada componente do código.

## 2.	Objetivos e escopo do projeto 🏆
 Este trabalho tem por objetivo relatar o processo de desenvolvimento do Sistema de Gestão Escolar para Escolas da Região Metropolitana do Recife. Ele foi concebido para a informatização das rotinas administrativas da referida escola, entre eles: matrícula de alunos, acompanhamento de estágios e gerenciamento de professores e demais funcionários com funções relevantes para utilizá-lo. O sistema foi desenvolvido utilizando-se da linguagem C#.

### 2.1 Objetivo 🎯
 O objetivo principal deste sistema visa disponibilizar um cadastro atualizado dos alunos, professores e disciplinas , assim como, agilizar o processo de matricula, possibilitando um acompanhamento preciso de toda vida acadêmica dos alunos. A aplicação visa melhorar a eficiência e agilidade das gestão escola, proporcionando uma forma organizada e confiável de gerir os dados relacionados aos alunos, professores e funcionários.

### 2.2 Escopo do projeto 🎯
 A aplicação do sistema de gestão escolar em C# permitirá o cadastro de novos alunos com informações como nome, endereço, telefone, e CPF, e de forma confortável para o aluno que possuam um nome social de forma a serem tratados apenas por este. Possibilitará o cadastro de professores e funcionários, contendo dados como nome, cargo, telefone, e CPF. A aplicação foi trabalhada de maneira que um sistema de autenticação seguro garanta que apenas usuários autorizados (no caso, administradores) tenham acesso à plataforma. E as informações dos usuários serão armazenadas de forma criptografada para proteção contra ameaças de segurança.

## 3.	Requisitos do sistema, incluindo requisitos funcionais e não funcionais 
 Esses requisitos descrevem o que a aplicação deve fazer e como ela deve se comportar. Abaixo, listo alguns exemplos de requisitos funcionais e não funcionais do projeto:

### 3.1	Requisitos Funcionais: 💻
 Requisitos técnicos para o software que compõe o sistema descreve as ações que o sistema deve ser capaz de executar.

| Código | Identificação | Classificação | Objetivo |
|--- |--- |--- |--- |
| RF01 | Cadastrar usuários | Essencial[^1]. | Permitir que novos usuários sejam registrados no sistema |
| RF02 | Autenticar usuários | Essencial | Permitir que usuários registrados acessem o sistema |
| RF03 | Sair do sistema | Essencial | Encerrar a seção de um usuário no sistema |
| RF04 | Visualizar matérias | Importante[^2]. | Permitir que usuários consultem a lista de matérias |
| RF05 | Matrícula do aluno | Importante | Permitir que alunos se matriculem nas turmas desejadas |
| RF06 | Consultar rendimento do aluno | Importante | Permitir que professores verifiquem o desempenho dos alunos |


### 3.2 Requisitos Não funcionais  📊
 Requisitos técnicos do software que compõe o sistema descrevem atributos que o sistema deve ter ou restrições dentro das quais o sistema deve operar.

 | Código | Identificação | Classificação | Objetivo |
 |--- |--- |--- |--- |
 | RNF01 | Disponibilidade | Essencial[^1]. | Assegurar que o sistema esteja acessível e funcional a maior parte do tempo |
 | RNF02 | Confidencialidade | Essencial | Proteger as informações sensíveis conta acesso não autorizado |
 | RNF03 | Autenticação | Essencial | Verificar a identidade dos usuários que acessam o sistema |
 | RNF04 | Integridade dos Dados | Essencial | Manter a precisão e constância dos dados armazenados |
 | RNF05 | Backup de Dados | Essencial | Garantir a recuperação de dados em caso de perda ou corrupção. |
 | RNF06 | Notificações | Essencial | Informar usuários sobre eventos importantes ou ações relevantes no sistema |
 | RNF07 | Simplicidade | Essencial | Garantir que a interface e as funcionalidades sejam intuitivas e fácies de usar |
 | RNF08 | Responsividade | Essencial | Garantir que o sistema responda rapidamente às solicitações dos usuários |
 | RNF09 | Acessibilidade | Essencial | Garantir que o sistema seja acessível a usuários com diferentes necessidade e habilidades |
 | RNF10 | LOG’s (Registros) | Desejável[^3]. | Registrar eventos importantes para fins de auditoria, solução de problemas e segurança |
 | RNF11 | Extensibilidade | Essencial | Facilitar a adição de novas funcionalidades ou integrações no futuro |
 | RNF012 | Adaptabilidade | Essencial | Permitir que o sistema se ajuste a diferentes ambientes e requisitos |

[^1]: **Essencial**: trata-se de um requisito fundamental para que o sistema entre em funcionamento. Requisitos essenciais são requisitos indispensáveis e devem ser implementados desde as fases iniciais da implantação do sistema.

[^2]: **Importante**: refere-se a um requisito que permite o funcionamento do sistema, porém de maneira não totalmente satisfatória. A implementação de requisitos importantes deve ocorrer o mais rapidamente possível, é possível implantar parte do sistema mesmo assim.

[^3]: **Desejável**: diz respeito a um requisito cuja ausência não compromete as funcionalidades básicas do sistema. Dem outras palavras, o sistema pode operar de maneira satisfatória mesmo sem a implementação dos requisitos desejáveis. Estes requisitos podem ser abordados em fases posteriores da implantação sem prejudicar o funcionamento global do sistema.







