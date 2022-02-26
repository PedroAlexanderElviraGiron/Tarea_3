static void desglose()
{
	float CAN;
	int C200, C100, C50, C20, C10, C5, C1, M50, M25, M10, M5, M1;
	C200 = 0;
	C100 = 0;
	C50 = 0;
	C20 = 0;
	C10 = 0;
	C5 = 0;
	C1 = 0;
	M50 = 0;
	M25 = 0;
	M10 = 0;
	M5 = 0;
	M1 = 0;

	string linea;
	Console.Write("Ingrese la cantidad en Q :");
	linea = Console.ReadLine();

	CAN = float.Parse(linea);
	Console.WriteLine("La Cantidad introducida es: " + CAN);
	if ((CAN >= 200))
	{
		C200 = ((int)CAN / 200);
		CAN = CAN - (C200 * 200);
	}
	if ((CAN >= 100))
	{
		C100 = ((int)CAN / 100);
		CAN = CAN - (C100 * 100);
	}
	if ((CAN >= 50))
	{
		C50 = ((int)CAN / 50);
		CAN = CAN - (C50 * 50);
	}
	if ((CAN >= 20))
	{
		C20 = ((int)CAN / 20);
		CAN = CAN - (C20 * 20);
	}
	if ((CAN >= 10))
	{
		C10 = ((int)CAN / 10);
		CAN = CAN - (C10 * 10);
	}
	if ((CAN >= 5))
	{
		C5 = ((int)CAN / 5);
		CAN = CAN - (C5 * 5);
	}
	if ((CAN >= 1))
	{
		C1 = ((int)CAN / 1);
		CAN = CAN - (C1 * 1);
	}
	if ((CAN >= 0.5))
	{
		M50 = (int)(CAN / 0.5);
		CAN = CAN - (float)(M50 * 0.5);
	}
	if ((CAN >= 0.25))
	{
		M25 = (int)(CAN / 0.25);
		CAN = CAN - (float)(M25 * 0.25);
	}
	if ((CAN >= 0.1))
	{
		M10 = (int)(CAN / 0.1);
		CAN = CAN - (float)(M10 * 0.1);
	}
	if ((CAN >= 0.05))
	{
		M5 = (int)(CAN / 0.05);
		CAN = CAN - (float)(M5 * 0.05);
	}
	if ((CAN >= 0.01))
	{
		M1 = (int)Math.Round(CAN / 0.01);
		CAN = CAN - (float)(M1 * 0.01);
	}
	Console.WriteLine("Billetes de Q200: " + C200);
	Console.WriteLine("Billetes de Q100: " + C100);
	Console.WriteLine("Billetes de Q50 : " + C50);
	Console.WriteLine("Billetes de Q20 : " + C20);
	Console.WriteLine("Billetes de Q10 : " + C10);
	Console.WriteLine("Billetes de Q5 : " + C5);
	Console.WriteLine("Billetes de Q1 : " + C1);
	Console.WriteLine("Monedas de ¢50 : " + M50);
	Console.WriteLine("Monedas de ¢25 : " + M25);
	Console.WriteLine("Monedas de ¢10 : " + M10);
	Console.WriteLine("Monedas de ¢5 : " + M5);
	Console.WriteLine("Monedas de ¢1 : " + M1);
}//fin desglose 

