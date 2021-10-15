### Sumário

**Aula 01 - Primeiros passos com exceções**

- Como funciona a pilha de chamadas (CallStack) no .NET;
- Propagar erros com retorno de métodos não é correto;
- Podemos usar as exceções do .NET;
- Para tratar exceções do .NET, basta usar os blocos try/catch;
- As exceções são representadas por objetos e duas propriedades importantes são a Message e StackTrace.

**Aula 02 - Tratamento de exceções**

- O bloco try pode acompanhar vários blocos catch;
- A CLR visita os blocos catch em ordem, de cima para baixo. Por esta razão, os tipos de exceção mais específicos devem estar no começo;
- A instrução throw;, dentro de um bloco catch, relança uma exceção.

**Aula 03 - ArgumentException ParamName e nameof**

- Campos somente leitura com o modificador readonly;
- Propriedades somente leitura, com omissão do setter;
- O operador nameof();
- A classe de exceção ArgumentException, seus construtores e propriedades;

**Aula 04 - Criando exceções ricas**

- Convenções de nomeação de exceções;
- Construtores comuns de exceções;
- Como criar uma exceção mais rica.

**Aula 05 - StachTrace e InnerException**

- As diferenças entre throw; e throw ex;
- Como a CLR preenche a propriedade StackTrace;
- O padrão de inner exceptions;
- O terceiro construtor que as exceções devem ter: (string mensagem, Exception excecaoInterna);

**Aula 06 - Finally e using**

- O bloco finally;
- Não é obrigatório o bloco catch quando temos um finally;
- Como é usado o bloco using e como ele funciona;
- A interface IDisposable.

