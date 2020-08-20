using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace staut_ClassLibrary
{
	public class SetTitleDbContext : DbContext
	{
		public DbSet<SetTitle> SetTitles { get; set; }
		public DbSet<StartupProg> StartupProgs { get; set; }
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlite("Data Source=setTitle.db");
		}
	}
	public class SetTitle
	{
		public int SetTitleId { get; set; }
		public string TitleName { get; set; }
		public List<StartupProg> StartupProgs { get; } = new List<StartupProg>();
	}

	
	public class StartupProg
	{
		public int StartupProgId { get; set; }
		public string StartupProgName { get; set; }
		public string StartupProgPath { get; set; } 
		public int SetTilteId { get; set; }
		public SetTitle SetTitle { get; set; }
	}
}
