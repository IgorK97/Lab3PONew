using Npgsql;
using DAL;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace BLL.Services
{
    public class ReportService
    {
        public class OrdersByMonth
        {
            public int order_id { get; set; }
            public string CourierName { get; set; }
            public DateTime Date { get; set; }
        }
        public class ParResult 
        {
            public int order_id { get; set; }
            public int client_id { get; set; }
            public int courier_id { get; set; }
            public string client_full_name { get; set; }
            public string courier_full_name { get; set; }
            public DateTime order_date { get; set; }
        }

        public static List<OrdersByMonth> ExecuteSP(int month, int year, int ClientId)
        {

            //PizzaDeliveryContext dbContext = new PizzaDeliveryContext();
            //NpgsqlParameter param1 = new NpgsqlParameter("month", month);
            //NpgsqlParameter param2 = new NpgsqlParameter("year", year);

            //var result = dbContext.Database.SqlQuery<ParResult>("select * from _GetOrdersByMonthYear(@month, @year)", new object[] { param1, param2 }).ToList();
            ////var result = dbContext.Database.SqlQuery("select * from _GetOrdersByMonthYear(@month, @year)", new object[] { param1, param2 }).ToList();
            //var data = result.Where(i => i.client_id == ClientId).Select(j =>
            //new OrdersByMonth { order_id = j.order_id, CourierName = j.courier_full_name, Date = j.order_date }).OrderByDescending(c => c.Date).ToList();

            //return data;
            List<OrdersByMonth> r = new List<OrdersByMonth>();
            return r;

        }

        public class ReportData
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
        }

        public static List<ReportData> ReportPizzas(int ingredientId)
        {

            PizzaDeliveryContext dbContext = new PizzaDeliveryContext();

            var request = dbContext.Pizzas.Where(p => p.Ingredients.Any(i => i.Id == ingredientId))
                .Select(p => new ReportData
                {
                    Id = p.Id,
                    Name = p.Name,
                    Description = p.Description

                }).ToList();
            return request;
        }
    }
}
