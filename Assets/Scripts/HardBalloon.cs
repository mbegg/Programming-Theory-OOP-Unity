using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HardBalloon : Balloon
{
    public float floatrate = 1.5f;
    public int score = 10;

    private void Awake()
    {
        ScoreToGive = score;
        ClicksToPop = 8;
        ScaleChangePerClick = 2;
        Color = Color.yellow;
        FloatRate = floatrate;
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
