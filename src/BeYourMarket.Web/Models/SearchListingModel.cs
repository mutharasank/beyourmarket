﻿using BeYourMarket.Model.Models;
using BeYourMarket.Web.Models.Grids;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeYourMarket.Web.Models
{
    public class SearchListingModel : SortViewModel
    {
        public int CategoryID { get; set; }

        public string SearchText { get; set; }

        public string Location { get; set; }

        public bool PhotoOnly { get; set; }

        public double? PriceFrom { get; set; }

        public double? PriceTo { get; set; }

        public List<MetaCategory> MetaCategories { get; set; }

        public List<ItemModel> Items { get; set; }

        public IPagedList<ItemModel> ItemsPageList { get; set; }

        public List<Category> Categories { get; set; }

        public List<Category> BreadCrumb { get; set; }

        public ListingModelGrid Grid { get; set; }
    }
}