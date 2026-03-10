using CL_Expression;

Expression exp1 = new Addition(new Nombre(11), new Addition(new Nombre(22), new Nombre(33)));
Expression exp2 = new Soustraction(new Nombre(11), new Addition(new Nombre(22), new Nombre(33)));
Expression exp3 = new Soustraction(new Nombre(11), new Addition(new Nombre(22), new Nombre(33)));
Expression exp4 = new Addition(new Nombre(11), new Nombre(22));

Console.WriteLine(exp1.Formate());
Console.WriteLine(exp2.Formate());
Console.WriteLine(exp4.Formate());