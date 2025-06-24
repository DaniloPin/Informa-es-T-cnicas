Precisei criar um sistema para uma loja de software. Cada produto digital tem um nome, um preço e detalhes técnicos, como o tamanho do arquivo e o sistema operacional compatível. Esses detalhes técnicos podem variar bastante e, por isso, fazem mais sentido em uma estrutura separada — uma classe só para isso.

Criei:

- Uma classe InformacaoTecnica com:
    - Propriedades TamanhoMB e SistemaOperacional.

- Uma classe ProdutoDigital com:
    - Propriedades Nome, Preco e InfoTecnica (do tipo InformacaoTecnica).
    - Um método ExibirDetalhes() para mostrar tudo na tela.
