﻿namespace EShop.Domain.Filters;

public interface IListFilter
{
    int Offset { get; set; }
    int Count { get; set; }
}