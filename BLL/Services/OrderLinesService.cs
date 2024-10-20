using DomainModel;
using DTO;
using DAL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BLL.Services.ReportService;

namespace BLL.Services
{
    public class OrderLinesService
    {
        private PizzaDeliveryContext db;
        public OrderLinesService()
        {
            db = new PizzaDeliveryContext();
        }

        public enum PizzaSize
        {
            Small = 1,
            Medium = 2,
            Big = 3
        };

        public List<OrderLineDto> GetAllOrderLines(int? OrderId)
        {
            return db.OrderLines.ToList().Where(i => i.OrdersId == OrderId).Select(i => new OrderLineDto(i)).ToList();
        }


        public OrderLineDto GetOrderLine(int Id)
        {
            return new OrderLineDto(db.OrderLines.Find(Id));
        }

        public void CreateOrderLine(OrderLineDto p)
        {
            List<Ingredient> addedingredients = new List<Ingredient>();
            foreach(var pId in p.addedingredientsId)
            {
                Ingredient ingr = db.Ingredients.Find(pId);
                addedingredients.Add(ingr);
            }
            db.OrderLines.Add(new OrderLine()
            {
                PositionPrice = p.position_price,
                OrdersId = p.ordersId,
                Custom = p.custom,
                Weight = p.weight,
                PizzaId = p.pizzaId,
                PizzaSizesId = p.pizza_sizesId,
                Quantity = p.quantity,
                Ingredients=addedingredients
            });
            Save();
            //db.order_lines.Attach(p);
        }

        public void UpdateOrderLine(OrderLineDto p)
        {
            List<Ingredient> addedingredients = new List<Ingredient>();
            foreach (var pId in p.addedingredientsId)
            {
                Ingredient ingr = db.Ingredients.Find(pId);
                addedingredients.Add(ingr);
            }
            OrderLine ol = db.OrderLines.Find(p.Id);
            ol.Weight = p.weight;
            ol.Custom = p.custom;
            ol.PizzaId = p.pizzaId;
            ol.PositionPrice = p.position_price;
            ol.PizzaSizesId = p.pizza_sizesId;
            ol.Quantity = p.quantity;
            ol.OrdersId = p.ordersId;
            ol.Ingredients = addedingredients;
            Save();
        }

        public void DeleteOrderLine(int id)
        {
            OrderLine p = db.OrderLines.Find(id);
            if (p != null)
            {
                db.OrderLines.Remove(p);
                Save();
            }
        }


        public bool Save()
        {
            if (db.SaveChanges() > 0) return true;
            return false;
        }

        public List<PizzaDto> GetPizzas()
        {
            return db.Pizzas.ToList().Select(i => new PizzaDto(i)).ToList();
        }

        public List<PizzaSizesDto> GetPizzaSizes()
        {
            return db.PizzaSizes.ToList().Select(i => new PizzaSizesDto(i)).ToList();
        }

        public List<DelStatusDto> GetDelStatuses()
        {
            return db.DelStatuses.ToList().Select(i => new DelStatusDto(i)).ToList();
        }

        public BindingList<IngredientShortDto> GetIngredients(PizzaSize ps)
        {
            var res = db.Ingredients.ToList().Select(i => new IngredientShortDto
            {
                Id = i.Id,
                C_name = i.Name,
                price = ps == PizzaSize.Small ? i.PricePerGram * i.Small : ps == PizzaSize.Medium ?
                i.PricePerGram * i.Medium : i.PricePerGram * i.Big,
                weight = ps == PizzaSize.Small ? i.Small : ps == PizzaSize.Medium ?
                i.Medium : i.Big,
                active = false
            }).ToList();
            var blres = new BindingList<IngredientShortDto>(res);
            return blres;
        }

