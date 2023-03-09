using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpossibleBalloon : Balloon
{
    public float floatrate = 5f;
    public int score = 50;

    private void Awake()
    {
        ScoreToGive = score;
        ClicksToPop = 10;
        ScaleChangePerClick = 2;
        Color = Color.red;
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
