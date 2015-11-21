﻿using System;

namespace Tekconf.DTO
{
    public class Conference
    {
        public int Id { get; set; }

        public string Slug { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public DateTime StartDate { get; set; }

    }
}
