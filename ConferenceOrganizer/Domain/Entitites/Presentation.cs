﻿using Domain.Entitites.Abstractions;

namespace Domain.Entitites
{
    public class Presentation : EntityBase
    {
        public string Presenter { get; set; }
        public string Title { get; set; }
    }
}