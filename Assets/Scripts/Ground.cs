using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using DG.Tweening;

[RequireComponent(typeof(Collider))]
public class Ground : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] float speed = 0.5f;
    Transform mole;

    // Start is called before the first frame update
    void Start()
    {
        float randomVal = Random.Range(0.1f, 0.4f);
        transform.DOLocalMoveY(randomVal, speed).SetEase(Ease.OutCubic);

        mole = transform.GetChild(0);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("click");
    }


}
