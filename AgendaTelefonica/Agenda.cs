using System;
using Contatos;

public class Agenda
{
	private Contatos listaContatos = new ArrayList();
	public Agenda()
	{
	}
	public void  cadastrarContato(Contatos contatos)
	{
		listaContatos.Add(contatos);

	}
	 public void removerContato(Contatos contatos)
	{
		listaContatos.Remove(contatos);

	}
	public bool buscarContaos(Contatos contatos)
	{
		foreach(var contato in listaContatos)
		{
			if (contato.Equals(contatos))
			{
				return true;
				break
			}
			
		}
		return false;
	}

}
