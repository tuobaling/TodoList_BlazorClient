using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace TodoList_BlazorClient.Models.ViewModels
{
    [Table("TodoItem")]
    public partial class TodoItem_ViewModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string TaskName { get; set; }
        public int ListId { get; set; }

        [ForeignKey(nameof(ListId))]
        [InverseProperty(nameof(TodoList_ViewModel.TodoItems))]
        public virtual TodoList_ViewModel List { get; set; }
    }
}
