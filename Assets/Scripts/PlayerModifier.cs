using UnityEngine;

public class PlayerModifier : MonoBehaviour
{
    [SerializeField] int _width;
    [SerializeField] int _height;
    [SerializeField] float _speed;

    [SerializeField] Renderer _renderer;

    [SerializeField] Transform _topSpine;
    [SerializeField] Transform _bottomSpine;
    [SerializeField] Transform _colliderTransform;

    [SerializeField] AudioSource _upgradeSound;
    [SerializeField] AudioSource _memeAudio;

    float _widthMultiplier = 0.001f;
    float _heightMultiplier = 0.01f;

    private void Start()
    {
        SetWidth(UserProgress.Instance.Width);
        SetHeight(UserProgress.Instance.Height);
        SetSpeed(UserProgress.Instance.Speed);
    }
    void UpdateWidth()
    {
        _renderer.material.SetFloat("_PushValue", _width * _widthMultiplier);
    }
    public void AddWidth(int _value)
    {
        _width += _value;
        UpdateWidth();
        if(_value > 0)
        {
            _upgradeSound.Play();
        }
    }
    public void AddHeight(int _value)
    {
        _height += _value;
        if (_value > 0)
        {
            _upgradeSound.Play();
        }
    }
    public void SetWidth(int _value)
    {
        _width = _value;
        UpdateWidth();
    }
    public void SetHeight(int _value)
    {
        _height = _value;
    }
    public void SetSpeed(int _value)
    {
        _speed += _value;
        PlayerMove.speed = _speed;
        if(_value > 0) { _memeAudio.Play(); }
    }    
    void Death()
    {
        FindObjectOfType<GameManager>().ShowEndWindow();
        Destroy(gameObject);
    }    
    public void HitBarrier()
    {
        if (_width > 0)
        {
            _width -= 40;
            UpdateWidth();
            
        }
        else if (_height > 0)
        {
            _height -= 40;
        }
        else { Death();}
    }
    private void Update()
    {
        float offsetY = _height * _heightMultiplier + 0.17f;
        _topSpine.position = _bottomSpine.position + new Vector3(0, offsetY, 0);
        _colliderTransform.localScale = new Vector3(1, 1.84f + _height * _heightMultiplier, 1);
    }
}