namespace RestServiceTutorial
{
    using System.Collections.Generic;
    using Microsoft.EntityFrameworkCore;

    class TodoDb : DbContext
    {
        public TodoDb(DbContextOptions<TodoDb> options)
        : base(options) { }

        public DbSet<Todo> Todos => Set<Todo>();
    }
}
