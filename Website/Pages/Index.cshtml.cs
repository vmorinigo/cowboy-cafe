using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CowboyCafe.Data;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        /// <summary>
        /// The item to display on the index page 
        /// </summary>
        public IEnumerable<IOrderItem> Items { get; protected set; }

        /// <summary>
        /// Gets and sets the search terms
        /// </summary>
        public string SearchTerms { get; set; } = " ";

        /// <summary>
        /// Gets and sets the Types filters
        /// </summary>
        [BindProperty]
        public string[] Types { get; set; }


        /// <summary>
        /// Gets and sets the Price minimium rating
        /// </summary>
        public double? PriceMin { get; set; }

        /// <summary>
        /// Gets and sets the Price maximum rating
        /// </summary>
        [BindProperty]
        public double? PriceMax { get; set; }

        /// <summary>
        /// Gets and sets the Calories maximum rating
        /// </summary>
        public uint? CaloriesMax { get; set; }

        /// <summary>
        /// Gets and sets the Calories minimium rating
        /// </summary>
        public uint? CaloriesMin { get; set; }

        /// <summary>
        /// Does the response initialization for incoming GET requests
        /// </summary>
        public void OnGet(double? PriceMin, double? PriceMax, uint? CaloriesMin, uint? CaloriesMax)
        {
            this.PriceMin = PriceMin;
            this.PriceMax = PriceMax;
            this.CaloriesMin = CaloriesMin;
            this.CaloriesMax = CaloriesMax;
            SearchTerms = Request.Query["SearchTerms"];
            Types = Request.Query["Types"];
            Items = Menu.Search(SearchTerms);
            Items = Menu.FilterByType(Items, Types);
            Items = Menu.FilterByPrice(Items, PriceMin, PriceMax);
            Items = Menu.FilterByCalories(Items, CaloriesMin, CaloriesMax);
        }
    }
}
