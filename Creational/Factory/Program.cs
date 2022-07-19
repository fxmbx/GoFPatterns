// See https://aka.ms/new-console-template for more information
using System;
using Factory;



var point = Point.NewPolarPoint(1.0, Math.PI/2);
Console.WriteLine(point);

AsyncFactory x = await AsyncFactory.CreateAsync();