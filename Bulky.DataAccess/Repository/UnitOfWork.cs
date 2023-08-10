﻿	using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BulkyBook.DataAccess.Repository;
using BulkyBook.DataAccess.Data;

namespace BulkyBook.DataAccess.Repository.IRepository
{
	public class UnitOfWork : IUnitOfWork
	{
		private ApplicationDbContext _db;
		public ICategoryRepository Category { get; private set; }
		public IProductRepository Product { get; private set; }
		public UnitOfWork(ApplicationDbContext db)
		{
			_db = db;
			Category = new CategoryRepository(_db);
			Product = new ProductRepository(_db);
			}
		
		public void Save()
		{
			_db.SaveChanges();
		}
	}
}