using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EasyBalloon : Balloon
{
    public float floatrate = 0.1f;
    public int score = 1;

    private void Awake()
    {
        ScoreToGive = score;
        ClicksToPop = 3;
        ScaleChangePerClick = 2;
        Color = Color.green;
        SetColor();
    }

    private void Update()
    {
        BalloonFloat();
        PopBalloon();
    }

    public override void BalloonFloat()
    {
        transform.Translate(Vector3.up * floatrate * Time.deltaTime);
    }

}
