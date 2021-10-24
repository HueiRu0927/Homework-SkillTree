using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Homework_SkillTree.ViewModel;
using Homework_SkillTree.Models;

namespace Homework_SkillTree.Service
{
	public class CategoryList
	{
		private readonly Model1 _model1;

		public CategoryList()
		{
			this._model1 = new Model1();
		}

		
		/// <summary>
		/// 取得所有的紀錄
		/// </summary>
		/// <returns></returns>
		public CategoryViewModel GetCategoryViewModel()
		{
			if (_model1.AccountBook == null)
			{
				return null;
			}

			var accountBooks = _model1.AccountBook.ToList();
			var categorylist = new CategoryViewModel();

			categorylist.CategoryListViewModel = accountBooks.Select(x => new CategoryInputViewModel()
			{
				Categories = (MoneyEnum)x.Categoryyy,
				Date = x.Dateee,
				Money = x.Amounttt,
				Note = x.Remarkkk
			}).OrderByDescending(x => x.Date).ToList();
			return categorylist;
		}

		/// <summary>
		/// 新增一筆紀錄
		/// </summary>
		/// <returns></returns>
		public void Add(CategoryInputViewModel inputViewModel)
		{
			_model1.AccountBook.Add(new AccountBook()
			{
				Id = Guid.NewGuid(),
				Amounttt = inputViewModel.Money,
				Categoryyy = (int)inputViewModel.Categories,
				Dateee = inputViewModel.Date,
				Remarkkk = inputViewModel.Note
			});
			_model1.SaveChanges();
		}
	}
}