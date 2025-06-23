public class InformacaoTecnica 
{
    public decimal TamanhoMB {  get; set; }
    public string SistemaOperacional { get; set; }
    public InformacaoTecnica(decimal tamanhoMB, string sistemaOperacional) {
        TamanhoMB = tamanhoMB;
        SistemaOperacional = sistemaOperacional;
    }
}