        public BindingList<IngredientShortDto> GetConcreteIngredients(PizzaSize ps, int ol_id)
        {
            //OrderLine concrete_ol = db.OrderLines.FirstOrDefault(p => p.Id == ol_id);
            //if (concrete_ol == null)
            //    throw new ArgumentException($"Pizza with ID {ol_id} not found");
            //var res = (from Ingredient1 in db.Ingredients
            //           join Ingredient2 in concrete_ol.Ingredients
            //           on Ingredient1.Id equals Ingredient2.Id into iolGroup
            //           select new IngredientShortDto
            //           {
            //               Id = Ingredient1.Id,
            //               C_name = Ingredient1.Name,
            //               price = ps == PizzaSize.Small ? Ingredient1.PricePerGram * Ingredient1.Small : ps == PizzaSize.Medium ?
            //    Ingredient1.PricePerGram * Ingredient1.Medium : Ingredient1.PricePerGram * Ingredient1.Big,
            //               weight = ps == PizzaSize.Small ? Ingredient1.Small : ps == PizzaSize.Medium ?
            //    Ingredient1.Medium : Ingredient1.Big,
            //               active = iolGroup.Any()
            //           }).ToList();

            //var res = db.Ingredients.Where(i => i.OrderLines.Any(ol => ol.Id == ol_id)).ToList()
            //    .Select(i => new IngredientShortDto
            //    {
            //        Id = i.Id,
            //        C_name = i.Name,
            //        price = ps == PizzaSize.Small ? i.PricePerGram * i.Small : ps == PizzaSize.Medium ?
            //            i.PricePerGram * i.Medium : i.PricePerGram * i.Big,
            //        weight = ps == PizzaSize.Small ? i.Small : ps == PizzaSize.Medium ?
            //            i.Medium : i.Big,
            //        active = true
            //    }).ToList();

            var res = db.Ingredients.Select(i => new IngredientShortDto
            {
                Id = i.Id,
                C_name = i.Name,
                price = ps == PizzaSize.Small ? i.PricePerGram * i.Small : ps == PizzaSize.Medium ?
                    i.PricePerGram * i.Medium : i.PricePerGram * i.Big,
                weight = ps == PizzaSize.Small ? i.Small : ps == PizzaSize.Medium ?
                    i.Medium : i.Big,
                active = i.OrderLines.Any(ol => ol.Id == ol_id)
            }).ToList();
            var blres = new BindingList<IngredientShortDto>(res);
            return blres;
        }

        public (decimal price, decimal weight) GetBasePriceAndWeight(PizzaSize ps)
        {

            var res = db.PizzaSizes.ToList().Where(i => i.Id == (int) ps/*(int)Convert.ChangeType(ps, ps.GetTypeCode())*/).
                Select(i => new
                {
                    price = i.Price,
                    weight = i.Weight
                }).FirstOrDefault();
            return (res.price, res.weight);
        }

        public (decimal price, decimal weight) GetConcretePriceAndWeight(int p_id, PizzaSize ps, decimal count)
        {
            //Pizza concrete_pizza = db.Pizzas.FirstOrDefault(p => p.Id == p_id);
            //if (concrete_pizza == null)
            //    throw new ArgumentException($"Pizza with ID {p_id} not found");
            decimal res_price = 0, res_weight = 0, base_price, base_weight;
            (base_price, base_weight) = GetBasePriceAndWeight(ps);
            if (ps == PizzaSize.Small)
            {
                res_price = db.Ingredients.Where(p => p.Pizzas.Any(i => i.Id == p_id))
                .Select(p => new
                {
                    price = p.PricePerGram*p.Small

                }).Sum(i => i.price);
                res_weight = db.Ingredients.Where(p => p.Pizzas.Any(i => i.Id == p_id))
                    .Sum(i => i.Small);
            }
            else if (ps == PizzaSize.Medium)
            {
                res_price = db.Ingredients.Where(p => p.Pizzas.Any(i => i.Id == p_id))
                .Select(p => new
                {
                    price = p.PricePerGram * p.Medium

                }).Sum(i => i.price);
                res_weight = db.Ingredients.Where(p => p.Pizzas.Any(i => i.Id == p_id))
                    .Sum(i => i.Medium);
            }
            else
            {
                res_price = db.Ingredients.Where(p => p.Pizzas.Any(i => i.Id == p_id))
                .Select(p => new
                {
                    price = p.PricePerGram * p.Big

                }).Sum(i => i.price);
                res_weight = db.Ingredients.Where(p => p.Pizzas.Any(i => i.Id == p_id))
                    .Sum(i => i.Big);
            }
            res_price += base_price;
            res_weight += base_weight;
            return (res_price * count, res_weight * count);

        }


        public (decimal price, decimal weight) PriceAndWeightCalculation(BindingList<IngredientShortDto> allingredients, PizzaSize ps, int p_id, decimal count)
        {
            decimal price, weight, res_price, res_weight;
            (price, weight) = GetConcretePriceAndWeight(p_id, ps, count);

            res_price = allingredients.Where(i => i.active == true).Sum(i => i.price);
            res_price *= count;
            res_weight = allingredients.Where(i => i.active == true).Sum(i => i.weight);
            res_weight *= count;
            price += res_price;
            weight += res_weight;
            return (price, weight);
        }

        public void ChangeAdditionalItems(BindingList<IngredientShortDto> allingredients, int add_id)
        {
            var res = allingredients.Where(i => i.Id == add_id).First();
            res.active = !res.active;
        }
    }
}
