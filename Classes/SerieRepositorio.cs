
using System;
using System.Collections.Generic;
using DIO.Interfaces;

namespace DIO.Serie
{
  public class SerieRepositorio : IRepositorio<Serie>
  {
    private List<Serie> listaSerie = new List<Serie>();

    public SerieRepositorio()
    {
    }

    public void Atualiza(int id, Serie objeto)
    {
      listaSerie[id] = objeto;
    }

    public void Exclui(int id)
    {
      listaSerie[id].Excluir();
    }

    public void Insere(Serie objeto)
    {
      listaSerie.Add(objeto);
    }

    public List<Serie> Lista()
    {
      return listaSerie;
    }

    public int ProximoId()
    {
      return listaSerie.Count;
    }

    public Serie RetornaPorId(int id)
    {
      return listaSerie[id];
    }

    System.Collections.Generic.List<Serie> IRepositorio<Serie>.Lista()
    {
      throw new NotImplementedException();
    }
  }
}