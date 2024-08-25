using UnityEngine;

public class Shop : MonoBehaviour
{
    [SerializeField] CoinStatistics _coinStatistics;

    PlayerModifier _playerModifier;

    private void Start()
    {
        _playerModifier = FindObjectOfType<PlayerModifier>();
    }
    public void BuySpeed()
    {
        if(_coinStatistics.numberOfCoins >= 30)
        {
            _coinStatistics.SpendMoney(30);
            UserProgress.Instance.Coins = _coinStatistics.numberOfCoins;
            UserProgress.Instance.Speed += 1;
            _playerModifier.SetSpeed(UserProgress.Instance.Speed);
        }
    }
    public void BuyWidth()
    {
        if(_coinStatistics.numberOfCoins >= 30)
        {
            _coinStatistics.SpendMoney(30);
            UserProgress.Instance.Coins = _coinStatistics.numberOfCoins;
            UserProgress.Instance.Width += 25;
            _playerModifier.SetWidth(UserProgress.Instance.Width);
        }
    }
    public void BuyHeight()
    {
        if (_coinStatistics.numberOfCoins >= 30)
        {
            _coinStatistics.SpendMoney(30);
            UserProgress.Instance.Coins = _coinStatistics.numberOfCoins;
            UserProgress.Instance.Height += 25;
            _playerModifier.SetHeight(UserProgress.Instance.Height);
        }
    }
}
