﻿using DesignPattern.Facade.DAL;

namespace DesignPattern.Facade.FacadePattern
{
    public class OrderFacade
    {
        Order order= new Order();
        OrderDetail orderDetail= new OrderDetail();
        ProductStock productStock= new ProductStock();

        AddOrder addOrder= new AddOrder();
        AddOrderDetail addOrderDetail= new AddOrderDetail();

        public void CompleteOrderDetail(int customerID, int productID,int orderId,int productCount,decimal productPrice)
        {
          

            orderDetail.OrderID=orderId;
            orderDetail.CustomerID = customerID;
            orderDetail.ProductID = productID;
            orderDetail.ProductPrice = productPrice;
            orderDetail.ProductCount = productCount;
            decimal totalProductPrice= productCount * productPrice;
            orderDetail.ProductTotalPrice= totalProductPrice;
            addOrderDetail.AddNewOrderDetail(orderDetail);

            productStock.StockDecrease(productID, productCount);

        }
        public void CompleteOrder(int customerID)
        {
            order.CustomerID = customerID;
            addOrder.AddNewOrder(order);
        }
    }
}
