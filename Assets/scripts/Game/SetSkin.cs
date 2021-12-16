using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetSkin : MonoBehaviour
{
    public int NumberSkin;
    [SerializeField] private Sprite[] bodyS, tailS, leg1S, leg2S, leg3S, leg4S, eyeS, ear1S, ear2S;
    private SpriteRenderer body, tail, leg1, leg2, leg3, leg4, eye, ear1, ear2;

    private void Awake()
    {
        NumberSkin = PlayerPrefs.GetInt("index");
    }

    private void Start()
    {
        body = transform.GetChild(2).GetComponent<SpriteRenderer>();
        tail = transform.GetChild(6).GetComponent<SpriteRenderer>();
        leg1 = transform.GetChild(1).GetComponent<SpriteRenderer>();
        leg2 = transform.GetChild(3).GetComponent<SpriteRenderer>();
        leg3 = transform.GetChild(4).GetComponent<SpriteRenderer>();
        leg4 = transform.GetChild(5).GetComponent<SpriteRenderer>();
        eye = transform.GetChild(7).GetComponent<SpriteRenderer>();
        ear1 = transform.GetChild(9).GetComponent<SpriteRenderer>();
        ear2 = transform.GetChild(8).GetComponent<SpriteRenderer>();
        UpdateSkin(NumberSkin);
    }

    public void UpdateSkin(int index)
    {
        body.sprite = bodyS[index];
        tail.sprite = tailS[index];
        leg1.sprite = leg1S[index];
        leg2.sprite = leg2S[index];
        leg3.sprite = leg3S[index];
        leg4.sprite = leg4S[index];
        eye.sprite = eyeS[index];
        ear1.sprite = ear1S[index];
        ear2.sprite = ear2S[index];

    }

}
