﻿using Microsoft.EntityFrameworkCore;

namespace ToDoList.Models
{
	public class TestDbContext : ToDoListContext
	{
		public override DbSet<Item> Items { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder options)
		{
            options.UseMySql(@"Server=localhost;Port=8889;database=todolist_test;uid=root;pwd=root;");
		}
	}
}