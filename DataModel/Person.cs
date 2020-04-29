using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace CodeFirst.DataModel
{
    public class Person
    {
        /// <summary>
        /// Gets or sets the id of a person. This field represents the Id column in the database and is the primary key.
        /// </summary>
        [Key]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the person and represents the Name column in the people table in the database.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets an instance of address. The address is stored in another table. See Address.cs to see how the foreign key has been configured.
        /// </summary>
        public Address Address { get; set; }
    }
}
