using UnityEngine;
using UnityEngine.UI;

public class clicker : MonoBehaviour
{
    private int num;
    public Text textNum;

    public void addNum()
    {
        num++;
        textNum.text = num.ToString();
    }
}
