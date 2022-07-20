// See https://aka.ms/new-console-template for more information
using System;
using Factory;
using Factory.FactoryClasses;
using Factory.ObjectTrackingBulkReplacement;

// var point = PointFactory.NewPolarPoint(1.0, Math.PI/2);
var point = Point.Factory.NewPolarPoint(1.0, Math.PI/2);
Console.WriteLine(point);

AsyncFactory x = await AsyncFactory.CreateAsync();


//Object tracking and bulk replacement 
var factory = new TrackingThemeFactory();
var theme1 = factory.CreateTheme(false);
var theme2 = factory.CreateTheme(true);
Console.WriteLine(factory.Info);

var factory2 = new ReplaceableThemeFactory();
var magicTheme = factory2.CreateTheme(true);
Console.WriteLine(magicTheme.Value.BgrColor);
factory2.ReplaceTheme(false);
Console.WriteLine(magicTheme.Value.BgrColor);
