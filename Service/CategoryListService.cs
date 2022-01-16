using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Homework_SkillTree.ViewModel;
using Homework_SkillTree.Models;
using X.PagedList;

namespace Homework_SkillTree.Service
{
	public class CategoryListService
	{
		private readonly Model1 _model1;
		private const int PageSize = 10;
		public CategoryListService()
		{
			this._model1 = new Model1();
		}

		
		/// <summary>
		/// 取得所有的紀錄
		/// </summary>
		/// <returns></returns>
		public IPagedList<CategoryInputViewModel> GetCategoryViewModel(int? year, int? month, int? page)
		{
			if (_model1.AccountBook == null)
				return null;

			if (page < 1)
				return null;

			var accountBooks = new List<AccountBook>();

			if (year != null && month != null)
			{
				accountBooks = _model1.AccountBook.Where(x => x.Dateee.Year == year && x.Dateee.Month == month).ToList();
			}
			else
			{
				accountBooks = _model1.AccountBook.ToList();
			}
			
			return accountBooks.Select(x => new CategoryInputViewModel()
			{
				Categories = (MoneyEnum)x.Categoryyy,
				Date = x.Dateee,
				Money = x.Amounttt,
				Note = x.Remarkkk
			}).OrderByDescending(x => x.Date).ToPagedList(page ?? 1, PageSize);
			
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
		
		}

		public void Save()
		{
			_model1.SaveChanges();
		}
	}
}