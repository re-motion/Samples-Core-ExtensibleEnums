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
using Remotion.ExtensibleEnums;
using Remotion.Globalization;

namespace BaseColors
{
  [MultiLingualResources ("BaseColors.Resources.ColorExtensions")]
  public static class ColorExtensions
  {
    [ExtensibleEnumPosition(1.0)]
    public static Color Red (this ExtensibleEnumDefinition<Color> definition)
    {
      return new Color (MethodBase.GetCurrentMethod ());
    }

    [ExtensibleEnumPosition (2.0)]
    public static Color Green (this ExtensibleEnumDefinition<Color> definition)
    {
      return new Color (MethodBase.GetCurrentMethod ());
    }

    [ExtensibleEnumPosition (3.0)]
    public static Color Blue (this ExtensibleEnumDefinition<Color> definition)
    {
      return new Color (MethodBase.GetCurrentMethod ());
    }

    [ExtensibleEnumPosition (1.5)]
    public static MetallicColor RedMetallic (this ExtensibleEnumDefinition<Color> definition)
    {
      return new MetallicColor (MethodBase.GetCurrentMethod ());
    }

    [ExtensibleEnumPosition (2.5)]
    public static MetallicColor GreenMetallic (this ExtensibleEnumDefinition<Color> definition)
    {
      return new MetallicColor (MethodBase.GetCurrentMethod ());
    }

    [ExtensibleEnumPosition (3.5)]
    public static MetallicColor BlueMetallic (this ExtensibleEnumDefinition<Color> definition)
    {
      return new MetallicColor (MethodBase.GetCurrentMethod ());
    }
  }
}