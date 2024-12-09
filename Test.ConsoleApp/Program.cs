// See https://aka.ms/new-console-template for more information

using Test.ConsoleApp;

Console.WriteLine("Hello, World!");

Console.WriteLine("I'm a random line!");

var username = "admin";
var password = "secretP@ssword";
var mockService = new MockService();
mockService.PerformAction(username, password);