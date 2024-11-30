using DG.Tweening;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _targetPositionY;
    [SerializeField] private float _duration;

    private void Start()
    {
        int animationRepeats = -1;

        transform.DOMoveY(_targetPositionY, _duration)
            .SetEase(Ease.Linear)
            .SetLoops(animationRepeats, LoopType.Yoyo);
    }
}
