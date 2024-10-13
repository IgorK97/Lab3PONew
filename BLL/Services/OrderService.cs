using BLL.DTO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class OrderService
    {
        PizzaDeliveryContext db;
        public OrderService()
        {
            db = new PizzaDeliveryContext();
        }

        public int GetCurrentOrder(int ClientId)
        {
            //OrderDto oid = (OrderDto) db.orders.Where(i =>
            //i.clientId == ClientId && i.delstatusId == 2);
            //return oid;
            int oid = 0;
            oid = db.Orders.Where(i => i.ClientId == ClientId && i.DelstatusId == 1).
                Select(o => o.Id).FirstOrDefault();
            //Если такого нет, то создать такой
            if (oid == 0)
            {
                bool s = MakeOrder(ClientId);
                oid = db.Orders.Where(i => i.ClientId == ClientId && i.DelstatusId == 1).
                Select(o => o.Id).FirstOrDefault();
            }
            return oid;
        }

        public enum DeliveryStatus
        {
            NotPlaced = 1,
            Canceled = 2,
            IsBeingFormed = 3,
            AtTheCourier = 5,
            Delivered = 6,
            NotDelivered = 7,
            HandedOver = 8
        };

        public bool MakeOrder(int ClientId)
        {
            Order order = new Order
            {
                //id = null,
                //id=0,
                //Id= default,
                ClientId = ClientId,
                FinalPrice=0,
                Weight = 0,
                DelstatusId = 1,
                AddressDel = "",
                Comment = ""
            };
            db.Orders.Add(order);
            if (db.SaveChanges() > 0)
                return true;
            return false;
        }

        //public bool MakeOrder(OrderDto orderDto)
        //{
        //    List<order_lines> orderlines = new List<order_lines>();
        //    decimal sum = 0;
        //    decimal weight = 0;
        //    foreach (var pId in orderDto.order_linesIds)
        //    {
        //        order_lines ol = db.order_lines.Find(pId);
        //        // валидация
        //        if (ol == null)
        //            throw new Exception("Строка заказа не найдена");
        //        sum += ol.position_price;
        //        weight += ol.weight;
        //        orderlines.Add(ol);
        //    }


        //    orders order = new orders
        //    {
        //        clientId = orderDto.clientId,
        //        final_price = orderDto.final_price,
        //        weight = orderDto.weight,
        //        ordertime = DateTimeOffset.Now,
        //        delstatusId = 1,
        //        order_lines = orderlines,
        //        address_del=orderDto.address_del
        //    };

        //    db.orders.Add(order);
        //    if (db.SaveChanges() > 0)
        //        return true;
        //    return false;

        //}


        public List<OrderDto> GetAllOrders(int ClientId)
        {
            return db.Orders.ToList().Where(i => i.ClientId == ClientId).Select(i => new OrderDto(i)).ToList();
        }

        public List<ManagerDto> GetAllManagers()
        {
            return db.Managers.ToList().Select(i => new ManagerDto(i)).ToList();
        }

        public List<CouriersDto> GetAllCouriers()
        {
            return db.Couriers.ToList().Select(i => new CouriersDto(i)).ToList();
        }
    }
}
