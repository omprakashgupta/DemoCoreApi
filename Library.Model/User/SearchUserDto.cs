using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Model
{
	public class SearchUserDto
	{
		[Required(AllowEmptyStrings = false,ErrorMessage = "Name is required")]
		public string Name { get; set; } = string.Empty;
		public int Age{ get; set; } = 0;
		public string Gender { get; set; } = string.Empty;

	}
}
