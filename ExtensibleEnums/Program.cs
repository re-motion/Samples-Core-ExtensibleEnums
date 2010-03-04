// Copyright (c) 2009 rubicon informationstechnologie gmbh
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
using System;
using BaseColors;
using OtherColors;

namespace ExtensibleEnums
{
  public class Program
  {
    public static void Main (string[] args)
    {
      var blue = Color.Values.Blue ();
      var blueMetallic = Color.Values.BlueMetallic ();
      Console.WriteLine ("blue == Color.Values.Blue: {0}", blue == Color.Values.Blue ());
      Console.WriteLine ("blueMetallic == Color.Values.Blue: {0}", blueMetallic == Color.Values.Blue ());
      Console.WriteLine ("blueMetallic == Color.Values.BlueMetallic: {0}", blueMetallic == Color.Values.BlueMetallic ());
      Console.WriteLine ();

      var valueInfos = Color.Values.GetValueInfos();
      Console.WriteLine ("Total: {0} colors", valueInfos.Count);
      foreach (var valueInfo in valueInfos)
        Console.WriteLine ("Color: {0,-46} Name={1,-18} DeclarationSpace={2}", valueInfo.Value.ID, valueInfo.Value.ValueName, valueInfo.Value.DeclarationSpace);
      Console.WriteLine ();

      TestPolymorphicOperation (Color.Values.Blue ());
      TestPolymorphicOperation (Color.Values.BlueMetallic ());
      TestPolymorphicOperation (Color.Values.GoldenBlue ());
    }

    private static void TestPolymorphicOperation(Color color)
    {
      Console.WriteLine ("Color {0} is shiny? {1}.", color.ValueName, color.IsShiny());
      color.PolymorphicOperation ();
      Console.WriteLine ();
    }
  }
}