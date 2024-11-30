using DG.Tweening;
using UnityEngine;

public class TranformRotation : MonoBehaviour
{
    [SerializeField] private float _duration;

    private void Start()
    {
        Vector3 targetAngle = new Vector3(360f, 0f, 0f);
        int animationRepeats = -1;

        transform.DORotate(targetAngle, _duration, RotateMode.FastBeyond360)
            .SetEase(Ease.Linear)
            .SetLoops(animationRepeats, LoopType.Incremental);
    }
}
