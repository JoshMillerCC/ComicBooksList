﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_ComicBooksCharacters.Models
{
    public class ComicBook
    {
        public int ComicBookID { get; set; }
        public string ComicBookTitle { get; set; }
        public string ComicBookDescription { get; set; }
        public string ComicBookImage { get; set; }
    }
}
