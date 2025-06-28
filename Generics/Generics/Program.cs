// See https://aka.ms/new-console-template for more information

using Generics;

DataFlow<string> dataFlow = new DataFlow<string>();

dataFlow.AddBlock(new UpperCaseBlock());
dataFlow.AddBlock(new ReverseBlock());
dataFlow.AddBlock(new ReplaceAWithSixBlock());


Console.WriteLine(dataFlow.RunFlow("AbcAd"));