static void desgloseSwitch()
{
	float CAN;
	int C200, C100, C50, C20, C10, C5, C1, M50, M25, M10, M5, M1;
	string cant1;
	int cant2;
	C200 = 0;
	C100 = 0;
	C50 = 0;
	C20 = 0;
	C10 = 0;
	C5 = 0;
	C1 = 0;
	M50 = 0;
	M25 = 0;
	M10 = 0;
	M5 = 0;
	M1 = 0;
	string linea;
	Console.WriteLine("Escriba 1 para ingresar la cantidad");
	cant1 = Console.ReadLine();
	cant2 = Convert.ToInt32(cant1);
	switch (cant2)
	{
		case 1:
			Console.Write("Ingrese una cantidad en Q :");
			linea = Console.ReadLine();

			CAN = float.Parse(linea);
			if ((CAN >= 200))
			{
				C200 = ((int)CAN / 200);
				CAN = CAN - (C200 * 200);
			}
			if ((CAN >= 100))
			{
				C100 = ((int)CAN / 100);
				CAN = CAN - (C100 * 100);
			}
			if ((CAN >= 50))
			{
				C50 = ((int)CAN / 50);
				CAN = CAN - (C50 * 50);
			}
			if ((CAN >= 20))
			{
				C20 = ((int)CAN / 20);
				CAN = CAN - (C20 * 20);
			}
			if ((CAN >= 10))
			{
				C10 = ((int)CAN / 10);
				CAN = CAN - (C10 * 10);
			}
			if ((CAN >= 5))
			{
				C5 = ((int)CAN / 5);
				CAN = CAN - (C5 * 5);
			}
			if ((CAN >= 1))
			{
				C1 = ((int)CAN / 1);
				CAN = CAN - (C1 * 1);
			}
			if ((CAN >= 0.5))
			{
				M50 = (int)(CAN / 0.5);
				CAN = CAN - (float)(M50 * 0.5);
			}
			if ((CAN >= 0.25))
			{
				M25 = (int)(CAN / 0.25);
				CAN = CAN - (float)(M25 * 0.25);
			}
			if ((CAN >= 0.1))
			{
				M10 = (int)(CAN / 0.1);
				CAN = CAN - (float)(M10 * 0.1);
			}
			if ((CAN >= 0.05))
			{
				M5 = (int)(CAN / 0.05);
				CAN = CAN - (float)(M5 * 0.05);
			}
			if ((CAN >= 0.01))
			{
				M1 = (int)Math.Round(CAN / 0.01);
				CAN = CAN - (float)(M1 * 0.01);
			}
			Console.WriteLine("Billetes de Q200: " + C200);
			Console.WriteLine("Billetes de Q100: " + C100);
			Console.WriteLine("Billetes de Q50 : " + C50);
			Console.WriteLine("Billetes de Q20 : " + C20);
			Console.WriteLine("Billetes de Q10 : " + C10);
			Console.WriteLine("Billetes de Q5 : " + C5);
			Console.WriteLine("Billetes de Q1 : " + C1);
			Console.WriteLine("Monedas de ¢50 : " + M50);
			Console.WriteLine("Monedas de ¢25 : " + M25);
			Console.WriteLine("Monedas de ¢10 : " + M10);
			Console.WriteLine("Monedas de ¢5 : " + M5);
			Console.WriteLine("Monedas de ¢1 : " + M1);
			break;
	}
}//fin desgloseswitch
static void desglosedollar()
{
	double CAN;
	int C200, C100, C50, C20, C10, C5, C1, M50, M25, M10, M5, M1;
	C200 = 0;
	C100 = 0;
	C50 = 0;
	C20 = 0;
	C10 = 0;
	C5 = 0;
	C1 = 0;
	M50 = 0;
	M25 = 0;
	M10 = 0;
	M5 = 0;
	M1 = 0;

	string linea;
	Console.Write("Ingrese la cantidad en $$ :");
	linea = Console.ReadLine();

	CAN = double.Parse(linea);
	Console.WriteLine("La Cantidad introducida es: " + CAN);
	CAN = CAN * 7.70;
	if ((CAN >= 200))
	{
		C200 = ((int)CAN / 200);
		CAN = CAN - (C200 * 200);
	}
	if ((CAN >= 100))
	{
		C100 = ((int)CAN / 100);
		CAN = CAN - (C100 * 100);
	}
	if ((CAN >= 50))
	{
		C50 = ((int)CAN / 50);
		CAN = CAN - (C50 * 50);
	}
	if ((CAN >= 20))
	{
		C20 = ((int)CAN / 20);
		CAN = CAN - (C20 * 20);
	}
	if ((CAN >= 10))
	{
		C10 = ((int)CAN / 10);
		CAN = CAN - (C10 * 10);
	}
	if ((CAN >= 5))
	{
		C5 = ((int)CAN / 5);
		CAN = CAN - (C5 * 5);
	}
	if ((CAN >= 1))
	{
		C1 = ((int)CAN / 1);
		CAN = CAN - (C1 * 1);
	}
	if ((CAN >= 0.5))
	{
		M50 = (int)(CAN / 0.5);
		CAN = CAN - (float)(M50 * 0.5);
	}
	if ((CAN >= 0.25))
	{
		M25 = (int)(CAN / 0.25);
		CAN = CAN - (float)(M25 * 0.25);
	}
	if ((CAN >= 0.1))
	{
		M10 = (int)(CAN / 0.1);
		CAN = CAN - (float)(M10 * 0.1);
	}
	if ((CAN >= 0.05))
	{
		M5 = (int)(CAN / 0.05);
		CAN = CAN - (float)(M5 * 0.05);
	}
	if ((CAN >= 0.01))
	{
		M1 = (int)Math.Round(CAN / 0.01);
		CAN = CAN - (float)(M1 * 0.01);
	}
	Console.WriteLine("Billetes de Q200: " + C200);
	Console.WriteLine("Billetes de Q100: " + C100);
	Console.WriteLine("Billetes de Q50 : " + C50);
	Console.WriteLine("Billetes de Q20 : " + C20);
	Console.WriteLine("Billetes de Q10 : " + C10);
	Console.WriteLine("Billetes de Q5 : " + C5);
	Console.WriteLine("Billetes de Q1 : " + C1);
	Console.WriteLine("Monedas de ¢50 : " + M50);
	Console.WriteLine("Monedas de ¢25 : " + M25);
	Console.WriteLine("Monedas de ¢10 : " + M10);
	Console.WriteLine("Monedas de ¢5 : " + M5);
	Console.WriteLine("Monedas de ¢1 : " + M1);
}//fin desglosedolar


//desglose(); 
//desgloseSwitch();
//desglosedollar();
