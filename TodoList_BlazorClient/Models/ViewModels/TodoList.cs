using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace TodoList_BlazorClient.Models.ViewModels
{
    [Table("TodoList")]
    public partial class TodoList_ViewModel
    {
        public TodoList_ViewModel()
        {
            TodoItems = new HashSet<TodoItem_ViewModel>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }

        [InverseProperty(nameof(TodoItem_ViewModel.List))]
        public virtual ICollection<TodoItem_ViewModel> TodoItems { get; set; }
    }
}
