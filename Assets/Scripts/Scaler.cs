using DG.Tweening;
using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _targetScale;
    [SerializeField] private float _duration;

    private void Start()
    {
        int animationRepeat = -1;

        transform.DOScale(_targetScale, _duration)
            .SetEase(Ease.Linear)
            .SetLoops(animationRepeat, LoopType.Yoyo);
    }
}
