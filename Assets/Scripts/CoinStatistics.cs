using TMPro;
using UnityEditor;
using UnityEngine;

public class CoinStatistics : MonoBehaviour
{
    public int numberOfCoins;
    [SerializeField] TextMeshProUGUI _text;
    public void Start()
    {
        numberOfCoins = UserProgress.Instance.Coins;
        _text.text = numberOfCoins.ToString();
    }
    public void AddCoin()
    {
        numberOfCoins++;
        _text.text = numberOfCoins.ToString();
    }
    public void SaveToProgress()
    {
        UserProgress.Instance.Coins = numberOfCoins;
    }
    public void SpendMoney(int _value)
    {
        numberOfCoins -= _value;
        _text.text = numberOfCoins.ToString();
    }
}
