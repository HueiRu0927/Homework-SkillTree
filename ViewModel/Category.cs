using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Homework_SkillTree.Models
{
	//public class CategoryListViewModel
	//	public IList<CategoryInputVM> CategoriesInputVM { get; set; }
	//}

	public enum MoneyEnum
	{
		支出,
		收入
	}
	public class CategoryInputViewModel
	{
		[Display(Name = "類別")]
		public MoneyEnum Categories { get; set; }
		[Display(Name = "金額")]
		public int Money { get; set; }
		[Display(Name = "日期")]
		[DataType(DataType.Date)]
		public DateTime Date { get; set; }
		[Display(Name = "備註")]
		public string Note { get; set; }
	}
}