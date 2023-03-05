Esse é um CRUD completo de cadastro de contatos utilizando ASP.NET MVC, C#, EF, HTML, CSS, JS e SQL Server.

Passo a passo para a inserção e manipulação do contato no sistema:

PRIMEIRO PASSO:

Aqui temos a tela inicial do sistema onde podemos visualizar o Layout Inicial juntamente com a opção de CONTATOS, que é a opção que será utilizada durante todo o processo.

![crud1](https://user-images.githubusercontent.com/106346422/222979664-40ee37c0-f08b-40fc-a721-d0daca8bb102.png)

SEGUNDO PASSO:

Na segunda etapa nós encontraremos a tela de cadastro vazia com um botão azul "Adicionar novo contato" para adicionar um novo contato. Após apertar esse botão os campos para adicionar o contato serão expostos, conforme as imagens abaixo. Podemos notar também que caso o usuário tente efetuar um cadastro com campos vazios ou preenchidos incorretamente o sistema informará o erro, possibilitando assim a correção do usuário.

![crud2-1](https://user-images.githubusercontent.com/106346422/222980362-6470c531-84a4-4396-9474-34d23cf4b501.png)
![crud3](https://user-images.githubusercontent.com/106346422/222980549-5fe25089-7a6a-410e-bacf-23873179923f.png)

TERCEIRO PASSO:

Nessa etapa, após entrar com os dados corretos no contato, apertamos o botão "Adicionar" e somos levados de volta para a página de contatos atualizada com o novo contato. Podemos notar também que nesse momento após uma consulta no SQL Server (select * from "Contatos") o contato já está disponível no Banco.

![crud5-1](https://user-images.githubusercontent.com/106346422/222980679-57f71259-0b25-4058-9781-6cf9ec7763c1.png)
![crud8](https://user-images.githubusercontent.com/106346422/222980929-a679b3be-2731-4676-8e9b-51b410265924.png)

ALTERAR O CONTATO:

Para alterar o contato basta seguir o mesmo procedimento do cadastro inicial.

DELETAR O CONTATO:

Avançando para deleção do contato, conforme a imagem abaixo, após apertar a opção DELETAR, seremos levados à uma nova página para confirmarmos se queremos realmente deletar o contato. Marcando a opção SIM, o contato será apagado e retornaremos para a página de contatos com uma mensagem de confirmação da deleção.

![crud6-1](https://user-images.githubusercontent.com/106346422/222981249-57137787-d4f6-4af1-a360-138460c5e108.png)
![crud7](https://user-images.githubusercontent.com/106346422/222981251-7a9478cf-097e-4fcf-9b9d-0dc6057eb3f7.png)
![crud9](https://user-images.githubusercontent.com/106346422/222981257-7f326a63-61d7-4b57-ac93-05d7fb9a04dd.png)



