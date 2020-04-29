using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace CodeFirst.DataModel
{
    public class Address
    {
        /// <summary>
        /// Gets or sets the id of an address. This field represents the Id column in the database and is the primary key.
        /// </summary>
        [Key]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the zipcode of the address and represents the Zipcode column in the addresses table in the database.
        /// </summary>
        [MaxLength(6)]
        public string Zipcode { get; set; }

        /// <summary>
        /// Gets or sets the city of the address and represents the city column in the addresses table in the database.
        /// </summary>
        [MaxLength(100)]
        public string City { get; set; }

        /// <summary>
        /// Gets or sets an instance the address belongs to. This class should contain a field with the same name+Id, in this case PersonId. 
        /// </summary>
        public Person Person { get; set; }

        /// <summary>
        /// Gets or sets the Guid of the person this address belongs to. The value to this field is set automatically by EntityFramework
        /// </summary>
        public Guid PersonId { get; set; }
    }
}
