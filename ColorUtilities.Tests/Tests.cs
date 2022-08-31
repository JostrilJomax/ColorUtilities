using ColorUtilities;
using UnityEditor;
using UnityEngine;

namespace Plugins.ColorUtilities.ColorUtilities.Tests {
public static class Tests {


    [InitializeOnLoadMethod]
    public static void SimpleTests()
    {

        var rgb = new Rgb(0, 0, 0);

        var hex = new Hex("#000000");

        // Debug.Log(rgb == (Rgb) hex);

        Debug.Log(Color.black == Color.white);


    }

    public static void TestEqualityOperator()
    {

    }

}
}
