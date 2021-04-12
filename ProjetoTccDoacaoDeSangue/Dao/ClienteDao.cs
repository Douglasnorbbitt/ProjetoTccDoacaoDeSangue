using ProjetoTccDoacaoDeSangue.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjetoTccDoacaoDeSangue.Dao
{
    public class ClienteDao : DaoBase
    {
        public void Gravar(Cliente ObjCliente)
        {
            banco.Clientes.Add(ObjCliente);
            banco.SaveChanges();
        }

        public void Alterar(Cliente ObjCliente)
        {
            var entry = banco.Entry(ObjCliente);
            banco.Set<Cliente>().Attach(ObjCliente);
            entry.State = EntityState.Modified;
            banco.SaveChanges();

        }

        public void Excluir(int id)
        {
            Cliente cliente = Buscar(id);
            banco.Clientes.Remove(cliente);
            banco.SaveChanges();

        }

        public IEnumerable<Cliente> Buscar()
        {
            return banco.Clientes.ToList();
        }

        public Cliente Buscar(int id)
        {
            return banco.Clientes.FirstOrDefault(a => a.ClienteID == id);
        }
    }
}