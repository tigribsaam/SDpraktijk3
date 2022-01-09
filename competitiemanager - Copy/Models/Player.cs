using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace competitiemanager.Models
{
    public class Player
    {
        [Key, BindNever]
        public int PlayerId { get; set; }
        public string Name { get; set; }
        public int TeamId { get; set; }
    }
}
