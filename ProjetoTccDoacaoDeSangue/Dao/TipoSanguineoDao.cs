using ProjetoTccDoacaoDeSangue.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjetoTccDoacaoDeSangue.Dao
{
    public class TipoSanguineoDao : DaoBase
    {
        public void Gravar(TipoSanguineo ObjTipoSanguineo)
        {
            banco.TipoSanguineos.Add(ObjTipoSanguineo);
            banco.SaveChanges();
        }

        public void Alterar(TipoSanguineo ObjTipoSanguineo)
        {
            var entry = banco.Entry(ObjTipoSanguineo);
            banco.Set<TipoSanguineo>().Attach(ObjTipoSanguineo);
            entry.State = EntityState.Modified;
            banco.SaveChanges();

        }

        public void Excluir(int id)
        {
            TipoSanguineo tipoSanguineo = Buscar(id);
            banco.TipoSanguineos.Remove(tipoSanguineo);
            banco.SaveChanges();

        }

        public IEnumerable<TipoSanguineo> Buscar()
        {
            return banco.TipoSanguineos.ToList();
        }

        public TipoSanguineo Buscar(int id)
        {
            return banco.TipoSanguineos.FirstOrDefault(a => a.SangueID == id);
        }
    }
}