using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Homework_SkillTree.ViewModel
{
	public class CategoryViewModel
	{
		public IList<CategoryInputViewModel> CategoryListViewModel { get; set; }
		public CategoryInputViewModel ListViewModel { get; set;}
	}

	public enum MoneyEnum
	{
		[Display(Name = "支出")]
		Expend,
		[Display(Name ="收入")]
		Income
	}
	public class CategoryInputViewModel
	{
		[Required(ErrorMessage ="請輸入類別!!!")]
		[Display(Name = "類別")]
		public MoneyEnum Categories { get; set; }
		[Required(ErrorMessage ="請輸入金額!!!")]
		[Range(0,int.MaxValue)]
		[Display(Name = "金額")]
		public int Money { get; set; }
		[Required]
		[Display(Name = "日期")]
		[DataType(DataType.Date)]
		[DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}",ApplyFormatInEditMode =true)]
		public DateTime Date { get; set; }
		[Required(ErrorMessage ="請輸入備註!!!")]
		[StringLength(100)]
		[Display(Name = "備註")]
		public string Note { get; set; }
	}
}