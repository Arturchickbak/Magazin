using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Svyaznoi.Context.Contracts.Models
{
    public interface IContext
    {
        /// <summary>
        /// покупатель
        /// </summary>
        ICollection<Magazin> Magazins { get; }
        /// <summary>
        /// накладная
        /// </summary>
        ICollection<Client> Clients { get; }
        /// <summary>
        /// товар
        /// </summary>
        ICollection<Tovar> Tovars { get; }
        /// <summary>
        /// поставищик
        /// </summary>
        ICollection<Postavshik> Postavshiks { get; }
        /// <summary>
        /// ведомость
        /// </summary>

        void SaveChanges();
    }
}
