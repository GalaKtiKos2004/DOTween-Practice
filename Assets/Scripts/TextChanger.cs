using DG.Tweening;
using UnityEngine.UI;
using UnityEngine;

[RequireComponent (typeof(Text))]
public class TextChanger : MonoBehaviour
{
    [SerializeField] private string _targetReplacedText;
    [SerializeField] private string _addedText;
    [SerializeField] private string _targetScrambledText;
    [SerializeField] private float _duration;

    private Text _text;

    private void Awake()
    {
        _text = GetComponent<Text>();
    }

    private void Start()
    {
        int animationRepeat = -1;

        Sequence textSequence = DOTween.Sequence();

        textSequence.Append(_text.DOText(_addedText, _duration).SetRelative())
            .Append(_text.DOText(_targetReplacedText, _duration))
            .Append(_text.DOText(_targetScrambledText, _duration, true, ScrambleMode.All))
            .SetLoops(animationRepeat, LoopType.Yoyo);
    }
}
