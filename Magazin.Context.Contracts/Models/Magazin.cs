﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Svyaznoi.Context.Contracts.Models
{
    /// <summary>
    /// Наименование
    /// </summary>
    public class Magazin : BaseEntyty
    {
        /// <summary>
        /// Наименование
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Описание
        /// </summary>
        public string Address { get; set; } = string.Empty;

        public string City { get; set; } = string.Empty;

    }
}
