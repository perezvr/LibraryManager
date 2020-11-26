using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LibraryManager.MVC.Models
{
    public abstract class ModelBase
    {
        public int Id { get; protected set; }

        public bool Validate()
        {
            var vContext = new ValidationContext(this);
            var results = new List<ValidationResult>();

            if (!Validator.TryValidateObject(this, vContext, results, true))
                throw new ArgumentException(results[0].ErrorMessage);

            return true;
        }

    }
}
