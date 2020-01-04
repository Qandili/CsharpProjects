﻿using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace GAb.models
{
	class Lesson
	{
		[AutoIncrement, PrimaryKey]
		public int ID { set; get; }
		public String title { set; get; }

		public int teacherID { set; get; }
		public int optionID { set; get; }
	}
}
