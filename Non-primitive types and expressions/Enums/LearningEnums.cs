using System;

namespace LearningEnums;

public enum ShippingMethod
{
	RegularMail = 1,
	SuperMail = 2,
	Express = 3
}



public class LearningEnums
{
	static void Main(String[]args)
	{
		var method = ShippingMethod.Express;
		Console.WriteLine((int)method);
		var methodId = 3;
		Console.WriteLine((ShippingMethod)methodId);
		Console.WriteLine(method.ToString());
		var methodName = "Express";
		var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);

    }
}

