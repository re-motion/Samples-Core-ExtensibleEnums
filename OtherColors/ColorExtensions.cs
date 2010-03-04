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
using System.Reflection;
using BaseColors;
using Remotion.ExtensibleEnums;

namespace OtherColors
{
  public static class ColorExtensions
  {
    public static Color LightRed (this ExtensibleEnumDefinition<Color> definition)
    {
      return new Color (MethodBase.GetCurrentMethod ());
    }

    public static Color LightGreen (this ExtensibleEnumDefinition<Color> definition)
    {
      return new Color (MethodBase.GetCurrentMethod ());
    }

    public static Color LightBlue (this ExtensibleEnumDefinition<Color> definition)
    {
      return new Color (MethodBase.GetCurrentMethod ());
    }

    public static MetallicColor LightRedMetallic (this ExtensibleEnumDefinition<Color> definition)
    {
      return new MetallicColor (MethodBase.GetCurrentMethod ());
    }

    public static MetallicColor LightGreenMetallic (this ExtensibleEnumDefinition<Color> definition)
    {
      return new MetallicColor (MethodBase.GetCurrentMethod ());
    }

    public static MetallicColor LightBlueMetallic (this ExtensibleEnumDefinition<Color> definition)
    {
      return new MetallicColor (MethodBase.GetCurrentMethod ());
    }

    public static GoldenColor GoldenRed (this ExtensibleEnumDefinition<Color> definition)
    {
      return new GoldenColor (MethodBase.GetCurrentMethod ());
    }

    public static GoldenColor GoldenGreen (this ExtensibleEnumDefinition<Color> definition)
    {
      return new GoldenColor (MethodBase.GetCurrentMethod ());
    }

    public static GoldenColor GoldenBlue (this ExtensibleEnumDefinition<Color> definition)
    {
      return new GoldenColor (MethodBase.GetCurrentMethod ());
    }
  }
}