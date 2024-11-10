using System;

public class Contatos{
    private string nome {  get; set; }
    private int telefone {  get; set; }
    private string email {  get; set; }

    public Contatos(string
         nome, int telefone, string email){
        this.nome = nome;
        this.telefone = telefone;
        this.email = email;
	}
    public override string ToString() { return $"Nome: {nome}, Telefone:{telefone}, Email: {email}"}
}
