# 🛒 LojaMVC

Uma aplicação web de e-commerce desenvolvida no padrão **ASP.NET Core MVC**, focando em boas práticas de arquitetura, código limpo e cobertura total de regras de negócio através de **Desenvolvimento Orientado a Testes (TDD)**.

---

## 📌 Sobre o Projeto

O **LojaMVC** foi construído com o objetivo de simular a estrutura e os fluxos essenciais de uma loja virtual (gestão de produtos, carrinho de compras, processamento de pedidos e regras de validação), garantindo alta confiabilidade e facilidade de manutenção por meio do ciclo **Red-Green-Refactor** do TDD.

### 🧪 Diferencial: Desenvolvimento com TDD

Toda a camada de negócio do projeto foi guiada por testes automatizados antes da implementação final das funcionalidades:
1. 🔴 **Red**: Escrever um teste que falha para especificar o comportamento esperado.
2. 🟢 **Green**: Escrever o código mínimo necessário para fazer o teste passar.
3. 🔵 **Refactor**: Melhora da estrutura e qualidade do código mantendo a suite de testes verde.

---

## 🚀 Tecnologias e Ferramentas

* **Linguagem & Framework**: C# / .NET (ASP.NET Core MVC)
* **Banco de Dados & ORM**: Entity Framework Core / SQL Server (ou LocalDB)
* **Frameworks de Teste**: xUnit / NUnit + Moq + FluentAssertions
* **Interface**: Razor Views, HTML5, CSS3, Bootstrap
* **Servidor Local**: IIS Express / Kestrel

---

## 📂 Estrutura do Repositório

```text
MVCeTeste/
├── LojaMVC/                  # Projeto Principal (MVC)
│   ├── Controllers/          # Controladores das rotas e requisições
│   ├── Models/               # Entidades de Domínio e ViewModels
│   ├── Views/                # Páginas Razor (HTML/CSS)
│   ├── Services/             # Regras de Negócio e Serviços
│   └── Repositories/         # Acesso a Dados e Contexto do EF
│
└── LojaMVC.Tests/            # Suíte de Testes Automatizados (TDD)
    ├── Controllers/          # Testes de unidade dos Controllers
    ├── Services/             # Testes das Regras de Negócio
    └── Builders/             # Data Builders/Mocks para testes
