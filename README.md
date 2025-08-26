# DesignPatterns

# Livro: Padrões de Projeto (Design Patterns)  
## Soluções reutilizáveis de software orientado a objetos  

**Autores:**  
- Erich Gamma  
- Richard Helm  
- Ralph Johnson  
- John Vlissides  

---

### Introdução  

Um **Padrão de Projeto** descreve uma **solução comprovada** para um **problema recorrente** e conhecido no desenvolvimento de software orientado a objetos.  

Os padrões ajudam a:  
- Reutilizar soluções testadas em diferentes contextos.  
- Melhorar a comunicação entre desenvolvedores, criando um vocabulário comum.  
- Tornar sistemas mais flexíveis e de fácil manutenção.  

Cada padrão responde a três perguntas principais:  
1. **Qual problema resolve?**  
2. **Qual solução propõe?**  
3. **Quais são as consequências de aplicá-lo?** 

# Padrões Estruturais GoF

Os padrões estruturais explicam como montar objetos e classes em estruturas maiores, mas ainda mantendo essas estruturas flexíveis e eficientes.  

🔹 Eles se concentram em **como as classes herdam umas das outras** e **como são compostas de outras classes**.

---

## Lista de Padrões Estruturais GoF

1. Adapter  
2. Bridge  
3. Composite  
4. Decorator  
5. Facade  
6. Flyweight  
7. Proxy  

---

## Classificação dos padrões estruturais GoF por escopo

| Escopo | Padrões de Projeto |
|--------|---------------------|
| Classe | Adapter (class)     |
| Objeto | Adapter (object), Bridge, Composite, Decorator, Facade, Flyweight, Proxy |

---

## Metsker - Classificação dos padrões estruturais GoF

| Intenção        | Padrão                                      |
|-----------------|---------------------------------------------|
| Interfaces      | Adapter, Bridge, Composite, Facade          |
| Responsabilidade| Proxy, Flyweight                            |
| Construção      | -                                           |
| Operações       | -                                           |
| Extensões       | Decorator                                   |

---

# Criando Projeto Console (.NET)

No **Visual Studio Code** (Windows, Mac e Linux):

- **Criar projeto**
  ```bash
  dotnet new console
  dotnet new console -o <nomeProjeto>

  # Seção 2: Fundamentos  

## Classes e Objetos  

---

## Acoplamento  

Acoplamento é o nível de dependência/conhecimento que pode existir entre os módulos/classes do sistema.  

Existem dois tipos de acoplamento:  
1. Acoplamento Forte  
2. Acoplamento Fraco  

**Vantagens do acoplamento fraco:**  
- Alterações em módulos/classes não quebram outros módulos/classes;  
- A realização de testes é facilitada;  
- A manutenção do código é mais fácil;  
- Fica menos afetado por alterações em outras classes/módulos.  

---

## Interfaces  

Uma **Interface** é um tipo de classe que contém apenas as assinaturas de métodos, propriedades, eventos e indexadores, e todos os membros são **públicos e abstratos**.  

Uma interface funciona como um contrato entre si e qualquer classe que a implemente.  

```csharp
public interface ITeste
{
    void Imprimir();
}

## Características da Interface  

- Não contém implementação;  
- Os membros são públicos e abstratos;  
- Não pode ser instanciada;  
- Não contém um construtor nem campos/atributos;  
- As classes que herdam a interface têm que implementar o contrato.  

---

## Vantagens  

- Manutenibilidade;  
- Extensibilidade;  
- Testes facilitados.  

📌 Regra de ouro: programe para uma interface e não para uma implementação.  

---

## Os 4 Pilares da Programação Orientada a Objetos  

### 1. Encapsulamento  

- Ocultar membros de uma classe do acesso exterior usando modificadores de acesso.  
- Também chamado de *information hiding*.  

**Modificadores de acesso em C#:**  
- `public` – acesso por qualquer código;  
- `private` – acesso somente dentro da classe;  
- `protected` – acesso na mesma classe ou em classes derivadas;  
- `internal` – acesso no mesmo assembly.  

---

### 2. Abstração  

- Reduz a complexidade escondendo detalhes desnecessários.  
- Identifica apenas as características essenciais de um objeto.  

**Vantagens da abstração:**  
- Simplifica o modelo do domínio;  
- Oculta detalhes irrelevantes;  
- Ajuda a particionar o programa em conceitos independentes;  
- Evita duplicação e aumenta reuso.  

**Tabela comparativa: Abstração x Encapsulamento**  

|                | **Abstração** | **Encapsulamento** |
|----------------|----------------|--------------------|
| **Uso**        | Resolve problemas no nível de design | Resolve problemas no nível de implementação |
| **Foco**       | O que o objeto faz | Como o objeto faz |
| **Implementação** | Interfaces e classes abstratas | Modificadores de acesso |
| **Objetivo**   | Define o que deve ser feito | Controla como é feito |

---

### 3. Herança  

Permite que uma classe base compartilhe membros com classes derivadas.  

```csharp
class ClasseDerivada : ClasseBase
{
}

# Seção 3: Padrão Adapter  

## Definição  

- Adapta uma interface em outra de acordo com a expectativa do cliente.  
- Permite a colaboração de objetos com interfaces incompatíveis.  
- Conhecido como **Invólucro** (*Wrapper*).  

---

## Intenção  

- Converter a interface de uma classe em outra;  
- Envolver (*Wrap*) uma classe existente com uma nova interface;  
- Introduzir um componente **legado** em um novo sistema (tornando as interfaces compatíveis).  

---

## Exemplo: Plataforma .NET - ADO.NET  

O objeto **DataAdapter** funciona como uma ponte entre os objetos **DataSet** e a **fonte de dados**.  

---

## Exemplo de Uso  

- Quando um objeto precisa usar uma classe existente com uma interface incompatível;  
- Quando você deseja criar uma classe reutilizável que coopere com classes que não possuam interfaces compatíveis.  

---

## Vantagens  

- Aumenta a reutilização do código;  
- Permite usar código entre plataformas diferentes;  
- Permite a interação de dois ou mais objetos incompatíveis.  

---

## Desvantagens  

- A complexidade geral do código aumenta porque é necessário introduzir um conjunto de novas interfaces e classes.  

