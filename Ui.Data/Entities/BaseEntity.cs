﻿using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel.DataAnnotations;

namespace Ui.Data.Entities
{
    public class BaseEntity
    {
        #region Properties

        [Key]
        public long Id { get; protected set; }

        [Required(ErrorMessage = "{0} is required.")]
        public DateTime DateCreated { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        public bool IsRemove { get; set; }

        #endregion
    }
}
