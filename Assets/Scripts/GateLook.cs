using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public enum DeformationType
{
    Width,
    Height
}
public class GateLook : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _text;

    [SerializeField] Image _topImage;
    [SerializeField] Image _glassImage;

    [SerializeField] Color _colorPositive;
    [SerializeField] Color _colorNegative;

    [SerializeField] GameObject _expandLabel;
    [SerializeField] GameObject _shrinkLabel;
    [SerializeField] GameObject _upLabel;
    [SerializeField] GameObject _downLabel;

    public void VisualUpdate(DeformationType _deformationType, int _value)
    {
        char prefix = ' ';
        if (_value > 0)
        {
            prefix = '+';
            SetColor(_colorPositive);
        }
        else
        {
            SetColor(_colorNegative);
        }
        _expandLabel.SetActive(false);
        _shrinkLabel.SetActive(false);
        _upLabel.SetActive(false);
        _downLabel.SetActive(false);
        switch (_deformationType)
        {
            case DeformationType.Width:
                _expandLabel.SetActive(_value > 0);
                _shrinkLabel.SetActive(_value < 0);
                break;
            case DeformationType.Height:
                _upLabel.SetActive(_value > 0);
                _downLabel.SetActive(_value < 0);
                break;
        }
        _text.text = prefix + _value.ToString();
    }
        void SetColor(Color color)
    {
        _topImage.color = color;
        _glassImage.color = new Color(color.r, color.g, color.b, 0.5f);
    }
}
