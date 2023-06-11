using UnityEngine;
using UnityEngine.UI;

public class Example : MonoBehaviour
{
    public Text text;
    public double value = 0;
    public int n = 2;
    private void OnValidate()
    {
        text.text = SFNuffix.GetFullValue(value, n);
    }
}
