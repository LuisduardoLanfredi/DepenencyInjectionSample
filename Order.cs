using System;

public class Order
{
	//public OrderItem OrderItem
	//{
	//	get
	//	{
	//		if (_orderItem == null)
	//			throw new Exception("Not initialized");
	//		return _orderItem;
	//	}
	//	set
	//	{
	//		_orderItem = value;
	//	}
	//}

	private OrderItemInterface _orderItem;

	public Order(OrderItemInterface orderItem)
	{
		_orderItem = orderItem;
	}

	public void AddItem()
	{
		_orderItem.Add();
	}
}
