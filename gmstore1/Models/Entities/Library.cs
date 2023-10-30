using PetaPoco;
using System;

namespace gmstore1.Models.Entities
{
    [TableName("Libraries")]
    [PrimaryKey("LibrariesId", AutoIncrement = true)]
    public class Library
    {
        [Column]
        private Guid LibrariesId { get; set; }
        [Column]
        private DateTime DateAdded { get; set; }
    }
}