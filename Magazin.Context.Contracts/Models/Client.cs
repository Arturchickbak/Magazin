using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Svyaznoi.Context.Contracts.Models
{
    public class Client : BaseEntyty
    {
        /// <summary>
        /// Наименование
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Номер телефона
        /// </summary>
        public int Number { get; set; }

        /// <summary>
        /// Электронная почта
        /// </summary>
        public string Email { get; set; } = string.Empty;

        public int Card {  get; set; }
    }
}
